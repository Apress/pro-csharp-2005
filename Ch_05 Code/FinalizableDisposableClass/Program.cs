#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace FinalizableDisposableClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Finalizable / Disposable Type *****");
            Console.WriteLine("This program does nothing.");
            Console.WriteLine("See MyResourceWrapper.cs for code");
            Console.WriteLine("*****************************************");

            // Dispose automatically called. 
            using (MyResourceWrapper rw = new MyResourceWrapper())
            {

            }

            // This is safe given the disposable pattern.
            MyResourceWrapper rw2 = new MyResourceWrapper();
            for (int i = 0; i < 10; i++)
                rw2.Dispose();

            Console.ReadLine();
        }
    }
}
