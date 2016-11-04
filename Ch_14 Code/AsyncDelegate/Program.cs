#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

// Need this for the Thread.Sleep() call. 
using System.Threading;

namespace AsyncDelegate
{
    // A C# delegate type.
    public delegate int BinaryOp(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Async Delegate Invocation *****");

            // Print out the ID of the executing thread.
            Console.WriteLine("Main() invoked on thread {0}.",
                Thread.CurrentThread.GetHashCode());

            BinaryOp b = new BinaryOp(Add);
            IAsyncResult iftAR = b.BeginInvoke(10, 10, null, null);

//            while(!iftAR.IsCompleted)
//            {
//                Console.WriteLine("Doing more work in Main()!");
//            } 

            while (!iftAR.AsyncWaitHandle.WaitOne(2000, true))
            {
                Console.WriteLine("Doing more work in Main()!");
            }

            // Now we know the Add() method is complete.
            int answer = b.EndInvoke(iftAR);
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
