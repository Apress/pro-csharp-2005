#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace SimpleGenerics
{
	#region MyHelperClass
	public class MyHelperClass
	{
		// This method will swap any Value types.
		public static void Swap<T>(ref T a, ref T b) where T : struct
		{
			Console.WriteLine("You sent the Swap() method a {0}",
				typeof(T));
			T temp;
			temp = a;
			a = b;
			b = temp;
		}

		public static void DisplayBaseClass<T>()
		{
			Console.WriteLine("Base class of {0} is: {1}.",
				typeof(T), typeof(T).BaseType);
		}
	}
	
	#endregion
	
	class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Generics *****\n");

            #region Swap ints, strings and bools
            // Swap 2 ints.
            int a = 10, b = 90;
            Console.WriteLine("Before swap: {0}, {1}", a, b);
			MyHelperClass.Swap<int>(ref a, ref b);
			Console.WriteLine("After swap: {0}, {1}", a, b);
            Console.WriteLine();

//            // Swap 2 strings.
//            string s1 = "Hello", s2 = "There";
//            Console.WriteLine("Before swap: {0} {1}!", s1, s2);
//            Swap<string>(ref s1, ref s2);
//            Console.WriteLine("After swap: {0} {1}!", s1, s2);
//            Console.WriteLine();

            // Compiler will infer System.Boolean.
            bool b1 = true, b2 = false;
            Console.WriteLine("Before swap: {0}, {1}", b1, b2);
			MyHelperClass.Swap(ref b1, ref b2);
			Console.WriteLine("After swap: {0}, {1}", b1, b2);
            Console.WriteLine(); 
            #endregion

            #region Generic Point
            // Point using ints.
            Point<int> p = new Point<int>(10, 10);
            Console.WriteLine("p.ToString()={0}", p.ToString());
            p.ResetPoint();
            Console.WriteLine("p.ToString()={0}", p.ToString());
            Console.WriteLine();

            // Point using double.
            Point<double> p2 = new Point<double>(5.4, 3.3);
            Console.WriteLine("p2.ToString()={0}", p2.ToString());
            p2.ResetPoint();
            Console.WriteLine("p2.ToString()={0}", p2.ToString());
            Console.WriteLine();

            // Swap 2 Points.
            Point<int> pointA = new Point<int>(50, 40);
            Point<int> pointB = new Point<int>(543, 1);
            Console.WriteLine("Before swap: {0}, {1}", pointA, pointB);
			MyHelperClass.Swap<Point<int>>(ref pointA, ref pointB);
			Console.WriteLine("After swap: {0}, {1}", pointA, pointB);
            Console.WriteLine();
            #endregion

            // Must supply type parameter if
            // the method does not take params.
			MyHelperClass.DisplayBaseClass<int>();
			MyHelperClass.DisplayBaseClass<string>();

			Console.ReadLine();
        }
    }
}
