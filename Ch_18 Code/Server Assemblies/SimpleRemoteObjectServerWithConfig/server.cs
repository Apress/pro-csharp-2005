using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using SimpleRemotingAsm;

namespace SimpleRemoteObjectServerWithConfig
{
	class SimpleObjServer
	{
		static void Main(string[] args)
		{
			// Register a 'well-known' object using a *.config file.	
			RemotingConfiguration.Configure("SimpleRemoteObjectServerWithConfig.exe.config");
			Console.WriteLine("Server started!  Hit enter to end");
			Console.ReadLine();		
		}
	}
}