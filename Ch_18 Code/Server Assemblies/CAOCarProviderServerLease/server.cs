using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using CAOCarGeneralAsmLease;

namespace CAOCarProviderServerLease
{
	class CarServer
	{
		static void Main(string[] args)
		{
			// Register a 'well-known' object using a *.config file.	
			RemotingConfiguration.Configure("CAOCarProviderServerLease.exe.config");
			Console.WriteLine("Car server started!  Hit enter to end");
			Console.ReadLine();		
		}
	}
}

