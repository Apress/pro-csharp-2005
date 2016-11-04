using System;

namespace SimpleException
{
    public class Car
    {
        // Constant for maximum speed.
        public const int maxSpeed = 100;

        // Internal state data.
        private int currSpeed;
        private string petName;

        // Is the car still operational?
        private bool carIsDead;

        // A car has-a radio.
        private Radio theMusicBox = new Radio();

        public Car() { }
        public Car(string name, int currSp)
        {
            currSpeed = currSp;
            petName = name;
        }

        public void CrankTunes(bool state)
        {
            // Delegate request to inner object.
            theMusicBox.TurnOn(state);
        }

        // This time, throw an exception if the user speeds up a trashed automobile.
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", petName);
            else
            {
                currSpeed += delta;
                if (currSpeed >= maxSpeed)
                {
                    carIsDead = true;
                    currSpeed = 0;

                    Exception ex = new Exception(string.Format("{0} has overheated!", petName));
                    ex.HelpLink = "http://www.CarsRUs.com";

                    // Stuff in extra info about the error.
                    ex.Data.Add("TimeStamp", string.Format("The car exploded at {0}", DateTime.Now));
                    ex.Data.Add("Cause", "You have a lead foot.");
                    throw ex;
                }
                else
                    Console.WriteLine("=> CurrSpeed = {0}", currSpeed);
            }
        }
    }
}

