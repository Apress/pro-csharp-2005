#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

using System.Collections;

namespace SimpleException
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Make a simple car.
            Console.WriteLine("***** Creating a car and stepping on it *****");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            // Try to rev the engine hard!
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Member name: {0}", e.TargetSite);
                Console.WriteLine("Class defining member: {0}",
                     e.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Stack: {0}", e.StackTrace);
                Console.WriteLine("Help Link: {0}", e.HelpLink);

                // By default, the data field is empty, so check for null.
                Console.WriteLine("\n-> Custom Data:");
                if (e.Data != null)
                {
                    foreach (DictionaryEntry de in e.Data)
                        Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
                }
            }

            Console.WriteLine("\n***** Out of exception logic *****");
            myCar.Accelerate(10);  // Will not speed up car.
            Console.ReadLine();
        }
    }
}