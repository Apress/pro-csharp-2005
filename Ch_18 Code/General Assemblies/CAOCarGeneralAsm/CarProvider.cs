using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Lifetime;

namespace CAOCarGeneralAsm
{
	// This type is an MBR object.
	// Clients can only access it via
	// a client-side proxy.
	public class CarProvider : MarshalByRefObject
	{
        private List<JamesBondCar> theJBCars = new List<JamesBondCar>();

		// Add some cars to the arraylist.
		public CarProvider()
		{
			Console.WriteLine("Car provider created");
			theJBCars.Add(new JamesBondCar("QMobile", 140, true, true));
			theJBCars.Add(new JamesBondCar("Flyer", 140, true, false));
			theJBCars.Add(new JamesBondCar("Swimmer", 140, false, true));
			theJBCars.Add(new JamesBondCar("BasicJBC", 140, false, false));
		}

		public CarProvider(JamesBondCar[] theCars)
		{
			Console.WriteLine("Car provider created with custom ctor");
			theJBCars.AddRange(theCars);
		}

		// Get all the JamesBondCars.
        public List<JamesBondCar> GetAllAutos()
		{
			return theJBCars;
		}

		// Get one JamesBondCar.
		public JamesBondCar GetJBCByIndex(int i)
		{
			return (JamesBondCar)theJBCars[i];
		}
	}
}
