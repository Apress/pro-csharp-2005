#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ObjectMethods
{
    // Just for testing purposes.
    class Car { }

    #region Person type
    // Remember! All classes implicitly derive from System.Object.
    class Person
    {
        public Person(string fname, string lname, string s, byte a)
        {
            firstName = fname;
            lastName = lname;
            SSN = s;
            age = a;
        }

        public Person() { }
        // The state of a person.
        public string firstName;
        public string lastName;
        public string SSN;
        public byte age;

        #region Object overrides
        // Overriding System.Object.ToString().
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("[FirstName={0};", this.firstName);
            sb.AppendFormat(" LastName={0};", this.lastName);
            sb.AppendFormat(" SSN={0};", this.SSN);
            sb.AppendFormat(" Age={0}]", this.age);
            return sb.ToString();
        }

        public override bool Equals(object o)
        {
//            // Make sure the caller sent a valid
//            // Person object before proceeding.
//            if (o != null && o is Person)
//            {
//                // Now see if the incoming Person
//                // has the exact same information as
//                // the current person (this). 
//                Person temp = (Person)o;
//                if (temp.firstName == this.firstName &&
//                   temp.lastName == this.lastName &&
//                   temp.SSN == this.SSN &&
//                   temp.age == this.age)
//                    return true;
//            }
//            return false;   // Not the same!
			if (o != null && o is Person)
			{
				Person temp = (Person)o;
				if (this.ToString() == o.ToString())
					return true;
				else
					return false;
			}
			return false;
		}

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        #endregion
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Working with Object *****\n");
            Person fred = new Person("Fred", "Clark",
                "111-11-1111", 20);
            Console.WriteLine("-> fred.ToString: {0}", fred.ToString());
            Console.WriteLine("-> fred.GetHashCode: {0}", fred.GetHashCode());
            Console.WriteLine("-> fred's base class: {0}", fred.GetType().BaseType);

            // Make some other references to fred.
            Person p2 = fred;
            object o = p2;

            // Are all 3 instances pointing to the same object in memory?
            if (o.Equals(fred) && p2.Equals(o))
                Console.WriteLine("fred, p2 and o are referencing the same object!");

            // Verify a Person is not a Car or null object. 
            Car c = new Car();
            Console.WriteLine("fred.Equals(c): {0}", fred.Equals(c));
            Console.WriteLine("fred.Equals(null): {0}", fred.Equals(null));

            // NOTE:  We want these to be identical for testing purposes.
            Person p3 = new Person("Fred", "Jones", "222-22-2222", 98);
            Person p4 = new Person("Fred", "Jones", "222-22-2222", 98);
            Console.WriteLine("-> Hash code of p3 = {0}", p3.GetHashCode());
            Console.WriteLine("-> Hash code of p4 = {0}", p4.GetHashCode());
            Console.WriteLine("-> String of p3 = {0}", p3.ToString());
            Console.WriteLine("-> String of p4 = {0}", p4.ToString());

            // Equals() now uses value semantics.
            // As well, given that each object has the same SSN, they should have
            // the same hash-code (given the work performed by System.String).
            if (p3.Equals(p4))
                Console.WriteLine("-> P3 and p4 have same state!");
            else
                Console.WriteLine("-> P3 and p4 have different state!");

            // Change age of p4.    
            Console.WriteLine("\n-> Changing the age of p4\n");
            p4.age = 2;
            // Test again.
            Console.WriteLine("-> String of p3 = {0}", p3.ToString());
            Console.WriteLine("-> String of p4 = {0}", p4.ToString());
            Console.WriteLine("-> Hash code of p3 = {0}", p3.GetHashCode());
            Console.WriteLine("-> Hash code of p4 = {0}", p4.GetHashCode());
            if (p3.Equals(p4))
                Console.WriteLine("-> P3 and p4 have same state!");
            else
                Console.WriteLine("-> P3 and p4 have different state!");

            // Do p3 and p4 have the same state? TRUE!
            Console.WriteLine("Do P3 and p4 have same state: {0} ", object.Equals(p3, p4));

            // Are they the same object in memory? FALSE!
            Console.WriteLine("Are P3 and p4 are pointing to same object: {0} ",
                 object.ReferenceEquals(p3, p4));

            Console.ReadLine();
        }
    }
}
