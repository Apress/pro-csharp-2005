#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CustomNonGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Custom Person Collection *****\n");
            PeopleCollection myPeople = new PeopleCollection();
            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));

            // Compile time error!
            // myPeople.AddPerson(new Car());

            foreach (Person p in myPeople)
                Console.WriteLine(p);
            Console.ReadLine();

        }
    }
}
