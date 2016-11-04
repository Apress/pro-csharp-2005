using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using SimpleRemotingAsm;

namespace SimpleRemoteObjectClient
{
	class SimpleObjClient
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** SimpleRemoteObjectClient started! *****");
			Console.WriteLine("Hit enter to end");
			// Create a new HttpChannel
			HttpChannel c = new HttpChannel();
			ChannelServices.RegisterChannel(c);

			// Get a proxy to remote object.
			object remoteObj = Activator.GetObject(
				typeof(SimpleRemotingAsm.RemoteMessageObject), 
				"http://localhost:32469/RemoteMsgObj.soap");
 
			RemoteMessageObject simple = (RemoteMessageObject)remoteObj;
			simple.DisplayMessage("Hello from the client!");
			Console.WriteLine("Server says: {0}", simple.ReturnMessage());

            #region Fun with channel services
            // List all registered channels. 
            IChannel[] channelObjs = ChannelServices.RegisteredChannels;
            foreach (IChannel i in channelObjs)
            {
                Console.WriteLine("Channel name: {0}", i.ChannelName);
                Console.WriteLine("Channel Priority: {0}", i.ChannelPriority);
            }
            #endregion
			
			Console.ReadLine();	
		}
	}
}
