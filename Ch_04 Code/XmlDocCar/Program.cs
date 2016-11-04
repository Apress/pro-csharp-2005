#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace XmlDocCar
{
    class Program
    {
        /// <summary>
        /// Entry point to application.
        /// </summary>
        public static void Main()
        {
            Car c = new Car(true);
            c.OpenSunroof(true);
        }
    }
}
