using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using CAOCarGeneralAsmLease;
using System.Collections.Generic;
using System.Runtime.Remoting.Lifetime;

namespace CAOCarProviderClientLease
{
	class CarClient
	{
		#region Helper f(x)
		private static void UseCar(JamesBondCar c)
		{
			Console.WriteLine("-> Name: {0}", c.PetName);
			Console.WriteLine("-> Max speed: {0}", c.MaxSpeed);
			Console.WriteLine("-> Sea worthy? : {0}", c.isSeaWorthy);
			Console.WriteLine("-> Flight worthy? : {0}", c.isFlightWorthy); 
			Console.WriteLine();
			c.TurnOnRadio(true);
		}
		#endregion 

		static void Main(string[] args)
		{
			// Use *.config file...
			RemotingConfiguration.Configure("CAOCarProviderClientLease.exe.config");
			
			// ... or use hard coded values.
			//RemotingConfiguration.RegisterActivatedClientType(typeof(CAOCarGeneralAsmLease.CarProvider),
			//	"http://localhost:032469");

			// Make the car provider. 
			JamesBondCar[] cars = 
				{
					new JamesBondCar("One", 100, false, false),
					new JamesBondCar("Two", 100, false, false),
					new JamesBondCar("Three", 100, false, false)
				};

			// Now trigger the custom ctor.
			CarProvider cp = new CarProvider(cars);

			// Adjust the lease of this type!
			ILease itfLeaseInfo = (ILease)RemotingServices.GetLifetimeService(cp);
			if(itfLeaseInfo.CurrentLeaseTime.TotalMinutes < 10.0)
				itfLeaseInfo.Renew(TimeSpan.FromMinutes(1000));

			// Get first JBC.
            JamesBondCar qCar = cp.GetJBCByIndex(0);

            // Get all JBCs.
            List<JamesBondCar> allJBCs = cp.GetAllAutos();

			// Use first car.
			UseCar(qCar);

			// Use all cars in ArrayList
			foreach(JamesBondCar j in allJBCs)
				UseCar(j);		

			Console.WriteLine("Client started!  Hit enter to end");
			Console.ReadLine();		
		}
	}
}

