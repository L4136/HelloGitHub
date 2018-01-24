using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amplifier
{
    class Vahvistin
    {
        private int maxVol = 100;
        private int minVol = 0;
        private int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= minVol && value <= maxVol)
                {
                    volume = value;
                    Console.WriteLine("-> Amplifier volume is set to: " + Volume);
                }

                else if (value < minVol)
                {
                    volume = minVol;
                    Console.WriteLine("Too low volume - Amplifier volume set to minimum: " + minVol);
                }

                else if (value > maxVol)
                {
                    volume = maxVol;
                    Console.WriteLine("Too much volume - Amplifier volume set to to maximum: " + maxVol);
                }

            }
        }
        private int volume;

        public void ChangeVolume()
        {
            
            Console.Write("Give a new volume value (0-100) > ");
            int number = int.Parse(Console.ReadLine());
            //int number1 = System.Convert.ToInt32(Console.ReadLine());
            Volume = number;
            
        }
    }
}