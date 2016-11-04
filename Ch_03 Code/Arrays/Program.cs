using System;

namespace Arrays
{
    class Program
    {
        #region Helper functions
        public static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
        }

        public static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        } 
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****\n");

            #region Array declarations

            // A string array containing 10 elements {0 - 2}.
            string[] booksOnCOM;
            booksOnCOM = new string[3];
            booksOnCOM[0] = "Developer’s Workshop to COM and ATL 3.0";
            booksOnCOM[1] = "Inside COM";
            booksOnCOM[2] = "Inside ATL";
            foreach (string s in booksOnCOM)
                Console.WriteLine(s);

            //Initialize a 100 item string array,numbered {0 -99}
            string [] booksOnDotNet = new string [100];

            // Various ways to create an arry of fixed size.
            int[] n = new int[] { 20, 22, 23, 0 };
            int[] n2 = new int[4] { 20, 22, 23, 0 };
            int[] n3 = { 20, 22, 23, 0 };
            #endregion

            Console.WriteLine("\n***** Array as Parameter *****");
            PrintArray(n2);

            Console.WriteLine("\n***** Array as return value *****");
            string[] strs = GetStringArray();
            foreach (string s in strs)
                Console.WriteLine(s);

            #region MD arrays
            Console.WriteLine("\n***** A rectangular MD array *****\n");
            int[,] myMatrix;
            myMatrix = new int[6, 6];

            // Populate (6 * 6) array.
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    myMatrix[i, j] = i * j;

            // Show (6 * 6) array.
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n***** A jagged MD array *****\n");
            int[][] myJagArray = new int[5][];

            // Create the jagged array.
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            // Print each row (remember, each element is 
            // defaulted to zero!
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Length of row {0} is {1}:\t", i, myJagArray[i].Length);
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            } 
            #endregion

            Console.WriteLine("\n***** Created array of strings *****");
            string[] firstNames = { "Steve", "Dominic", "Swallow", "Baldy" };

            // Print names as declared.
            Console.WriteLine("Here is the array:");
            for (int i = 0; i < firstNames.Length; i++)
                Console.Write("Name: {0}\t", firstNames[i]);
            Console.WriteLine("\n");

            // Reverse array and print.
            Array.Reverse(firstNames);
            Console.WriteLine("Here is the array once reversed:");
            for (int i = 0; i < firstNames.Length; i++)
                Console.Write("Name: {0}\t", firstNames[i]);
            Console.WriteLine("\n");

            // Clear out all but Baldy.
            Console.WriteLine("Cleared out all but Baldy...");
            Array.Clear(firstNames, 1, 3);
            for (int i = 0; i < firstNames.Length; i++)
                Console.Write("Name: {0}\t", firstNames[i]);

            Console.ReadLine();
        }
    }
}
