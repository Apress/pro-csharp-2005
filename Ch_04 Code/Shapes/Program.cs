#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Shapes
{
    class Program
    {
        // Create an array of various Shapes.
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");

            Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Mick"),
                  new Circle("Beth"), new Hexagon("Linda")};

            // Loop over the array and ask each object to draw itself.
            for (int i = 0; i < myShapes.Length; i++)
                myShapes[i].Draw();
          
            ThreeDCircle o = new ThreeDCircle();
            o.Draw();            // Calls ThreeDCircle.Draw()
            ((Circle)o).Draw();  // Calls Circle.Draw()

            Console.ReadLine();
        }
    }
}
