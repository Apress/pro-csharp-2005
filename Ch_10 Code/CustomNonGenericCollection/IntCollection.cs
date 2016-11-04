#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

using System.Collections;

namespace CustomNonGenericCollection
{
    public class IntCollection : IEnumerable
    {
        private ArrayList arInts = new ArrayList();
        public IntCollection() { }

        // Unbox for caller.
        public int GetInt(int pos)
        { return (int)arInts[pos]; }

        // Boxing operation!
        public void AddInt(int i)
        { arInts.Add(i); }

        public void ClearInts()
        { arInts.Clear(); }

        public int Count
        { get { return arInts.Count; } }

        IEnumerator IEnumerable.GetEnumerator()
        { return arInts.GetEnumerator(); }
    }
}
