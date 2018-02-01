using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyres
{
    public class Tyre 
    {
        public string name2;
        public string model2;
        public string size2;

        public Tyre(string name, string model, string size)
        {
            name2 = name;
            model2 = model;
            size2 = size;
        }
        public override string ToString()
        {
            return "Tyre name: " + name2 + " Model: " + model2 + " Size: " + size2+ "\n"; 
        }

    }
}
