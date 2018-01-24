using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTank
{
    class Tank
    {
        // properties
        public string Name { get; set; }
        private string name;
        public string Type { get; set; }
        private string type;
        private int CrewCount
        {
            get
            {
                return crewcount;
            }
            set
            {
                if (value >= 2 && value <= 6) crewcount = value;
                else Console.WriteLine ("Value not within limit (2-6).");
            }
        }
        private int crewcount;
        private float Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value >= 0 && value <= SpeedMax) speed = value;
                else if (value > SpeedMax) speed = SpeedMax;
                else speed = 0;
              
            }
        }
        private float speed = 0;
        private readonly float SpeedMax = 100;
        

        // don't create any constructor, so default one will be used

        // method to give more speed
        public void AccelerateTo(float userInput)
        {
            
            if (userInput > Speed) Speed = userInput;
            Console.WriteLine("Accelerate to: " + Speed);
        }

        // method to slow down
        public void BrakeTo(float userInput)
        {
            
            if (userInput < Speed) Speed = userInput;
            Console.WriteLine("Brake to: " + Speed);
        }
        

    }

}