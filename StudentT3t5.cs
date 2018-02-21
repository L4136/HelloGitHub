using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3t5
{
    class Student
    {
        public string Firstname { get; set; }
        public String Lastname { get; set; }
        public String StudentID { get; set; }
   
        public override string ToString()
        {
            return "Student:\nFirstname: " + Firstname + " Lastname: " + Lastname + " StudentID: " + StudentID ;
        }

    }
}
