using System;

namespace Enums
{
    // Here is a custom enum.
    enum EmpType : byte
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VP = 9
    }

    class Program
    {
        #region Helper function
        // Enums as parameters.
        public static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.VP:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
                default: break;
            }
        } 
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("***** Enums as parameters *****");
            EmpType fred;
            fred = EmpType.VP;
            AskForBonus(fred);

            // Print out string version of ‘fred’.
            Console.WriteLine("\n***** ToString() *****");
            Console.WriteLine(fred.ToString());

            //Get underlying type.
            Console.WriteLine("\n***** Enum.GetUnderlyingType() *****");
            Console.WriteLine(Enum.GetUnderlyingType(typeof(EmpType)));

            // Get Fred's type, hex and value.
            Console.WriteLine("\n***** Enum.Format() *****");
            Console.WriteLine("You are a {0}", fred.ToString());
            Console.WriteLine("Hex value is {0}", Enum.Format(typeof(EmpType), fred, "x"));
            Console.WriteLine("Int value is {0}", Enum.Format(typeof(EmpType), fred, "D"));

            // Parse.
            Console.WriteLine("\n***** Enum.Parse() *****");
            EmpType sally = (EmpType)Enum.Parse(typeof(EmpType), "Manager");
            Console.WriteLine("Sally is a {0}", sally.ToString());

            // Get all stats for EmpType.
            Console.WriteLine("\n***** Enum.GetValues() *****");
            Array obj = Enum.GetValues(typeof(EmpType));
            Console.WriteLine("This enum has {0} members:", obj.Length);

            // Now show the string name and associated value.
            foreach (EmpType e in obj)
            {
                Console.Write("String name: {0}", Enum.Format(typeof(EmpType), e, "G"));
                Console.Write(" ({0})", Enum.Format(typeof(EmpType), e, "D"));
                Console.Write(" hex: {0}\n", Enum.Format(typeof(EmpType), e, "X"));
            }

            // Does EmpType have a SalePerson value?
            Console.WriteLine("\n***** Enum.IsDefined() *****");
            if (Enum.IsDefined(typeof(EmpType), "SalesPerson"))
                Console.WriteLine("Yep, we have sales people.");
            else
                Console.WriteLine("No, we have no profits....");

            Console.WriteLine("\n***** < and > *****");
            EmpType Joe = EmpType.VP;
            EmpType Fran = EmpType.Grunt;

            if (Joe < Fran)
                Console.WriteLine("Joe's value is less than Fran's value.");
            else
                Console.WriteLine("Fran's value is less than Joe's value.");

            Console.ReadLine();
        }
    }
}
