using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using SimpleRemotingAsm;

namespace SimpleRemoteObjectClientWithConfig
{
	class SimpleObjClient
	{
		static void Main(string[] args)
		{			
			Console.WriteLine("Client started!  Hit enter to end");
			RemotingConfiguration.Configure("SimpleRemoteObjectClientWithConfig.exe.config");
			RemoteMessageObject simple = new RemoteMessageObject();
			simple.DisplayMessage("Hello from the client!");
			Console.WriteLine("Server says: {0}", simple.ReturnMessage());
			Console.ReadLine();		
		}
	}
}
