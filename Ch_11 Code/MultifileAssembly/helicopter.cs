using System;

// This type will be in the 
// primary module of the multifile
// assembly, therefore this assembly
// will contain the assembly manifest.
namespace AirVehicles
{
	public class Helicopter
	{
		public void TakeOff()
		{
			Console.WriteLine("Helicopter taking off!");
		}
	}
}
