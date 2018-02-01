using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyres
{
    public class Vehicle 
    {
        public string name2;
        public string model2;
        public int tyreCount2;
        int i = 0;
        public Vehicle(string name, string model, int tyrecount)
        {
            name2 = name;
            model2 = model;
            tyreCount2 = tyrecount;
        }
            public override string ToString()
        {
            return "Vehicle name: " + name2 + " Model: " + model2 + "\n";
                               
        }

        public void VehicleMethod()
        {
            while (i < tyreCount2)
            {
                Console.WriteLine(Tyre.ToString()); i++;            
            }
        }

    
    }
}
