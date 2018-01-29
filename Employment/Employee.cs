using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employment
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public void EmployeeMethod()
        {
            Console.WriteLine("Employee:");
        }

        // return Person data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return "- Name: "+ Name + " Profession: " + Profession + " Salary: " +Salary  ;
        }
    }
}
