using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyres
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle("Porsche", "model 911", 4));
            vehicles.Add(new Vehicle("Ducati", "model Diavel", 2));

            List<Tyre> tyres = new List<Tyre>();
            tyres.Add(new Tyre("Nokia", "Hakkapeliitta", "205R16"));

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }
    }
}
