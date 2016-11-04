using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using SimpleRemotingAsm;

namespace TCPSimpleRemoteObjectServer
{
	class SimpleObjServer
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Server started! *****");
			Console.WriteLine("Hit enter to end");

			// Create a new TcpChannel
			TcpChannel c = new  TcpChannel(32469);
			ChannelServices.RegisterChannel(c);

			// Register a 'well-known' object.
			RemotingConfiguration.RegisterWellKnownServiceType(
				typeof(SimpleRemotingAsm.RemoteMessageObject),
				"RemoteMsgObj.rem",
				WellKnownObjectMode.SingleCall);

			Console.ReadLine();		
		}
	}
}
