using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car datsun = new Car();
            datsun.Speed = 100;
            Console.WriteLine("datsun speed is: " + datsun.Speed);

            datsun.Speed = 100;
            Console.WriteLine("datsun speed is: " + datsun.Speed);
        }
    }
}
