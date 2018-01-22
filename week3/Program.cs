using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassTest test = new ClassTest();
            test.model = "Mercedes";
            Console.WriteLine(test.Model);
        }
    }
}


