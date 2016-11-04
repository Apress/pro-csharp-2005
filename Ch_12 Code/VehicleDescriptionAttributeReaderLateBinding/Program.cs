#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

using System.Reflection;

namespace VehicleDescriptionAttributeReaderLateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Descriptions of Your Vehicles *****\n");

            // Load the local copy of AttributedCarLibrary.
            Assembly asm = Assembly.Load("AttributedCarLibrary");

            // Get type info of VehicleDescriptionAttribute.
            Type vehicleDesc = asm.GetType("AttributedCarLibrary.VehicleDescriptionAttribute");

            // Get type info of Description property.
            PropertyInfo propDesc = vehicleDesc.GetProperty("Description");

            // Get all types in the assembly. 
            Type[] types = asm.GetTypes();

            // Iterate over each type and obtain any VehicleDescriptionAttributes.
            foreach (Type t in types)
            {
                object[] objs = t.GetCustomAttributes(vehicleDesc, false);

                // Iterate over each VehicleDescriptionAttribute and print
                // description using late binding. 
                foreach (object o in objs)
                {
                    Console.WriteLine("-> {0}: {1}\n", 
                        t.Name, propDesc.GetValue(o, null));                    
                }
            }
            Console.ReadLine();
        }
    }
}
