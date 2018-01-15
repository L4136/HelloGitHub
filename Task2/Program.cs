using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your points > ");
            string line = Console.ReadLine();

            int number = 0;

            /*
            if (int.TryParse(line, out number))
            {
                switch (number)
                {
                    case 0: case 1:
                        Console.WriteLine("School grade is 0.");
                        break;
                    case 2: case 3:
                        Console.WriteLine("School grade is 1.");
                        break;
                    case 4: case 5:
                        Console.WriteLine("School grade is 2.");
                        break;
                    case 6: case 7:
                        Console.WriteLine("School grade is 3.");
                        break;
                    case 8:
                    case 9:
                        Console.WriteLine("School grade is 4.");
                        break;
                    case 10:
                    case 11:
                    case 12:
                        Console.WriteLine("School grade is 5.");
                        break;

                    default:
                        Console.WriteLine("Number is not within the score limit.");
                        break;
                }
            } 
            else
            {
                Console.WriteLine("That's not a number.");
            } */
            if (int.TryParse(line, out number))
            {
                if (number == 0 || number == 1)
                {
                    Console.WriteLine("School grade is 0.");
                    
                }
                else if (number == 2 || number == 3)
                {
                    Console.WriteLine("School grade is 1.");
                }
                else if (number == 4 || number == 5)
                {
                    Console.WriteLine("School grade is 2.");
                }
                else if (number == 6 || number == 7)
                {
                    Console.WriteLine("School grade is 3.");
                }
                else if (number == 8 || number == 9)
                {
                    Console.WriteLine("School grade is 4.");
                }
                else if (number == 10 || number == 11 || number == 12)
                {
                    Console.WriteLine("School grade is 5.");
                }
                else
                {
                    Console.WriteLine("Score is not within the limit.");
                }
            }
            else
            {
                Console.WriteLine("That's not a number.");
            }



        }
    }
}
