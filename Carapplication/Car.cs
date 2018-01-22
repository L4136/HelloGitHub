using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carapplication
{
    class Car
    {
        private readonly int MaxSpeed = 200;
        public int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value <= MaxSpeed) speed = value;
                else speed = MaxSpeed;
            }
        }
    }
}
