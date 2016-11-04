#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

using AttributedCarLibrary;

namespace VehicleDescriptionAttributeReader
{
    // Reflecting on custom attributes using early binding.
    public class Program
    {
        static void Main(string[] args)
        {
            // Get a Type representing the Winnebago.
            Type t = typeof(Winnebago);

            // Get all attributes on the Winnebago.
            object[] customAtts = t.GetCustomAttributes(false);

            // Print the description. 
            Console.WriteLine("***** Value of VehicleDescriptionAttribute *****\n");
            foreach (VehicleDescriptionAttribute v in customAtts)
                Console.WriteLine("-> {0}\n", v.Description);
            Console.ReadLine();
        }
    }

}
