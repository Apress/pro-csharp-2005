using System;
using System.Collections.Generic;
using System.Text;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Iterator Methods *****\n");
            Garage carLot = new Garage();

            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrSpeed);
            }

            Console.ReadLine();
        }
    }
}
