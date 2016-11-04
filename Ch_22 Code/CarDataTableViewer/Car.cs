using System;
using System.Collections.Generic;
using System.Text;

namespace CarDataSetViewer
{
    public class Car
    {
        public string carPetName, carMake, carColor;
        public Car(string petName, string make, string color)
        {
            carPetName = petName;
            carColor = color;
            carMake = make;
        }
    }   
}
