using System;
using System.Text;

namespace Strings
{
    class StringApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Strings *****");

            #region Basic String Operations
            // Basic string operations.
            string s = "Boy, this is taking a long time.";
            Console.WriteLine("--> s contains 'oy'?: {0}", s.Contains("oy"));
            Console.WriteLine("--> s contains 'Boy'?: {0}", s.Contains("Boy"));
            Console.WriteLine(s.Replace('.', '!'));
            Console.WriteLine(s.Insert(0, "Boy O' "));
            Console.WriteLine();

            // Test for equality between stings.
            string s1 = "Hello ";
            string s2 = "World!";
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine();

            // Concatenation of strings.
            string newString = s + s1 + s2;
            Console.WriteLine("s + s1 + s2 = {0}", newString);
            Console.WriteLine("string.Concat(s, s1, s2) = {0}", string.Concat(s, s1, s2));
            Console.WriteLine();

            // System.String also defines an indexer to access each
            // character in the string.
            for (int k = 0; k < s1.Length; k++)
                Console.WriteLine("Char {0} is {1}", k, s1[k]);
            foreach (char c in s1)
                Console.WriteLine(c);
            Console.WriteLine(); 
            #endregion

            #region Escape chars and verbatim strings
            // Escape characters.
            string s3 = "Hello\tThere\tAgain";
            Console.WriteLine(s3);
            Console.WriteLine("Everyone loves \"Hello World\"");
            Console.WriteLine("C:\\MyApp\\bin\\debug");
            Console.WriteLine("All finished.\n\n\n");

            // The @ prefix turns off the processing of escape characters.
            string finalString = @"\n\tString file: 'C:\MyApp\Strings'";
            Console.WriteLine(finalString);

            // White space is preserved with verbatim strings.
            string myLongString = @"This is a very
            very 
            very 
            long string";
            Console.WriteLine(myLongString);
            #endregion 

            // Make changes to strFixed?  Nope!
            System.String strFixed = "This is how I began life";
            Console.WriteLine(strFixed);
            string upperVersion = strFixed.ToUpper();
            Console.WriteLine(strFixed);
            Console.WriteLine("{0}\n\n", upperVersion);

			Console.WriteLine(@"Cerebus said ""Look, Kid, Cerebus is in love with your wife.""");

			// Create a StringBuilder which hold 100 characters.
            StringBuilder myBuffer = new StringBuilder("My string data");
            Console.WriteLine("Capacity of this StringBuilder: {0}", myBuffer.Capacity);
            myBuffer.Append(" contains some numerical data: ");
            myBuffer.AppendFormat("{0}, {1}.", 44, 99);
            Console.WriteLine("Capacity of this StringBuilder: {0}", myBuffer.Capacity);
            Console.WriteLine(myBuffer);
            Console.ReadLine();
        }
    }
}
