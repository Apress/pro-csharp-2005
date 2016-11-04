using System;
using System.Drawing;

namespace UtilTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Working with Drawing-centric util types *****\n");

            #region Work with Point type
            Console.WriteLine("***** Exercise Point type *****");
            // Create and offset a point.
            Point pt = new Point(100, 72);
            Console.WriteLine(pt);
            pt.Offset(20, 20);
            Console.WriteLine(pt);

            // Overloaded Point operators.
            Point pt2 = pt;
            if (pt == pt2)
                Console.WriteLine("Points are the same");
            else
                Console.WriteLine("Different points");

            // Change pt2's X value.
            pt2.X = 4000;

            // Now show each X:
            Console.WriteLine("First point: {0}", pt);
            Console.WriteLine("Second point: {0}", pt2); 
            #endregion

            #region Work with Rectangle type
            Console.WriteLine("\n***** Point in Rect? *****");
            Rectangle r1 = new Rectangle(0, 0, 100, 100);
            Point pt3 = new Point(101, 101);

            if (r1.Contains(pt3))
                Console.WriteLine("Point is within the rect!");
            else
                Console.WriteLine("Point is not within the rect!");

            // Now place point in rectangle's area.
            pt3.X = 50;
            pt3.Y = 30;

            if (r1.Contains(pt3))
                Console.WriteLine("Point is within the rect!");
            else
                Console.WriteLine("Point is not within the rect!"); 
            #endregion

            Console.ReadLine();
		}
	}
}
