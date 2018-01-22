using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticmembers
{
    class Program
    {
        static void Main(string[] args)
        /*{ 

              // mathUtils utils = new mathUtils();

              // int v = utils.Power2(15)
              int v = mathUtils.Power2(15);
              Console.WriteLine("V: " + v);
          }*/
        /*{
            CreateCats(99);
            Console.WriteLine("CatCount: " + Cat.CatCount());

        }
            static void CreateCats(int num)
            {
                int i;
                for (i = 0; i < 99; i++)
                {
                    Cat cat = new Cat();
                }
            }
        */
        /* {
             // int i = 54321;
             //long n = i;
             //byte c = (byte) n;

             double d = 654321.9987;
             //int i = (int)Math.Round(d);
             //int i = (int)(d + 0.5);
             int i = Convert.ToInt32(d);

             Console.WriteLine("i: " + i);
         }*/
        /*{
            int i = int.MaxValue;
            Console.WriteLine("i: " + i);

            int e = int.MinValue;
            Console.WriteLine("e: " + e);

            double d = double.MaxValue;
            Console.WriteLine("d: " + d);
            double o = double.MinValue;
            Console.WriteLine("o: " + o);

            float f = float.MaxValue;
            Console.WriteLine("f: " + f);
            float l = float.MinValue;
            Console.WriteLine("l: " + l);
        }*/
        {
            long number = 0;    //jos tässä tyyppinä double...
            string line = Console.ReadLine();

            bool result = Int64.TryParse(line, out number);  //... niin tässä tyyppinä Double
            if (result)
            {
                Console.WriteLine("Success: " + number);
            
            }
            else
            {
                Console.WriteLine("NaN!");
            }
        }
    }
}
