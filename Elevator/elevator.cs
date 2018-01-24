using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class elevator
    {
        private int maxFloor = 5;
        private int minFloor = 1;
        private int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value >= minFloor && value <= maxFloor) floor = value;
                else if (value < minFloor) Console.WriteLine("Floor is too small!");
                else Console.WriteLine("Floor too big!");

            }
        }
        private int floor = 1;

        public void ChangeFloor()
        {
            Console.WriteLine("Elevator is now in floor: " + Floor);
            Console.Write("Give a new floor number (1-5) > ");
            int number = int.Parse(Console.ReadLine());
            //int number1 = System.Convert.ToInt32(Console.ReadLine());
            Floor = number;
        }
    }
}
