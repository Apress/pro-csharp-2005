#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CloneablePoint
{
    public class Point : ICloneable
    {
        public int x, y;
        public PointDescription desc = new PointDescription();

        public Point() { }
        public Point(int x, int y)
        {
            this.x = x; this.y = y;
        }
        public Point(int x, int y, string petname)
        {
            this.x = x;
            this.y = y;
            desc.petName = petname;
        }

        public object Clone()
        {
            Point newPoint = (Point)this.MemberwiseClone();
            PointDescription currentDesc = new PointDescription();
            currentDesc.petName = this.desc.petName;
            newPoint.desc = currentDesc;
            return newPoint;
        }

        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Name = {2};\nID = {3}\n",
                x, y, desc.petName, desc.pointID);
        }
    }
}
