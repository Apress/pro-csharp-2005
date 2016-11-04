#region Using directives

using System;
using System.Collections.Generic;

#endregion

namespace CustomGenericCollection
{
    public class SportsCar : Car
    {
        public SportsCar(string p, int s)
          : base(p, s) { }
        // Assume additional SportsCar methods.
    }

    public class MiniVan : Car
    {
        public MiniVan(string p, int s)
          : base(p, s) { }
        // Assume additional MiniVan methods.
    }

}
