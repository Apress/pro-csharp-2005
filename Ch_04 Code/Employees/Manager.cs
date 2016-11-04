using System;

namespace Employees
{
	public class Manager : Employee
	{
		private ulong numberOfOptions;
	    
		#region Constructors
		public Manager(){}

		public Manager(string FullName, int empAge, int empID, 
			float currPay, string ssn, ulong numbOfOpts) 
				: base(FullName, empAge, empID, currPay, ssn)
		{
			// This point of data belongs with us!
			numberOfOptions = numbOfOpts;		
		}
		#endregion 

		#region Methods and properties
		public override void GiveBonus(float amount)
		{
			// Increase salary.
			base.GiveBonus(amount);

			// And give some new stock options...
			Random r = new Random();
			numberOfOptions += (ulong)r.Next(500);
		}

		public override void DisplayStats()
		{
			base.DisplayStats();
			Console.WriteLine("Number of stock options: {0}", numberOfOptions);
		}

		public ulong NumbOpts 
		{
			get {return numberOfOptions;}
			set { numberOfOptions = value;}
		}
		#endregion 
	}
}
