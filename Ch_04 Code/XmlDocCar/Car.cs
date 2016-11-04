#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace XmlDocCar
{
    /// <summary>
    ///  This is a simple Car that illustrates
    ///  working with XML style documentation.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Do you have a sunroof?
        /// </summary>
        private bool hasSunroof = false;

        /// <summary>
        /// The ctor lets you set the sunroofedness.
        /// </summary>
        /// <param name="hasSunroof"></param>
        public Car(bool hasSunroof)
        {
            this.hasSunroof = hasSunroof;
        }

        /// <summary>
        /// This method allows you to open your sunroof.
        /// </summary>
        /// <param name="state"> </param>
        public void OpenSunroof(bool state)
        {
            if (state == true && hasSunroof == true)
                Console.WriteLine("Put sunscreen on that bald head!");
            else
                Console.WriteLine("Sorry...you don’t have a sunroof.");
        }
    }
}
