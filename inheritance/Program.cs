using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one Person object
            Person person = new Person();
            person.FirstName = "Kirsi";
            person.LastName = "Kernel";
            person.Address = "torikatu 1";
            person.Age = 30;
            person.PhoneNumber = "020-12345678";
            Console.WriteLine(person.ToString());

            // create a one Teacher Object
            Teacher teacher = new Teacher();
            teacher.FirstName = "Teppo";
            teacher.LastName = "Konsoli";
            teacher.Address = "piippukatu 2";
            teacher.Age = 40;
            teacher.PhoneNumber = "010-12345678";
            teacher.Room = "D100";
            Console.WriteLine(teacher.ToString());

            Teacher jani = new Teacher("Jani", "Immonen", "Unavailable");
            jani.Address = "Kuokkalan Silta 1";
            jani.Age = 24;
            Console.WriteLine(jani.ToString());

            // create a one Student object with parametric constuctor
            Student student = new Student("Minna", "Husso", "J9090");
            student.Address = "kilju 3";
            student.Age = 20;
            student.PhoneNumber = "040-12345678";
            Console.WriteLine(student.ToString());

            Person somebody = new Student("test", "testing", "ID");
           // somebody.StudentID = "ksldjf";
            Console.WriteLine(somebody.ToString());

            List<Person> people = new List<Person>();
            for (int i=0; i<20; i++)
            {
                if (i < 5)
                {
                    people.Add(new Person());
                }
                else if (i <12)
                {
                    people.Add(new Teacher());
                }
                else
                {
                    people.Add(new Student());
                }
            }
            foreach (Person personInPeople in people)
            {
                Console.WriteLine(personInPeople.ToString());
            }

            // do something methods
            person.PersonMethod(); // This method belongs to Person!
            teacher.PersonMethod(); // This method belongs to Person! (derived class can use it!)
            teacher.TeacherMethod(); // This method belongs to Teacher!
            student.PersonMethod(); // This method belongs to Person! (derived class can use it!)
            student.StudentMethod(); // This method belongs to Student!
        }
    }
}
