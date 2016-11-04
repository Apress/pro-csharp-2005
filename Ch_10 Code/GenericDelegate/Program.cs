#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace GenericDelegate
{
	// This generic delegate can call any method 
	// returning void and taking a single parameter.
	public delegate void MyGenericDelegate<T>(T arg);

	// A non-generic delegate.
	public delegate void MyDelegate(object arg);

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Generic Delegates *****\n");
			Console.WriteLine("-> Non-generic delegates");

			MyDelegate d = new MyDelegate(MyTarget);
			d("More string data");
			MyDelegate d2 = new MyDelegate(MyTarget);
			d2(9);

			// Create an instance of MyGenericDelegate<T>
			// with string as the type parameter.
			Console.WriteLine("\n-> Generic delegates");
			MyGenericDelegate<string> strTarget = 
				new MyGenericDelegate<string>(StringTarget);
			strTarget("Some string data");

			// Create an instance of MyGenericDelegate<T>
			// with int as the type parameter.
			MyGenericDelegate<int> intTarget = IntTarget;
			intTarget(9);

			Console.ReadLine();
		}

		static void MyTarget(object arg)
		{
			if(arg is int)
			{
				int i = (int)arg;
				Console.WriteLine("++arg is: {0}", ++i);
			}

			if(arg is string)
			{
				string s = (string)arg;
				Console.WriteLine("arg in uppercase is: {0}", s.ToUpper());
			}
		}

		static void StringTarget(string arg)
		{
			Console.WriteLine("arg in uppercase is: {0}", arg.ToUpper());
		}

		static void IntTarget(int arg)
		{
			Console.WriteLine("++arg is: {0}", ++arg);
		}
	}
}
