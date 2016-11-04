using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using CarGeneralAsm;

namespace CarProviderServer
{
	class CarServer
	{
		static void Main(string[] args)
		{
			// Register a 'well-known' object using a *.config file.	
			Console.WriteLine("Car server started!  Hit enter to end");			
			RemotingConfiguration.Configure("CarProviderServer.exe.config");
			Console.ReadLine();		
		}
	}
}

