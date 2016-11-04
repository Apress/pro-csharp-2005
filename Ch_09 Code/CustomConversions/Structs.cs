#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CustomConversions
{
    #region Rectangle
    public struct Rectangle
    {
        // Public for ease of use, 
        // however feel free to encapsulate with properties.  
        public int Width, Height;

        public void Draw()
        { Console.WriteLine("Drawing a rect."); }

        public override string ToString()
        {
            return string.Format("[Width = {0}; Height = {1}]",
                Width, Height);
        }

        public static implicit operator Rectangle(Square s)
        {
            Rectangle r;
            r.Height = s.Length;

            // Assume the length of the new Rectangle with 
            // be (Length x 2)
            r.Width = s.Length * 2;
            return r;
        }
    }
    #endregion

    #region Square
    public struct Square
    {
        public int Length;

        public void Draw()
        { Console.WriteLine("Drawing a square."); }

        public override string ToString()
        { return string.Format("[Length = {0}]", Length); }

        public static explicit operator Square(Rectangle r)
        {
            Square s;
            s.Length = r.Width;
            return s;
        }

        public static implicit operator Square(int sideLength)
        {
            Square newSq;
            newSq.Length = sideLength;
            return newSq;
        }

        public static explicit operator int(Square s)
        { return s.Length; }
    } 
    #endregion
}
