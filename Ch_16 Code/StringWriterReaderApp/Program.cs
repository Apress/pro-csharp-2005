using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StringWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with StringWriter / StringReader *****\n");

            // Create a StringWriter and emit character data 
            // to memory.
            StringWriter strWriter = new StringWriter();
            strWriter.WriteLine("Don't forget Mother's Day this year...");
            strWriter.Close();
 
            // Get a copy of the contents (stored in a string) and pump
            // to console.
            Console.WriteLine("Contents of StringWriter: {0}", strWriter);

            // Get the internal StringBuilder.
            StringBuilder sb = strWriter.GetStringBuilder();
            sb.Insert(0, "Hey!! ");
            Console.WriteLine("-> {0}", sb.ToString());

            // Remove the inserted string.
            sb.Remove(0, "Hey!! ".Length);
            Console.WriteLine("-> {0}", sb.ToString());

            // Now dump using a StringReader.
            Console.WriteLine("-> Here are your thoughts:");
            StringReader strReader = new StringReader(strWriter.ToString());

            string input = null;
            while ((input = strReader.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            strReader.Close();
        }
    }
}
