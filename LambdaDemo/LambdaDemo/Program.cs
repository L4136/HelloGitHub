using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //four names to List
            List<string> nimet = new List<string> { "Arska", "Kalle", "Cecilia", "Jack" };
            string foo = nimet.FirstOrDefault(x => x.StartsWith("Ja"));
            Console.WriteLine(foo); //this prints Jack
        }

    }
}
