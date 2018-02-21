using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3t5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student { Firstname = "Alli", Lastname = "Alhainen", StudentID = "A1234"};
            students[1] = new Student { Firstname = "Bertta", Lastname = "Baratheon", StudentID = "B2345"};
            students[2] = new Student { Firstname = "Carl", Lastname = "Capulet", StudentID = "C3456"};

            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
                
            }


        }
    }
}
