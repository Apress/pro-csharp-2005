#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CloneablePoint
{
    // This class describes a point.
    public class PointDescription
    {
        // Exposed publicly for simplicity. 
        public string petName;
        public Guid pointID;

        public PointDescription()
        {
            this.petName = "No-name";
            pointID = Guid.NewGuid();
        }
    }
}
