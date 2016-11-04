using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Lifetime;

namespace CAOCarGeneralAsmLease
{
	#region The lease info type
	internal class LeaseInfo
	{
		public static void LeaseStats(ILease itfLease)
		{
			Console.WriteLine("***** Lease Stats *****");
			Console.WriteLine("Lease state: {0}", itfLease.CurrentState);
			
			Console.WriteLine("Initial lease time: {0}:{1}", 
				itfLease.InitialLeaseTime.Minutes, 
				itfLease.InitialLeaseTime.Seconds);

			Console.WriteLine("Current lease time: {0}:{1}", 
				itfLease.CurrentLeaseTime.Minutes, 
				itfLease.CurrentLeaseTime.Seconds);

			Console.WriteLine("Renew on call time: {0}:{1}", 
				itfLease.RenewOnCallTime.Minutes, 
				itfLease.RenewOnCallTime.Seconds);
			Console.WriteLine();
		}
	}
	#endregion 

	// This type is an MBR object.
	// Clients can only access it via
	// a client-side proxy.
	public class CarProvider : MarshalByRefObject
	{
//		public override object InitializeLifetimeService()
//		{
//			// Obtain the current lease info.
//			ILease itfLeaseInfo = 
//				(ILease) base.InitializeLifetimeService();
//			
//			// adjust settings.
//			itfLeaseInfo.InitialLeaseTime = TimeSpan.FromMinutes(50);
//			itfLeaseInfo.RenewOnCallTime = TimeSpan.FromMinutes(10);
//
//			return itfLeaseInfo;
//		}

        private List<JamesBondCar> theJBCars = new List<JamesBondCar>();

		// Add some cars to the arraylist.
		public CarProvider()
		{
			Console.WriteLine("Car provider created");
			theJBCars.Add(new JamesBondCar("QMobile", 140, true, true));
			theJBCars.Add(new JamesBondCar("Flyer", 140, true, false));
			theJBCars.Add(new JamesBondCar("Swimmer", 140, false, true));
			theJBCars.Add(new JamesBondCar("BasicJBC", 140, false, false));
		}

		public CarProvider(JamesBondCar[] theCars)
		{
			Console.WriteLine("Car provider created with custom ctor");
			theJBCars.AddRange(theCars);
		}

		// Get all the JamesBondCars.
        public List<JamesBondCar> GetAllAutos()
		{
			LeaseInfo.LeaseStats((ILease)this.GetLifetimeService());
			return theJBCars;
		}

		// Get one JamesBondCar.
		public JamesBondCar GetJBCByIndex(int i)
		{
			LeaseInfo.LeaseStats((ILease)this.GetLifetimeService());
			return (JamesBondCar)theJBCars[i];
		}

		public void DoLengthyOperation()
		{
			ILease itfLeaseInfo = (ILease)this.GetLifetimeService();
			if(itfLeaseInfo.CurrentLeaseTime.TotalMinutes < 1.0)
				itfLeaseInfo.Renew(TimeSpan.FromMinutes(10));
			
			// Do long running task...
            System.Threading.Thread.Sleep(10000);
		}
	}
}
