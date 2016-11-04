#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ValAndRef
{
    #region Value and reference types for the program
    // Change struct to class to see the different behaviors.
    struct MyPoint
    {
        public int x, y;
    }

    // This type will be used
    // within a struct.
    class ShapeInfo
    {
        public string infoString;
        public ShapeInfo(string info)
        { infoString = info; }
    }

    // This stuct has members that
    // are value types and ref types.
    struct MyRectangle
    {
        public ShapeInfo rectInfo;  // Ref type.
        public int top, left, bottom, right;

        public MyRectangle(string info)
        {
            rectInfo = new ShapeInfo(info);
            top = left = 10;
            bottom = right = 100;
        }
    }
    #endregion

    class ValRefClass
    {
        static void Main(string[] args)
        {
            #region Basic example
            // The 'new' keyword is optional when creating value types
            // using the default constructor, however you must assign 
            // all field data before use.
            Console.WriteLine("***** Value Types / Reference Types *****");
            
            // Still on the stack!
            MyPoint p = new MyPoint();

            Console.WriteLine("-> Creating p1");
            MyPoint p1 = new MyPoint();
            p1.x = 100;
            p1.y = 100;
            Console.WriteLine("-> Assigning p2 to p1");
            MyPoint p2 = p1;

            // Here is p1.
            Console.WriteLine("p1.x = {0}", p1.x);
            Console.WriteLine("p1.y = {0}", p1.y);

            // Here is p2.
            Console.WriteLine("p2.x = {0}", p2.x);
            Console.WriteLine("p2.y = {0}", p2.y);

            // Change p2.x. This will NOT change p1.x.
            Console.WriteLine("-> Changing p2.x to 900");
            p2.x = 900;

            // Print again.
            Console.WriteLine("-> Here are the X values again...");
            Console.WriteLine("p1.x = {0}", p1.x);
            Console.WriteLine("p2.x = {0}", p2.x);
            Console.WriteLine();
            #endregion 

            #region A bit more advanced
            // Create the first MyRectangle.
            Console.WriteLine("-> Creating r1");
            MyRectangle r1 = new MyRectangle("This is my first rect");

            // Now assign a new MyRectangle to r1.
            Console.WriteLine("-> Assigning r2 to r1");
            MyRectangle r2;
            r2 = r1;

            // Change values of r2.
            Console.WriteLine("-> Changing all values of r2");
            r2.rectInfo.infoString = "This is new info!";
            r2.bottom = 4444;

            // Print values
            Console.WriteLine("-> Values after change:");
            Console.WriteLine("-> r1.rectInfo.infoString: {0}", r1.rectInfo.infoString);
            Console.WriteLine("-> r2.rectInfo.infoString: {0}", r2.rectInfo.infoString);
            Console.WriteLine("-> r1.bottom: {0}", r1.bottom);
            Console.WriteLine("-> r2.bottom: {0}", r2.bottom);


            Console.ReadLine();
            #endregion
        }
    }
}
