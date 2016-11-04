#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CustomNonGenericCollection
{
    public class Person
    {
        // Made public for simplicitly.
        public int currAge;
        public string fName, lName;

        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            currAge = age;
            fName = firstName;
            lName = lastName;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} is {2} years old",
                lName, fName, currAge);
        }
    }
}
