#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Constants
{
    static class ConstData
    {
        // The value of a const must be known at compile
        // time. 
        public const string BestNbaTeam = "Timberwolves";
        public const double SimplePI = 3.14;
        public const bool Truth = true;
        public const bool Falsity = !Truth;
    }

    class Program   
    {
        public const string BestNhlTeam = "Wild";

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Constants *****");
            // Print const values defined by other type.
            Console.WriteLine("Nba const: {0}", ConstData.BestNbaTeam);
            Console.WriteLine("SimplePI const: {0}", ConstData.SimplePI);
            Console.WriteLine("Truth const: {0}", ConstData.Truth);
            Console.WriteLine("Falsity const: {0}", ConstData.Falsity);
    
            // Print member level const.
            Console.WriteLine("Nhl const: {0}", BestNhlTeam);

            // Print local-scoped const. 
            const int LocalFixedValue = 4;
            Console.WriteLine("Local const: {0}", LocalFixedValue);
            Console.ReadLine();
        }
    }
}
