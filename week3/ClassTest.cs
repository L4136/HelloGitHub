using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    class ClassTest
    {
        private string model;

        public string Model
        {
            get { return model; }
            set
            {
                if (value != "Toyota" && value != "Nissan")
                {
                    model = "There are no others than Toyota & Nissan";
                }
                else
                {
                    model = value;
                }
            }
        }

        public ClassTest()
        {
            model = "Nissan";
        }
    }
}
