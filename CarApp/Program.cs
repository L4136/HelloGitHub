using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {

            double temp = Temp.FahrenheitToCelsius(200);

            //create a car instance
            Car datsun = new Car("Datsun 100A", "red", 1.0, true, 2);
            Car porsche = new Car("Porsche 911 RS3", "silver", 3.2, false, 2);
            Car toyota = new Car("Toyota Camry", "blue", 2.0, true, 4);

            datsun.Speed = 100;
            porsche.Speed = 280;
            toyota.Speed = 160;

            // display car data
            datsun.PrintData();
            porsche.PrintData();
            toyota.PrintData();
            Console.ReadLine();
            // accelerate, change car's speed value
            datsun.Accelerate();
            // display car data again, notice changed speed value!
            datsun.PrintData();
            Console.ReadLine();
        }
    }
}
