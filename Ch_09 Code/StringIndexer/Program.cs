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
            Garage carLot = new Garage();

            // Add named cars to garage.
            carLot["FeeFee"] = new Car("FeeFee", 200);
            carLot["Clunker"] = new Car("Clunker", 90);
            carLot["Zippy"] = new Car("Zippy", 30);

            // Now get Zippy.
            Car zippy = carLot["Zippy"];
            Console.WriteLine("{0} is going {1} MPH",
                zippy.PetName, zippy.CurrSpeed);
            Console.ReadLine();
        }
    }
}
