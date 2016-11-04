#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

using System.Threading;

namespace AddWithThreads
{
    class AddParams
    {
        public int a;
        public int b;

        public AddParams(int numb1, int numb2)
        {
            a = numb1;
            b = numb2;
        }
    }

    class Program
    {
        public static void Add(object data)
        {
            if (data is AddParams)
            {
                Console.WriteLine("ID of thread in Add(): {0}",
                    Thread.CurrentThread.GetHashCode());

                AddParams ap = (AddParams)data;
                Console.WriteLine("{0} + {1} is {2}",
                    ap.a, ap.b, ap.a + ap.b);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Adding with Thread objects *****");
            Console.WriteLine("ID of thread in Main(): {0}",
                Thread.CurrentThread.GetHashCode());

            AddParams ap = new AddParams(10, 10);
            Thread t = new Thread(new ParameterizedThreadStart(Add));
            t.Start(ap);
            
            // Do other work on Main() here.
            Console.ReadLine();
        }
    }
}