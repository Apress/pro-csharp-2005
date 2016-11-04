#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

#endregion

namespace CustomEnumerator
{
    // Garage is a container of Car objects.
    public class Garage : IEnumerable
    {
        private Car[] carArray;

        // Create some Car objects upon startup.
        public Garage()
        {
            carArray = new Car[4];
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }

        #endregion
    }
}
