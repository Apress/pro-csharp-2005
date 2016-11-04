#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace OverloadedOps
{
    public struct Point : IComparable
    {
        private int x, y;
        public Point(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }

        #region Overloaded Binary Operators
        // overloaded operator +.
        public static Point operator +(Point p1, Point p2)
        { return new Point(p1.x + p2.x, p1.y + p2.y); }

        // overloaded operator -.
        public static Point operator -(Point p1, Point p2)
        { return new Point(p1.x - p2.x, p1.y - p2.y); }

        // Now let's overload the == and != operators.
        public static bool operator ==(Point p1, Point p2)
        { return p1.Equals(p2); }

        public static bool operator !=(Point p1, Point p2)
        { return !p1.Equals(p2); }

        public static bool operator <(Point p1, Point p2)
        { return (p1.CompareTo(p2) < 0); }

        public static bool operator >(Point p1, Point p2)
        { return (p1.CompareTo(p2) > 0); }

        public static bool operator <=(Point p1, Point p2)
        { return (p1.CompareTo(p2) <= 0); }

        public static bool operator >=(Point p1, Point p2)
        { return (p1.CompareTo(p2) >= 0); }

        #endregion

        #region Overloaded Unary Operators
        public static Point operator ++(Point p1)
        { return new Point(p1.x + 1, p1.y + 1); }

        public static Point operator --(Point p1)
        { return new Point(p1.x - 1, p1.y - 1); }

        #endregion

        #region System.Object overrides
        public override bool Equals(object o)
        {
            if (o is Point)
            {
                if (((Point)o).x == this.x &&
                    ((Point)o).y == this.y)
                    return true;
            }
            return false;
        }

        public override int GetHashCode()
        { return this.ToString().GetHashCode(); }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", this.x, this.y);
        } 
        #endregion

        #region IComparable Members
        public int CompareTo(object obj)
        {
            if (obj is Point)
            {

                Point p = (Point)obj;
                if (this.x > p.x && this.y > p.y)
                    return 1;
                if (this.x < p.x && this.y < p.y)
                    return -1;
                else
                    return 0;
            }
            else
                throw new ArgumentException();
        }
        #endregion

        #region 'Normal' Add() and Subtract() methods
        // Operator + via Add()
        public static Point Add(Point p1, Point p2)
        { return p1 + p2; }

        // Operator - via Subtract()
        public static Point Subtract(Point p1, Point p2)
        { return p1 - p2; }
        
#endregion
    }
}
