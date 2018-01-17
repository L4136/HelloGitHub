using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace w3a2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] numbers = new int[5];
            for (i = 0; i < 5; i++)
            {
                
                Console.Write("Give a number: ");
                numbers[i] = int.Parse(Console.ReadLine());

            }

            Console.Write("Numbers are");
            for (i = 4; i >= 0; i--)
            {
                Console.Write(" " + numbers[i] );
            }
            Console.Write(". ");

        }
    }
}
