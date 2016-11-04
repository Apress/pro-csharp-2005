#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

#endregion

namespace CustomGenericCollection
{
    public class CarCollection<T> : IEnumerable<T> where T : Car
    {
        private List<T> arCars = new List<T>();

        public T GetCar(int pos)
        { return arCars[pos]; }

        public void AddCar(T c)
        { arCars.Add(c); }

        public void ClearCars()
        { arCars.Clear(); }

        public int Count
        { get { return arCars.Count; } }

        public void PrintPetName(int pos)
        {
            Console.WriteLine(arCars[pos].PetName);
        }

        #region IEnumerable<T> / IEnumerable Members

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return arCars.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return arCars.GetEnumerator();
        }
        #endregion
    }
}
