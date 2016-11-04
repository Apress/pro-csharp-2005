using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using SimpleRemotingAsm;
 
namespace SimpleRemoteObjectServer
{
	class SimpleObjServer
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** SimpleRemoteObjectServer started! *****");
			Console.WriteLine("Hit enter to end.");
			RemotingConfiguration.ApplicationName = "First server app!";

			// Create a new HttpChannel
			HttpChannel c = new HttpChannel(32469);
			ChannelServices.RegisterChannel(c);

			// Register a 'well-known' object.
			RemotingConfiguration.RegisterWellKnownServiceType(
				typeof(SimpleRemotingAsm.RemoteMessageObject),
				"RemoteMsgObj.soap",
				WellKnownObjectMode.SingleCall);

			#region Fun with registration services.
			Console.WriteLine("App Name: {0}",
				RemotingConfiguration.ApplicationName);
			WellKnownServiceTypeEntry[] WKOs =
				RemotingConfiguration.GetRegisteredWellKnownServiceTypes();
			foreach(WellKnownServiceTypeEntry wko in WKOs)
			{
				Console.WriteLine("Asm name containing WKO: {0}", wko.AssemblyName);
				Console.WriteLine("URL to WKO: {0}", wko.ObjectUri);
				Console.WriteLine("Type of WKO: {0}", wko.ObjectType);
				Console.WriteLine("Mode of WKO: {0}", wko.Mode);
			}
			#endregion			
            
            Console.ReadLine();		
		}
	}
}
