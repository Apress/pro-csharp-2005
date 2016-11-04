#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

// Need this for the Thread.Sleep() call. 
using System.Threading;

namespace SyncDelegate
{
    // A C# delegate type.
    public delegate int BinaryOp(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Synch Delegate Review *****");

            // Print out the ID of the executing thread.
            Console.WriteLine("Main() invoked on thread {0}.",
                Thread.CurrentThread.GetHashCode());

            BinaryOp b = new BinaryOp(Add);
            int answer = b(10, 10);

            // These lines will not execute until 
            // the Add() method has completed. 
            Console.WriteLine("Doing more work in Main()!");
            Console.WriteLine("10 + 10 is {0}.", answer);            
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            // Print out the ID of the executing thread.
            Console.WriteLine("Add() invoked on thread {0}.",
                Thread.CurrentThread.GetHashCode());

            // Simulate a complex operation
            // and put the calling thead to sleep for
            // approximatly 5 seconds. 
            Thread.Sleep(5000);
            return x + y;
        }
    }
}
