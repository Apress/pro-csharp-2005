#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CustomGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Custom Generic Collection *****\n");

//            // Confusing at best...
//            CarCollection<int> myInts = new CarCollection<int>();
//            myInts.AddCar(5);
//            myInts.AddCar(10);
//            myInts.AddCar(11);

            // Make a collection of Cars.
            CarCollection<Car> myCars = new CarCollection<Car>();
            myCars.AddCar(new Car("Rusty", 20));
            myCars.AddCar(new Car("Zippy", 90));
            myCars.AddCar(new SportsCar("Viper", 100));

            foreach (Car c in myCars)
            {
                Console.WriteLine("PetName: {0}, Speed: {1}",
                c.PetName, c.Speed);
            }

            Console.ReadLine();
        }
    }
}