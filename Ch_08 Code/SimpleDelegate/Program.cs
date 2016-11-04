#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace SimpleDelegate
{
    // Just so you can see the CIL code...
    public delegate string MyDelegate(bool a, bool b, bool c);
    public delegate string MyOtherDelegate(out bool a, ref bool b, int c);

    // This delegate can point to any method
    // taking two integers and returning an 
    // integer.
    public delegate int BinaryOp(int x, int y);

    #region SimpleMath class
    public class SimpleMath
    {
        public int Add(int x, int y)
        { return x + y; }
        public int Subtract(int x, int y)
        { return x - y; }
        public static int SquareNumber(int a)
        { return a * a; }
    }
    
    #endregion
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Delegate Example *****\n");
            // Create a BinaryOp object that 
            // 'points to' SimpleMath.Add()
            SimpleMath m = new SimpleMath();
            BinaryOp b = new BinaryOp(m.Add);
            
            // Show information about this object.
            DisplayDelegateInfo(b);

            // Invoke Add() method using delegate. 
            Console.WriteLine("\n10 + 10 is {0}", b(10, 10));
            Console.ReadLine();
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            // Print the names of each member in the 
            // delegates invocation list.
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Target Name: {0}", d.Target);
            }
        }
    }
}
