#define DEBUG

using System;

namespace Employees
{
	// Employee is the base class in this hierarchy.
	// It serves to hold data & functionality 
	// common to all employee types.
	abstract public class Employee
	{
        #region Nested Types
        // Nested types are considered fields.
        public class BenefitPackage
        {
            // A nested enum to represent different benefit package levels
            public enum BenefitPackageLevel
            {
                // These are named constants for 0, 1, and 2 repectively
                Standard, Gold, Platinum
            }

            public double ComputePayDeduction()
            { return 125.0; }
        } 
        #endregion

        #region Field data
        // protected data for kids.
        protected string fullName;
        protected int empID;
        protected float currPay;
        protected string empSSN;
        protected int empAge;
        private BenefitPackage empBenefits = new BenefitPackage();

        // private static data.
        private static string companyName; 
        #endregion

		#region Constructors
		// Default ctor.
		public Employee(){}

		// Custom ctor
		public Employee(string FullName, int empAge, int empID, 
			float currPay, string ssn)
		{
			// Assign internal state data.
			// Note use of 'this' keyword
			// to avoid name clashes.
			this.fullName = FullName;
			this.empID = empID;
			this.currPay = currPay;
			this.empSSN = ssn;
            this.empAge = empAge;
        }

		// A static ctor (to assign static field)
		static Employee()
		{companyName = "Intertech Training";}

		// If the user calls this ctor, forward to the 4-arg version
		// using arbitrary values...
		public Employee(string fullName) 
			: this(fullName, 30, 3333, 0.0F, ""){}
		#endregion 

		#region Methods
		// Bump the pay for this emp.
		public virtual void GiveBonus(float amount)
		{currPay += amount;}

		// Show state (could use ToString() as well)
		public virtual void DisplayStats()
		{
			Console.WriteLine("Name: {0}", fullName);
			Console.WriteLine("Pay: {0}", currPay);
			Console.WriteLine("ID: {0}", empID);
			Console.WriteLine("SSN: {0}", empSSN);
		}

        // Expose certain benefit behaviors of object.
        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }
		#endregion 

		#region properties
		// A static property.
		public static string Company
		{
			get { return companyName; }
			set { companyName = value;}
		}

		// Property for the empID.
		public int ID 
		{
			get {return empID;}
			set 
			{
				#if DEBUG
					Console.WriteLine("value is an instance of: {0} ", value.GetType()); 
					Console.WriteLine("value's value: {0} ", value);
				#endif
				empID = value;
			}
		}
		
		// Property for the currPay.
		public float Pay 
		{
			get {return currPay;}
			set {currPay = value;}
		}

        // Property for fullName.
        public string Name
        {
            get { return fullName; }
            set { fullName = value; }
        }

        // Another property for ssn.
		public string SocialSecurityNumber
		{
			protected set { empSSN = value; }
			get { return empSSN; }
		}

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        // Expose object through property.
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }
		#endregion 
	}
}
