using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Car
    {
        public string Name;
        private static int MaxSpeed = 200;

        //properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double EngineSize { get; set; }
        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value <= MaxSpeed) speed = value;
                else speed = MaxSpeed;
            }
        }
        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
        public bool FuzzyDice { get; set; }
        public int DoorCount { get; set; }


        public void Accelerate()
        {
            Speed += 5;
        }
        public void Brake()
        {
            Speed -= 5;
        }
        public void PrintData()
        {
            Console.WriteLine("Car data : ");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- engine : " + EngineSize);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- fuzzy dice : " + FuzzyDice);
            Console.WriteLine("- door count : " + DoorCount);
        }
        // constructor
        public Car(string model, string color, double engineSize, bool fuzzyDice, int doorCount)
        {
            Model = model;
            Color = color;
            EngineSize = engineSize;
            FuzzyDice = fuzzyDice;
            DoorCount = doorCount;
        }
        //destructor

        ~Car()
        {
            Console.WriteLine("Car object destroyed");
        }
    }
}
