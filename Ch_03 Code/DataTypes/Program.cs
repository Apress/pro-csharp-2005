#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Data Types *****");

            // 12 is-a System.Int32 which is-a System.ValueType
            // which is-a System.Object.
            Console.WriteLine(12.GetHashCode());
            Console.WriteLine(12.Equals(23));
            Console.WriteLine(12.GetType().BaseType);
            Console.WriteLine(12.ToString());
            Console.WriteLine(12); // ToString() called automatically.

            // Exercise a ushort.
            Console.WriteLine("\n***** Fun with unsigned shorts *****");
            System.UInt16 myUInt16 = 30000;
            Console.WriteLine("Max for an UInt16 is: {0} ", UInt16.MaxValue);
            Console.WriteLine("Min for an UInt16 is: {0} ", UInt16.MinValue);
            Console.WriteLine("Value is: {0} ", myUInt16);
            Console.WriteLine("I am a: {0} ", myUInt16.GetType());

            // Now in System.UInt16 shorthand (e.g. a ushort).
            ushort myOtherUInt16 = 12000;
            Console.WriteLine("Max for an UInt16 is: {0} ", ushort.MaxValue);
            Console.WriteLine("Min for an UInt16 is: {0} ", ushort.MinValue);
            Console.WriteLine("Value is: {0} ", myOtherUInt16);
            Console.WriteLine("I am a: {0} ", myOtherUInt16.GetType());

            Console.WriteLine("\n***** Fun with doubles *****");
            Console.WriteLine("-> double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("-> double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("-> double.NegativeInfinity: {0}", double.NegativeInfinity);
            Console.WriteLine("-> double.MaxValue: {0}", double.MaxValue);
            Console.WriteLine("-> double.MinValue: {0}", double.MinValue);

            Console.WriteLine("\n***** Fun with bools *****");
            // No more ad-hoc Boolean types in C#!
            // bool b = 0;        // Illegal!
            // bool b2 = -1;      // Also illegal!
            bool b3 = true;    // No problem.
            bool b4 = false;   // No problem.
            Console.WriteLine("-> bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("-> bool.TrueString: {0}", bool.TrueString);

            // Test the truth of the following statements...
            Console.WriteLine("\n***** Fun with chars *****");
            Console.WriteLine("-> char.IsDigit('K'): {0}", char.IsDigit('K'));
            Console.WriteLine("-> char.IsDigit('9'): {0}", char.IsDigit('9'));
            Console.WriteLine("-> char.IsLetter('10', 1): {0}", char.IsLetter("10", 1));
            Console.WriteLine("-> char.IsLetter('p'): {0}", char.IsLetter('p'));
            Console.WriteLine("-> char.IsWhiteSpace('Hello There', 5): {0}",
                char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("-> char.IsWhiteSpace('Hello There', 6): {0}",
                char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("-> char.IsLetterOrDigit('?'): {0}",
                char.IsLetterOrDigit('?'));
            Console.WriteLine("-> char.IsPunctuation('!'): {0}",
                char.IsPunctuation('!'));
            Console.WriteLine("-> char.IsPunctuation('>'): {0}",
                char.IsPunctuation('>'));
            Console.WriteLine("-> char.IsPunctuation(','): {0}",
                char.IsPunctuation(','));

            // Test the truth of the following statements...
            Console.WriteLine("\n***** Fun with parsing *****");
            bool myBool = bool.Parse("True");
            Console.WriteLine("-> Value of myBool: {0}", myBool);
            double myDbl = double.Parse("99.884");
            Console.WriteLine("-> Value of myDbl: {0}", myDbl);
            int myInt = int.Parse("8");
            Console.WriteLine("-> Value of myInt: {0}", myInt);
            char myChar = char.Parse("w");
            Console.WriteLine("-> Value of myChar: {0}\n", myChar);

            Console.WriteLine("\n***** Fun with DateTime *****");            
            // This constructor takes (year, month, day)
            DateTime dt = new DateTime(2004, 10, 17);
            
            // What day of the month is this?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);            
            dt.AddMonths(2);  // Month is now December.
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

            Console.WriteLine("\n***** Fun with TimeSpan *****");
            // This constructor takes (hrs, minutes, seconds)
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            // Subtract 15 minutes from the current TimeSpan and
            // print the result.
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));

            Console.ReadLine();
        }
    }
}
