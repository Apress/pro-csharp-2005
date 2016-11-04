#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace AnonymousMethods
{
	public class SimpleMath
	{
		public delegate void MathMessage(string msg);
		public event MathMessage ComputationFinished;

		public int Add(int x, int y)
		{
			ComputationFinished("Adding complete.");
			return x + y;
		}

		public int Subtract(int x, int y)
		{
			ComputationFinished("Subtracting complete.");
			return x - y;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			#region Anonymous Methods
			Console.WriteLine("***** Anonymous Methods *****");

			int aboutToBlowCounter = 0;

			// Make a car as usual. 
			Car c1 = new Car("SlugBug", 100, 10);

			// Register event handlers as anonymous methods.          
			c1.AboutToBlow += delegate
			{
				aboutToBlowCounter++;
				Console.WriteLine("Eek!  Going too fast!");
			};

            c1.AboutToBlow += delegate(object sender, CarEventArgs e)
            {
				aboutToBlowCounter++;
				Console.WriteLine("Message from Car: {0}", e.msg);
			};

            c1.Exploded += delegate(object sender, CarEventArgs e)
            { Console.WriteLine("Message from Car: {0}", e.msg); };

            // Speed up (this will generate the events.)
			Console.WriteLine("\n***** Speeding up *****");
			for (int i = 0; i < 6; i++)
				c1.SpeedUp(20);

			Console.WriteLine("AboutToBlow event was fired {0} times",
				aboutToBlowCounter);
			#endregion

			SimpleMath m = new SimpleMath();
			m.ComputationFinished += ComputationFinishedHandler;
			Console.WriteLine("10 + 10 is {0}", m.Add(10, 10));

			// .NET 2.0 allows event handlers to be cast into
			// their underlying delegate.
			SimpleMath.MathMessage mmDelegate = 
				(SimpleMath.MathMessage)ComputationFinishedHandler;
			Console.WriteLine(mmDelegate.Method);

			Console.ReadLine();
		}

		static void ComputationFinishedHandler(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}
