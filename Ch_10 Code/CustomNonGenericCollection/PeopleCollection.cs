#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

using System.Collections;

namespace CustomNonGenericCollection
{
    public class PeopleCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        public PeopleCollection() { }

        // Cast for caller.
        public Person GetPerson(int pos)
        { return (Person)arPeople[pos]; }

        // Only insert Person types
        public void AddPerson(Person p)
        { arPeople.Add(p); }

        public void ClearPeople()
        { arPeople.Clear(); }

        public int Count
        { get { return arPeople.Count; } }

        // Foreach enumeration support. 
        IEnumerator IEnumerable.GetEnumerator()
        { return arPeople.GetEnumerator(); }
    }
}
