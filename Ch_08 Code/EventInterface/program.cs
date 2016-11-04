#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace EventInterface
{
    #region The Sink object
    public class CarEventSink : IEngineStatus
    {
        private string name;
        public CarEventSink() { }
        public CarEventSink(string sinkName)
        { name = sinkName; }
        public void AboutToBlow(string msg)
        { Console.WriteLine("{0} reporting: {1}", name, msg); }
        public void Exploded(string msg)
        { Console.WriteLine("{0} reporting: {1}", name, msg); }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Interfaces as callbacks *****");

            // Make a car as usual. 
            Car c1 = new Car("SlugBug", 100, 10);

            // Make sink object.
            Console.WriteLine("\n***** Creating sinks *****");
            CarEventSink sink = new CarEventSink("First sink");
            CarEventSink myOtherSink = new CarEventSink("Other sink");

            // Hand sink to Car.
            Console.WriteLine("\n***** Sending 2 sinks into Car *****");
            c1.Advise(sink);
            c1.Advise(myOtherSink);

            // Speed up (this will generate the notifications.)
            Console.WriteLine("\n***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            // Detach sink from events.
            Console.WriteLine("\n***** Removing first sink *****");
            c1.Unadvise(sink);

            // Speed up again (only myothersink will be called.)
            Console.WriteLine("\n***** Speeding up again *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            // Detach other sink from events.
            Console.WriteLine("\n***** Removing second sink *****");
            c1.Unadvise(myOtherSink);

            Console.ReadLine();
        }
    }
}
