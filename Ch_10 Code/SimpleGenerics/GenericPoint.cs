#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace SimpleGenerics
{
    // A generic Point structure. 
    public struct Point<T>
    {
        // Generic state date.
        private T xPos;
        private T yPos;

        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }

        // Generic properties. 
        public T X
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public T Y
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", xPos, yPos);
        }

        // The 'default' keyword is overloaded in C# 2.0.
        // when used with generics, it represents the default
        // value of a generic parameter.
        public void ResetPoint()
        {
            xPos = default(T);
            yPos = default(T);
        }
	}
}
