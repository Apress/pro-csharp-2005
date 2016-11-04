#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Overloaded Operators *****\n");

            // Make two points
            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(40, 40);
            Console.WriteLine("ptOne = {0}", ptOne);
            Console.WriteLine("ptTwo = {0}", ptTwo);

            // Use operator + or Add().
            Console.WriteLine("ptOne + ptTwo: {0} ", ptOne + ptTwo);
            Console.WriteLine("Point.Add(ptOne, ptTwo): {0} ", Point.Add(ptOne, ptTwo));

            // Use operator - or Subtract().
            Console.WriteLine("ptOne - ptTwo: {0} ", ptOne - ptTwo);
            Console.WriteLine("Point.Subtract(ptOne, ptTwo): {0} ", Point.Subtract(ptOne, ptTwo));

            // Freebee +=.
            Point ptThree = new Point(90, 5);
            Console.WriteLine("ptThree = {0}", ptThree);
            Console.WriteLine("ptThree += ptTwo: {0}", ptThree += ptTwo);

            // Freebee -=.
            Point ptFour = new Point(0, 500);
            Console.WriteLine("ptFour = {0}", ptFour);
            Console.WriteLine("ptFour -= ptThree: {0}", ptFour -= ptThree);

            // Unary operators. 
            Point ptFive = new Point(10, 10);
            Console.WriteLine("ptFive = {0}", ptFive);
            Console.WriteLine("++ptFive = {0}", ++ptFive);
            Console.WriteLine("--ptFive = {0}", --ptFive);

            // Use various comparision operators. 
            Console.WriteLine("ptOne == ptTwo : {0}", ptOne == ptTwo);
            Console.WriteLine("ptOne != ptTwo : {0}", ptOne != ptTwo);
            Console.WriteLine("ptOne < ptTwo : {0}", ptOne < ptTwo);
            Console.WriteLine("ptOne > ptTwo : {0}", ptOne > ptTwo);

            Console.ReadLine();
        }
    }
}
