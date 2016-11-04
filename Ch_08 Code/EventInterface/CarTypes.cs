#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

using System.Collections;

namespace EventInterface
{
    // The callback interface.
    public interface IEngineStatus
    {
        void AboutToBlow(string msg);
        void Exploded(string msg);
    }

    public class Car
    {
        // The set of connected sinks.
        ArrayList clientSinks = new ArrayList();

        // Attach or disconnect from the source of events.
        public void Advise(IEngineStatus sink)
        { clientSinks.Add(sink); }

        public void Unadvise(IEngineStatus sink)
        { clientSinks.Remove(sink); }

        #region Basic Car members...
        #region Nested radio
        // Radio as nested type
        public class Radio
        {
            public void TurnOn(bool on)
            {
                if (on)
                    Console.WriteLine("Jamming...");
                else
                    Console.WriteLine("Quiet time...");
            }
        }
        #endregion

        // Internal state data.
        private int currSpeed;
        private int maxSpeed;
        private string petName;

        // Is the car alive or dead?
        bool carIsDead;

        // A car has-a radio.
        private Radio theMusicBox = new Radio();

        public Car()
        {
            maxSpeed = 100;
        }

        public Car(string name, int max, int curr)
        {
            currSpeed = curr;
            maxSpeed = max;
            petName = name;
        }

        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }
#endregion 

        public void Accelerate(int delta)
        {
            // If the car is dead, send Exploded event.
            if (carIsDead)
            {
                foreach (IEngineStatus e in clientSinks)
                    e.Exploded("Sorry, this car is dead...");
            }
            else
            {
                currSpeed += delta;

                // Almost dead?
                if (10 == maxSpeed - currSpeed)
                {
                    foreach (IEngineStatus e in clientSinks)
                        e.AboutToBlow("Careful buddy!  Gonna blow!");
                }

                // Still OK!
                if (currSpeed >= maxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("->CurrSpeed = " + currSpeed);
            }
        }
    }
}
