#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ReadOnlyFields
{
    class Tire
    {
        public static readonly Tire GoodStone = new Tire(90);
        public static readonly Tire FireYear = new Tire(100);

        public int manufactureID;

        public Tire(){}
        public Tire(int ID)
        { manufactureID = ID; }
    }

    class Employee
    {
        public readonly string SSN;

        public Employee(string empSSN)
        {
            SSN = empSSN;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Read-only Data *****");
            Tire myTire = Tire.FireYear;
            Console.WriteLine("ID of my tire is: {0}", myTire.manufactureID);

            Employee e = new Employee("111-22-1111");
            // e.SSN = "222-22-2222"; // error!

            Console.ReadLine();
        }
    }
}
