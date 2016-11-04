#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace SimpleIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Indexers *****\n");

            // Assume the Garage type has an indexer method.
            Garage carLot = new Garage();

            // Add some cars to the garage using indexer.
            carLot[0] = new Car("FeeFee", 200);
            carLot[1] = new Car("Clunker", 90);
            carLot[2] = new Car("Zippy", 30);

            // Now obtain and display each item.
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Car number: {0}", i);
                Console.WriteLine("Name: {0}", carLot[i].PetName);
                Console.WriteLine("Max speed: {0}", carLot[i].CurrSpeed);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
