#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

#endregion

using System.Collections.Specialized;

namespace SimpleIndexer
{
    // Garage is a container of Car objects.
    public class Garage : IEnumerable
    {
        private ListDictionary carDictionary = new ListDictionary();   

        // The indexer returns a Car based on a numerical index.
        // The new indexer.
        public Car this[string name]
        {
            get { return (Car)carDictionary[name]; }
            set { carDictionary[name] = value; }
        }

        // Containment/delegation in action once again.
        public int Length { get { return carDictionary.Count; } }

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return carDictionary.GetEnumerator();
        }

        #endregion
    }
}
