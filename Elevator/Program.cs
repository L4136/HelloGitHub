﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            elevator hissi = new elevator();
            while (true)
            {
                hissi.ChangeFloor();
            }
            
        }
    }
}
