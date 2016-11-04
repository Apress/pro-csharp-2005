#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace StaticData
{
    // Static classes can only 
    // contain static members and constant fields.
    static class UtilityClass
    {
        public static void PrintTime()
        { Console.WriteLine(DateTime.Now.ToShortTimeString()); }
        public static void PrintDate()
        { Console.WriteLine(DateTime.Today.ToShortDateString()); }
    }

    #region SavingsAccount Class
    class SavingsAccount
    {
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        // Static constructor.
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;
        }

        public double currBalance;
        public static double currInterestRate;

        // Static methods to get / set interest rate.
        public static void SetInterestRate(double newRate)
        { currInterestRate = newRate; }
        public static double GetInterestRate()
        { return currInterestRate; }

        // Instance method to get/set current interest rate
        public void SetInterestRateObj(double newRate)
        { currInterestRate = newRate; }
        public double GetInterestRateObj()
        { return currInterestRate; }
    } 
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data *****");
            UtilityClass.PrintDate();
            UtilityClass.PrintTime();

            // Compiler error!
            // UtilityClass u = new UtilityClass();

            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);
            
            // Get and set interest rate.
            Console.WriteLine("Interest Rate is: {0}", s1.GetInterestRateObj());
            s2.SetInterestRateObj(0.08);

            // Make new object, this does NOT 'reset' the interest rate.
            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            Console.ReadLine();
        }
    }
}
