﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTank
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank panssarivaunu = new Tank();
            panssarivaunu.AccelerateTo(90);

            panssarivaunu.BrakeTo(1000);
            
        }
    }
}
