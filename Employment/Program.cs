using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employment
{
    class Program
    {
            static void Main(string[] args)
            {
                // create a Person object
                Employee person = new Employee();
                person.Name = "Kirsi Kernel";
                person.Profession = "Teacher";
                person.Salary = 1200;
                person.EmployeeMethod();
                Console.WriteLine(person.ToString());

                // create a Boss Object
                Boss pomo = new Boss();
                pomo.Name = "Jussi Jurkka";
                pomo.Profession = "Head of Institute";
                pomo.Salary = 9000;
                pomo.Car = "Audi";
                pomo.Bonus = 5000;
                pomo.BossMethod();
                Console.WriteLine(pomo.ToString());
            }
    }
    
}
