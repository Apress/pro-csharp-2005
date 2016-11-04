#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CustomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Conversions *****\n");

            // Create a 5 * 10 Rectangle.
            Rectangle rect;
            rect.Width = 10;
            rect.Height = 5;
            Console.WriteLine("rect = {0}", rect);

            // Convert Rectangle to a new Square.
            Square sq = (Square)rect;
            Console.WriteLine("sq = {0}", sq);

            // Convert Rectangle to Square to call method.
            DrawSquare((Square)rect);

            // Converting System.Int32 to Square.
            Square sq2 = (Square)90;
            Console.WriteLine("sq2 = {0}", sq2);

            // Convert a Square to a System.Int32.
            int side = (int)sq2;
            Console.WriteLine("Side length of sq2 = {0}", side);

            // Implicit cast OK!
            Square s3;
            s3.Length = 83;
            Rectangle rect2 = s3;
            Console.WriteLine("rect2 = {0}", rect2);
            DrawSquare(s3);

            // Explicit cast syntax still OK!
            Square s4;
            s4.Length = 3;
            Rectangle rect3 = (Rectangle)s4;
            Console.WriteLine("rect3 = {0}", rect3);

            Console.ReadLine();
        }

        // This method requires a Square type.
        private static void DrawSquare(Square sq)
        {
            sq.Draw();
        }
    }
}
