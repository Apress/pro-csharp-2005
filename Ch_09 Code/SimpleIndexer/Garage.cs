#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

#endregion

namespace SimpleIndexer
{
    // Garage is a container of Car objects.
    public class Garage : IEnumerable
    {
        private ArrayList carArray = new ArrayList();

        // Create some Car objects upon startup.
        public Garage()
        {
            carArray.Add(new Car("Rusty", 30));
            carArray.Add(new Car("Clunker", 55));
            carArray.Add(new Car("Zippy", 30));
            carArray.Add(new Car("Fred", 30));
        }

        // The indexer returns a Car based on a numerical index.
        public Car this[int pos]
        {
            // Note ArrayList has an indexer as well!
            get { return (Car)carArray[pos]; }
            set { carArray.Add(value); }
        }

        // Containment/delegation in action once again.
        public int Count { get { return carArray.Count; } }

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }

        #endregion
    }
}
