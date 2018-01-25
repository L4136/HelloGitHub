using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Chicken : Animal
    {
        public override int Legs
        {
            get
            {
                return 2;
            }
        }

        public override void Talk() //jos overriden tilalla new, tekee animal-luokan metodin.
        {
            Console.WriteLine("CotCot!");
        }
    }
}
