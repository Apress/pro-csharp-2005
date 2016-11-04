#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace GenericInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Generic Interfaces *****\n");

			BasicMath m = new BasicMath();
			Console.WriteLine("1 + 1 = {0}", m.Add(1, 1));
			Console.ReadLine();
		}
	}
}
