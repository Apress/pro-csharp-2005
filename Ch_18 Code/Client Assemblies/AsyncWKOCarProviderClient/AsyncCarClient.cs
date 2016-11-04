using System;
using System.Collections.Generic;
using CarGeneralAsm;
using System.Runtime.Remoting;

namespace AsyncWKOCarProviderClient
{
	class Program
	{
		// The delegate for the GetAllAutos() method.
		internal delegate List<JamesBondCar> GetAllAutosDelegate();

		static void Main(string[] args)
		{
			Console.WriteLine("Client started!  Hit enter to end");
			RemotingConfiguration.Configure
				("AsyncWKOCarProviderClient.exe.config");

			// Make the car provider. 
			CarProvider cp = new CarProvider();

			// Make the delegate.
			GetAllAutosDelegate getCarsDel = 
				new GetAllAutosDelegate(cp.GetAllAutos);

			// Call GetAllAutos() asynchronously.
			IAsyncResult ar = getCarsDel.BeginInvoke(null, null);

			// Simulate client side activity.
			while(!ar.IsCompleted)
			{
				Console.WriteLine("Client working...");
			}

			// All done!  Get return value from delegate. 
			List<JamesBondCar> allJBCs = getCarsDel.EndInvoke(ar);

			// Use all cars in ArrayList.	
			foreach(JamesBondCar j in allJBCs)
				UseCar(j);
			Console.ReadLine();
		}

		public static void UseCar(JamesBondCar j)
		{
			Console.WriteLine("Can car fly? {0}", j.isFlightWorthy);
			Console.WriteLine("Can car swim? {0}", j.isSeaWorthy);
		}
	}
}
