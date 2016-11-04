using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes
{
class DatabaseReader
{
    // Nullable data field.
    public int? numbericValue;
    public bool? boolValue = true;

    // Note the nullable return type. 
    public int? GetIntFromDatabase()
    { return numbericValue; }

    // Note the nullable return type. 
    public bool? GetBoolFromDatabase()
    { return boolValue; }
}

    class Program
    {
        static void Main(string[] args)
        {
            // Uncomment to generate compiler errors.
            // bool myBool = null;
            // int myInt = null;

            Console.WriteLine("***** Fun with Nullable Data *****\n");
            DatabaseReader dr = new DatabaseReader();

            // Get int from 'database'.
            int? i = dr.GetIntFromDatabase();
            if (i.HasValue)
                Console.WriteLine("Value of 'i' is: {0}", i);
            else
                Console.WriteLine("Value of 'i' is undefined.");

            // Get bool from 'database'.
            bool? b = dr.GetBoolFromDatabase();
            if (b != null)
                Console.WriteLine("Value of 'b' is: {0}", b);
            else
                Console.WriteLine("Value of 'b' is undefined.");

            // If the value from GetIntFromDatabase() is null, 
            // assign local variable to 100.
            int? myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of myData: {0}", myData);
            Console.ReadLine();
        }
    }
}