using System;

namespace MethodsAndParams
{
    class Program
    {
        #region Static helper methods.
        // Looks a lot like [in] and [out], does it not?
        public static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        // Same as...
        public static int Add(int x, int y)
        {
            return x + y;
        }

        // Returning multiple output parameters.
        public static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string...";
            c = true;
        }

        // reference parameter.
        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        // params keyword.
        // Return average of ‘some number’ of doubles.
        static double CalculateAverage(params double[] values)
        {
            double sum = 0;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }

        #endregion

        public static void Main()
        {
            Console.WriteLine("***** Fun with Params *****");
            // Use 'out' keyword (no need to assign because it is an out).
            Console.WriteLine("Adding 2 ints using out keyword");
            int ans;
            Add(90, 90, out ans);
            Console.WriteLine("90 + 90 = {0}\n", ans);

            // Method with multiple output params.
            Console.WriteLine("***** Calling method with multiple output params *****");
            int i; string str; bool b;
            FillTheseValues(out i, out str, out b);
            Console.WriteLine("Int is: {0}", i);
            Console.WriteLine("String is: {0}", str);
            Console.WriteLine("Boolean is: {0}", b);
            Console.WriteLine();

            // Swap some string data.
            Console.WriteLine("***** Swapping two strings *****");
            string s = "First string";
            string s2 = "My other string";
            Console.WriteLine("Before: {0}, {1}", s, s2);
            SwapStrings(ref s, ref s2);
            Console.WriteLine("After: {0}, {1}", s, s2);
            Console.WriteLine();

            // Use 'params' keyword.
            // Pass in a comma delimited list of doubles…
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7);
            Console.WriteLine("Average of 4.0, 3.2, 5.7 is: {0}",
                average);

            // …or pass an array of doubles.
            double[] data = { 4.0, 3.2, 5.7 };
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);
            Console.ReadLine();
        }
    }
}