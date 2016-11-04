#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

#endregion

namespace Boxing
{
    struct MyPoint
    {
        public int x, y;
    }

    class Program
    {
        #region Helper functions
        // Helper f(x) to illustrate automatic boxing.
        public static void UseThisObject(object o)
        {
            // Investigate the incoming parameter.
            Console.WriteLine("Type of param: {0}", o.GetType());
            Console.WriteLine("Value of o is: {0}", o);
        }

        public static void BoxAndUnboxInts()
        {
            // Box ints into ArrayList.
            ArrayList myInts = new ArrayList();
            myInts.Add(88);
            myInts.Add(3);
            myInts.Add(9764);

            // Unbox first item from ArrayList.
            int firstItem = (int)myInts[0];
            Console.WriteLine("First item is {0}", firstItem);
        }

        public static void UseBoxedMyPoint(object o)
        {
            if (o is MyPoint)
            {
                MyPoint p = (MyPoint)o;
                Console.WriteLine("{0}, {1}", p.x, p.y);
            }
            else
                Console.WriteLine("You did not send a MyPoint.");
        } 
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("***** Boxing / Unboxing *****\n");

            // Create an int (value type).
            int myInt = 99;

            // Because myInt is passed into a 
            // method prototyped to take an object,
            // myInt is 'boxed' automatically.
            UseThisObject(myInt);
            BoxAndUnboxInts();

            MyPoint p;
            p.x = 10;
            p.y = 20;
            UseBoxedMyPoint(p);
            UseBoxedMyPoint(1);

            Console.ReadLine();
        }
    }
}
