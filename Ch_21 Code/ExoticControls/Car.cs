using System;
using System.Collections.Generic;
using System.Text;

namespace ExoticControls
{
    class Car
    {
        public Car(string pn, int cs)
        {
            petName = pn;
            currSp = cs;
        }
        public string petName;
        public int currSp;
        public Radio r;
    }

    class Radio
    {
        public double favoriteStation;
        public Radio(double station)
        { favoriteStation = station; }
    }
}
