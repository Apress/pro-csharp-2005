#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Echo some stats.
            Console.Write("Enter your name: ");
            string s;
            s = Console.ReadLine();
            Console.WriteLine("Hello, {0} ", s);
            Console.Write("Enter your age: ");
            s = Console.ReadLine();
            Console.WriteLine("You are {0} years old", s);

            #region String formatting
            int theInt = 90;
            double theDouble = 9.99;
            bool theBool = true;

            // Format a string...
            Console.WriteLine("Int is: {0}\nDouble is: {1}\nBool is: {2}",
                 theInt, theDouble, theBool);

            // Fill placeholders using an array of objects.
            object[] stuff =  { "Hello", 20.9, 1, "There", "83", 99.99933 };
            Console.WriteLine("The Stuff: {0} , {1} , {2} , {3} , {4} , {5} ", stuff);

            // John says...
            Console.WriteLine("{0}, Number{0}, Number{0}", 9);
    
            Console.WriteLine("C format: {0:C}", 99989.987);
            Console.WriteLine("D9 format: {0:D9}", 99999);
            Console.WriteLine("E format: {0:E}", 99999.76543);
            Console.WriteLine("F3 format: {0:F3}", 99999.9999);
            Console.WriteLine("N format: {0:N}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);

            // Use the static String.Format() method to build a new string.
            string formatStr;
            formatStr =
                String.Format("Don't you wish you had {0:C} in your account?",
                 99989.987);
            Console.WriteLine(formatStr);

            #endregion

            Console.ReadLine(); 
        }
    }
}
