#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Loops and decisions *****");

            #region For loop
            // Note! 'i' is only visible within the scope of the for loop.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number is: {0} ", i);
            }
            // 'i' is not visible here.
            #endregion

            #region Foreach loop
            string[] books = {"Complex Algorithms", 
                "Do you Remember Classic COM?",
                "C# and the .NET Platform"};
            foreach (string s in books)
            { Console.WriteLine(s); }

            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
            { Console.WriteLine(i); }
            #endregion

            #region While loop
            // The while loop.
            string userIsDone = "no";
            while (userIsDone != "yes")
            {
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
                Console.WriteLine("In while loop");
            }
            #endregion

            #region Do/while loop
            string ans;
            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                ans = Console.ReadLine();
            } while (ans != "yes");
            #endregion

            #region Switch statement
//            Console.WriteLine("1 [C#], 2 [VB]");
//            Console.Write("Please pick your language preference: ");
//
//            string langChoice = Console.ReadLine();
//            int n = int.Parse(langChoice);
//
//            switch (n)
//            {
//                // C# demands that each case (including 'default') which
//                // contains executable statements, must have 
//                // a terminating 'break' or 'goto' to avoid fall through.
//                case 1:
//                    Console.WriteLine("Good choice, C# is a fine language.");
//                    break;
//                case 2:
//                    Console.WriteLine("VB .NET: OOP, multi-threading and more!");
//                    break;
//                default:
//                    Console.WriteLine("Well...good luck with that!");
//                    break;
//            }
            Console.WriteLine("C# or VB");
            Console.Write("Please pick your language preference: ");

            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                // C# demands that each case (including 'default') which
                // contains executable statements, must have 
                // a terminating 'break' or 'goto' to avoid fall through.
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB .NET: OOP, multi-threading and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
            #endregion
            
            Console.ReadLine();
        }
    }
}
