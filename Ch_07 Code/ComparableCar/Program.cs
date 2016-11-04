#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with IComparable *****\n");
            // Make an array of Car types.
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Mary", 40, 234);
            myAutos[2] = new Car("Viper", 40, 34);
            myAutos[3] = new Car("Mel", 40, 4);
            myAutos[4] = new Car("Chucky", 40, 5);

            // Dump current array.
            Console.WriteLine("Here is the unordered set of cars:");
            foreach (Car c in myAutos)
                Console.WriteLine("{0} {1}", c.ID, c.PetName);

            // Now, sort them using IComparable!
            Array.Sort(myAutos);

            // Dump sorted array.
            Console.WriteLine("\nHere is the ordered set of cars:");
            foreach (Car c in myAutos)
                Console.WriteLine("{0} {1}", c.ID, c.PetName);

            // Now sort by pet name.
            Array.Sort(myAutos, Car.SortByPetName);

            // Dump sorted array.
            Console.WriteLine("\nOrdering by pet name:");
            foreach (Car c in myAutos)
                Console.WriteLine("{0} {1}", c.ID, c.PetName);

            Console.ReadLine();
        }
    }
}
