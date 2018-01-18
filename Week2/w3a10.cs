using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace w3a10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number :");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number :");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1: Multiplication");
            Console.WriteLine("2: Addition");
            Console.WriteLine("3: Subtraction");
            Console.WriteLine("4: Division");

            Console.WriteLine("Pick an operation:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.WriteLine (firstNumber * secondNumber); break;
                case 2: Console.WriteLine(firstNumber + secondNumber); break;
                case 3: Console.WriteLine(firstNumber - secondNumber); break;
                case 4: Console.WriteLine(firstNumber / secondNumber); break;
                default: Console.WriteLine("That is not a valid operation."); break;

            }
        }
    }
}
