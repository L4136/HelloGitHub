using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace w3a6
{
    class Program
    {
        static void Main(string[] args)
        {
            string comparison;
            double RandomNumber(double min, double max) 
            {
                Random random = new Random(); return random.Next(1, 100);
            }

            Console.WriteLine("Guess my number! It is between 1 and 100.");
            double yourNumber = Convert.ToDouble(Console.ReadLine());

            if (random < yourNumber)
                comparison = "smaller than";
            else
            {
                if (yourNumber == RandomNumber)
                    comparison = "exactly the same as";
                else
                    comparison = "bigger than";
            }
            Console.WriteLine("My number is {0} your number.",
                              comparison);
            Console.ReadKey();
        }
    }
}
