using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        public string Color;
        public string Brand;
        public double Millage;
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Color:{Color} Brand:{Brand} Millage:{Millage}");
        }
        
        
        
    }
}
