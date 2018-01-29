using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bike> bikes = new List<Bike>();
            bikes.Add(new Bike("Jopo", "Street Model", 2013, "Blue", false, ""));
            bikes.Add(new Bike("Tunturi", "StreetPower", 2016, "green", true, "Shimano"));
            // create a Bike object
          /*  Bike bike = new Bike();
            bike.Name = "Jopo";
            bike.Model = "Street Model";
            bike.Year = 2013;
            bike.Colour = "Blue";
            bike.GearWheels = false;
            bike.VehicleMethod();
            
            Bike bike2 = new Bike();
            bike2.Name = "Tunturi";
            bike2.Model = "Street Power";
            bike2.Year = 2016;
            bike2.Colour = "green";
            bike2.GearWheels = true;
            bike2.GearName = "Shimano";
            bike2.VehicleMethod(); */

            foreach (Bike bike in bikes)
            {
                Console.WriteLine(bike.ToString());
            }
            

            // create a Boat Object
            /*Boat boat = new Boat();
            boat.Name = "Suvi";
            boat.Model = "S900";
            boat.Year = 2010;
            boat.Colour = "White";
            boat.Seat = 4;
            boat.Type = "Rowboat";
            boat.BossMethod();
            Console.WriteLine(boat.ToString());*/



        }
    }
}
