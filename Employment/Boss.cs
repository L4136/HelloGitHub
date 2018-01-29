using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employment
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        public void BossMethod()
        {
            Console.WriteLine("Boss:");
        }

        // return Person data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " Car: " + Car + " Bonus: " + Bonus ;
        }
    }
}
