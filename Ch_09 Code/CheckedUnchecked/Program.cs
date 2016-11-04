#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

/********************************************************************/
// The project wide /checked option has been enabled for this project!
/********************************************************************/

namespace CheckedUnchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Checked / Unchecked *****\n");

            // Overflow the max value of a System.Byte.
            Console.WriteLine("Max value of byte is {0}.", byte.MaxValue);
            Console.WriteLine("Min value of byte is {0}.", byte.MinValue);
            byte b1 = 100;
            byte b2 = 250;
         
            try
            {
                checked
                {
                    byte sum = (byte)(b1 + b2);
                    byte b4, b5 = 100, b6 = 200;
                    b4 = (byte)(b5 + b6);
                    Console.WriteLine("sum = {0}", sum);
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            // Assuming /checked is enabled,
            // this block will not trigger
            // a runtime exception.
            unchecked
            {
                byte sum = (byte)(b1 + b2);
                Console.WriteLine("sum = {0}", sum);
            }

            Console.ReadLine();
        }
    }
}
