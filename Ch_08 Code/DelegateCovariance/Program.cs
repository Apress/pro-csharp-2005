#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace DelegateCovariance
{
	#region Simple Car types
	// A very simple class heirarchy. 
	class Car
	{
		public override string ToString()
		{
			return "A stateless car...";
		}
	}
	class SportsCar : Car
	{
		public override string ToString()
		{
			return "A stateless sports car...";
		}
	} 
	#endregion

	class Program
	{
		// Define a deletate which may return a Car
		// or SportsCar
		public delegate Car ObtainVehicalDelegate();

		#region Delegate targets
		public static Car GetBasicCar()
		{ return new Car(); }

		public static SportsCar GetSportsCar()
		{ return new SportsCar(); }
		#endregion 

		static void Main(string[] args)
		{
			Console.WriteLine("***** Delegate Covariance *****\n");
			ObtainVehicalDelegate targetA = new ObtainVehicalDelegate(GetBasicCar);
			Car c = targetA();
			Console.WriteLine(c);

			// Covariance allows this target assignment.
			ObtainVehicalDelegate targetB = new ObtainVehicalDelegate(GetSportsCar);
			SportsCar sc = (SportsCar)targetB();
			Console.WriteLine(sc);
			Console.ReadLine();
		}
	}
}


