#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace SimpleDispose
{
    // Implementing IDisposable.
    public class MyResourceWrapper : IDisposable
    {
        // The object user should call this method 
        // when they finished with the object.
        public void Dispose()
        {
            // Clean up unmanaged resources here.

            // Dispose other contained disposable objects.
            Console.WriteLine("In Dispose() method!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with IDisposable *****");
            MyResourceWrapper rw = new MyResourceWrapper();
            if (rw is IDisposable)
                rw.Dispose();

            // Dispose() is called automatically when the
            // using scope exits.
            using (MyResourceWrapper rw2 = new MyResourceWrapper())
            {
                // Use rw2 object.
            }

            Console.ReadLine();
        }
    }
}
