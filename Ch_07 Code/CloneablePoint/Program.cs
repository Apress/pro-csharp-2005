#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Changing values of Point via assignment op *****");
            // Two references to same object!
            Point p1 = new Point(50, 50);
            Point p2 = p1;
            p2.x = 0;

            // Print each object.
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.WriteLine("\n***** Fun with ICloanable *****");
            Console.WriteLine("Cloned p3 and stored new Point in p4");
            Point p3 = new Point(100, 100, "Jane");
            Point p4 = (Point)p3.Clone();

            Console.WriteLine("Before modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
            p4.desc.petName = "Mr. X";
            p4.x = 9;

            Console.WriteLine("Changed p4.desc.petName and p4.x");
            Console.WriteLine("After modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);

            Console.ReadLine();
        }
    }
}
