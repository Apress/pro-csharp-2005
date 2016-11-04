#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Employees
{
    #region TheMachine Helper class
    public class TheMachine
    {
        public static void FireThisPerson(Employee e)
        {
            // Figure out which type I have using 'is'.
            if (e is SalesPerson)
            {
                Console.WriteLine("-> Lost a sales person named {0}", e.Name);
                Console.WriteLine("-> {0} made {1} sale(s)...",
                    e.Name, ((SalesPerson)e).NumbSales);
            }
            if (e is Manager)
            {
                Console.WriteLine("-> Lost a suit named {0}", e.Name);
                Console.WriteLine("-> {0} had {1} stock options...",
                    e.Name, ((Manager)e).NumbOpts);
            }
        }
    }
    #endregion
    
    class Program
    {
        static void Main(string[] args)
        {
            #region Uncomment to test abstract base class.
            // Employee e = new Employee();

            // Uncomment to test readonly field.
            // Employee brenner = new Employee();
            // brenner.SSNField = "666-66-6666";
            #endregion

            Console.WriteLine("***** These folks work at {0} *****",
                Employee.Company);

            Manager chucky = new Manager("Chucky", 35, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            chucky.Age++;   // Happy birthday Chuck!
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 26, 93, 30000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.WriteLine();

            #region Casting examples
            Console.WriteLine("***** Casting examples *****");
            // A Manager 'is-a' object.
            object frank = new Manager("Frank Zappa", 50, 9, 40000, "111-11-1111", 5);

            // A Manager 'is-a' Employee too.
            Employee moonUnit = new Manager("MoonUnit Zappa", 16, 2, 20000, "101-11-1321", 1);

            // A PTSales dude(tte) is a Sales dude(tte)
            SalesPerson jill = new PTSalesPerson("Jill", 30, 834, 100000, "111-12-1119", 90);

            // Cast from the generic System.Object into a strongly
            // typed Manager.
            Console.WriteLine("***** Counting frank's stock options *****");
            Manager mgr = (Manager)frank;
            Console.WriteLine("Frank's options: {0}", mgr.NumbOpts);
            Console.WriteLine("Frank's options: {0}",
                ((Manager)frank).NumbOpts);

            Console.WriteLine("\n***** Firing employees using casting operations! *****");
            TheMachine.FireThisPerson(moonUnit);
            Console.WriteLine();
            TheMachine.FireThisPerson(jill);
            Console.WriteLine();

            // Error!  Must cast when moving from base to derived!
            // TheMachine.FireThisPerson(frank);		

            TheMachine.FireThisPerson((Employee)frank);
            Console.WriteLine();

            #endregion

            // Creating a (very) nested BenefitPackageLevel enum variable.
            Employee.BenefitPackage.BenefitPackageLevel myBenifitLevel =
                Employee.BenefitPackage.BenefitPackageLevel.Platinum;

            Console.ReadLine();
        }
    }
}
