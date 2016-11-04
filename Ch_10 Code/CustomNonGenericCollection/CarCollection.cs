#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

using System.Collections;

namespace CustomNonGenericCollection
{
    public class Car { }

    public class CarCollection : IEnumerable
    {
        private ArrayList arCars = new ArrayList();
        public CarCollection() { }

        // Cast for caller.
        public Car GetCar(int pos)
        { return (Car)arCars[pos]; }

        // Only insert Person types
        public void AddCar(Car c)
        { arCars.Add(c); }

        public void ClearCars()
        { arCars.Clear(); }

        public int Count
        { get { return arCars.Count; } }

        // Foreach enumeration support. 
        IEnumerator IEnumerable.GetEnumerator()
        { return arCars.GetEnumerator(); }
    }
}
