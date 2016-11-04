using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using SimpleRemotingAsm;

namespace TCPSimpleRemoteObjectClient
{
	class SimpleObjClient
	{
		static void Main(string[] args)
		{
			// Create a new TcpChannel
			TcpChannel c = new TcpChannel();
			ChannelServices.RegisterChannel(c);

			// Get a proxy to remote object.
			object remoteObj = Activator.GetObject(
				typeof(SimpleRemotingAsm.RemoteMessageObject), 
				"tcp://localhost:32469/RemoteMsgObj.rem");
 
			RemoteMessageObject simple = (RemoteMessageObject)remoteObj;
			simple.DisplayMessage("Hello from the client!");
			Console.WriteLine("Server says: {0}", simple.ReturnMessage());
			Console.WriteLine("Client started!  Hit enter to end");
			Console.ReadLine();		
		}
	}
}
