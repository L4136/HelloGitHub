using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number from 1 to 3 > ");
            string line = Console.ReadLine();

            int number = 0;
            if (int.TryParse(line, out number))
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Number is one.");
                        break;
                    case 2:
                        Console.WriteLine("Number is two.");
                        break;
                    case 3:
                        Console.WriteLine("Number is three.");
                        break;

                    default:
                        Console.WriteLine("This is not a 1-2-3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("That's not a number.");
            }


                
        }
    }
}
