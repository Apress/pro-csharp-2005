using System;

namespace SimpleRemotingAsm
{
    // This is a type that will be 
    // marshaled by reference (MBR) if accessed remotely.
	public class RemoteMessageObject: MarshalByRefObject
	{
        public RemoteMessageObject()
        {
            Console.WriteLine("Constructing RemoteMessageObject!");
        }

		// This method displays an input string 
		// from the caller.
		public void DisplayMessage(string msg)
		{
			Console.WriteLine("Message is: {0}", msg);
		}

		// This method returns a value to the
		// caller.
		public string ReturnMessage()
		{
			return "Hello from the server!";
		}
	}
}
