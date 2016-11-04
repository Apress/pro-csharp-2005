using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using CarGeneralAsm;
using System.Collections.Generic;

namespace CarProviderClient
{
	class CarClient
	{
		#region Helper f(x)
		private static void UseCar(JamesBondCar c)
		{
			Console.WriteLine("-> Name: {0}", c.PetName);
			Console.WriteLine("-> Max speed: {0}", c.MaxSpeed);
			Console.WriteLine("-> Seaworthy? : {0}", c.isSeaWorthy);
			Console.WriteLine("-> Flight worthy? : {0}", c.isFlightWorthy); 
			Console.WriteLine();
			c.TurnOnRadio(true);
		}
		#endregion 

		static void Main(string[] args)
		{			
			Console.WriteLine("Client started!  Hit enter to end");
			RemotingConfiguration.Configure("CarProviderClient.exe.config");
			
			// Make the car provider. 
			CarProvider cp = new CarProvider();

			// Get first JBC.
			JamesBondCar qCar = cp.GetJBCByIndex(0);

			// Get all JBCs.
			List<JamesBondCar> allJBCs = cp.GetAllAutos();

			// Use first car.
			UseCar(qCar);

			// Use all cars in ArrayList
			foreach(JamesBondCar j in allJBCs)
				UseCar(j);		

			Console.ReadLine();		
		}
	}
}

