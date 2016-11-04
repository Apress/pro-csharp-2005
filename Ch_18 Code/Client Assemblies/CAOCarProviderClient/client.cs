using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using CAOCarGeneralAsm;
using System.Collections.Generic;

namespace CAOCarProviderClient
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
            // Use hard-coded values.
            RemotingConfiguration.RegisterActivatedClientType(
                 typeof(CAOCarGeneralAsm.CarProvider),
                 "tcp://localhost:32469");

            // Use *.config file.
			//RemotingConfiguration.Configure("CAOCarProviderClient.exe.config");
			
			// Make the car provider. 
			JamesBondCar[] cars = 
				{
					new JamesBondCar("Viper", 100, true, false),
					new JamesBondCar("Shaken", 100, false, true),
					new JamesBondCar("Stirred", 100, true, true)
				};

			// Now trigger the custom ctor.
			CarProvider cp = new CarProvider(cars);

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

