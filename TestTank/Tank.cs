using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapselointi
{
    class Car
    {
        // properties
        public string Name { get; set; }
        public string Type { get; set; }
        public int CrewCount { get; set; }
        public float Speed { get; set; }
        public readonly float SpeedMax = 100; 

        // don't create any constructor, so default one will be used

        // method to give more speed
        public void AccelerateTo()
        {
            Speed += 5;
        }

        // method to slow down
        public void BrakeTo()
        {
            Speed -= 5;
        }

        // method to display car data
        public void PrintData()
        {
            Console.WriteLine("Car data : ");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- engine : " + Engine);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- fuzzy dices : " + FuzzyDices);
            Console.WriteLine("- door count : " + DoorCount);
        }

    }

}