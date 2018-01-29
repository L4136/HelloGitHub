using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Bike : Vehicle
    {
        private bool gearWheels2;
        private string gearName2;

        public Bike (string name, string model, int year, string colour, bool gearWheels, string gearName)
            :base(name, model, year, colour)
        {
            gearWheels2 = gearWheels;
            gearName2 = gearName;
        }

        public void BossMethod()
        {
            Console.WriteLine("Boss:");
        }

        // return Person data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " Gear Wheels: " + gearWheels2  + " Gear Name: " + gearName2;
        }
    }
}
