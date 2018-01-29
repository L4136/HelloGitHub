using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        public string name2;
        public string model2;
        public int year2;
        public string colour2;

        public Vehicle (string name, string model, int year, string colour)
        {
            name2 = name;
            model2 = model;
            year2 = year;
            colour2 = colour;
        }
        
        public void VehicleMethod()
        {
            Console.WriteLine( " info");
        }

        // return Person data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return "- Name: " + name2 + " Model: " + model2 + " Year: " + year2 + " Colour: " + colour2;
        }
    }
}
