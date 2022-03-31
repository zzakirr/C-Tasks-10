using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Bycle:Vehicle
    {

        public void Drive(int millage)
        {
            Millage += millage;
        }

    }
}
