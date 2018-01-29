using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Boat : Vehicle
    {
        private int seatCount2;
        private string boatType2;

        public Boat(string name, string model, int year, string colour, int seatCount, string boatType)
            :base(name, model, year, colour)
        {
            seatCount2 = seatCount;
            boatType2 = boatType;
        }

        public void BossMethod()
        {
            Console.WriteLine("Boss:");
        }

        // return Person data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " Type: " + boatType2 + " SeatCount: " + seatCount2;
        }
    }
}
