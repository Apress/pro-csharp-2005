using System;
using System.Threading;
using System.Windows.Forms;

namespace SimpleMultiThreadApp
{
	#region Worker class type
	public class Printer
	{
		public void PrintNumbers()
		{
			// Display Thread info.
            Console.WriteLine("-> {0} is executing PrintNumbers()",
                Thread.CurrentThread.Name);

            // Do the work.
			Console.Write("Your numbers: ");
			for(int i = 0; i < 10; i++)
			{
				Console.Write(i + ", ");
				Thread.Sleep(2000);
			}
			Console.WriteLine();
		}
	}
	#endregion 

	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** The Amazing Thread App *****\n");
			Console.Write("Do you want [1] or [2] threads? ");
			string threadCount = Console.ReadLine();

			// Name the current thread.
			Thread primaryThread = Thread.CurrentThread;	
			primaryThread.Name = "Primary";

            // Display Thread info.
            Console.WriteLine("-> {0} is executing Main()",
                Thread.CurrentThread.Name);
            
            // Make worker class.
            Printer p = new Printer();

			#region Get user pref.
			switch(threadCount)  	
			{
				case  "2":
					// Now make the thread.
					Thread backgroundThread =
                        new Thread(new ThreadStart(p.PrintNumbers));
                    backgroundThread.Name = "Secondary";
                    backgroundThread.Start();
					break;

				case "1":
                    p.PrintNumbers();
                    break;
				
				default:
					Console.WriteLine("I don't know what you want...you get 1 thread.");
                    goto case "1";
			}
			#endregion

			// Do some additional work.
			MessageBox.Show("I'm busy!", "Work on main thread...");
            Console.ReadLine();
        }
	}
}
