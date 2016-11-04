using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace CalculatorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with WS Proxies *****\n");

            // Make the proxy. 
            CalculatorWebService ws = new CalculatorWebService();

            // Call the Add() method synchronously.
            Console.WriteLine("10 + 10 = {0}", ws.Add(10, 10));

            // Call the Subtract method asynchronously
            // using the new .NET 2.0 event approach.
            ws.SubtractCompleted += new SubtractCompletedEventHandler(ws_SubtractCompleted);
            ws.SubtractAsync(50, 45);

            Console.ReadLine();
        }

        static void ws_SubtractCompleted(object sender, SubtractCompletedEventArgs e)
        {
            Console.WriteLine("Your answer is: {0}", e.Result);
        }
    }
}
