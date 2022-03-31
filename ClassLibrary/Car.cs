using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car:Vehicle
    {
        public int FuelCapacity;
        public int CurrentFuel;
        public int FuelFor1km;

        public void Drive(int millage)
        {
            int temp = millage * FuelFor1km;
            if (temp <= CurrentFuel)
            {
                CurrentFuel -= temp;
                Millage += millage;
            }
        }
    }
}
