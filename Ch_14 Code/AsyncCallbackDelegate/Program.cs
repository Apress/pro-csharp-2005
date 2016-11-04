#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

// Need this for the Thread.Sleep() call. 
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace AsyncCallbackDelegate
{
    // A C# delegate type.
    public delegate int BinaryOp(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  AsyncCallbackDelegate Example *****");
            Console.WriteLine("Main() invoked on thread {0}.",
                Thread.CurrentThread.GetHashCode());

            BinaryOp b = new BinaryOp(Add);
            IAsyncResult iftAR = b.BeginInvoke(10, 10, 
                new AsyncCallback(AddComplete), 
                "Main() thanks you for adding these numbers.");

            // Other work performed here...

            Console.ReadLine();
        }

        static void AddComplete(IAsyncResult itfAR)
        {
            Console.WriteLine("AddComplete() invoked on thread {0}.",
                Thread.CurrentThread.GetHashCode());
            Console.WriteLine("Your addition is complete");

            // Now get the result.
            AsyncResult ar = (AsyncResult)itfAR;
            BinaryOp b = (BinaryOp)ar.AsyncDelegate;
            Console.WriteLine("10 + 10 is {0}.", b.EndInvoke(itfAR));

            // Retrieve the informational object and cast it to string
            string msg = (string)itfAR.AsyncState;
            Console.WriteLine(msg);
        }

        static int Add(int x, int y)
        {
            Console.WriteLine("Add() invoked on thread {0}.",
                Thread.CurrentThread.GetHashCode());
            Thread.Sleep(5000);
            return x + y;
        }
    }
}
