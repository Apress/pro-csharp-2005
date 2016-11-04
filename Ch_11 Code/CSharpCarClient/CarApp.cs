using System;

// Make use of the CarLib types.
using CarLibrary;

namespace CSharpCarClient
{
	public class CarClient
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** C# CarLib Client *****");
			// Make a sports car.
			SportsCar viper = new SportsCar("Viper", 240, 40);
			viper.TurboBoost();

            // Make a minivan.
			MiniVan mv = new MiniVan();
			mv.TurboBoost();

            Console.ReadLine();
        }
	}
}
