using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism
            Animal animal1 = new Dog();
            animal1.Talk(); // Wuw!
            Console.WriteLine("animal1 has {0} legs.", animal1.Legs); // animal1 has 4 legs.
            Console.WriteLine("animal1 type is {0}.", animal1.GetType()); // animal1 type is PolymorphismApplication.Dog

            // Polymorphism
            Animal animal2 = new Cat();
            animal2.Talk(); // Miaum!
            Console.WriteLine("animal2 has {0} legs.", animal2.Legs); // animal2 has 4 legs.
            Console.WriteLine("animal2 type is {0}.", animal2.GetType()); // animal2 type is PolymorphismApplication.Cat

            // Polymorphism
            Animal animal3 = new Chicken();
            animal3.Talk(); // CotCot!
            Console.WriteLine("animal3 has {0} legs.", animal3.Legs); // animal3 has 2 legs.
            Console.WriteLine("animal3 type is {0}.", animal3.GetType()); // animal3 type is PolymorphismApplication.Chicken

            // a lot of different animals in a list
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Rooster());
            animals.Add(new Chicken());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Chicken());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Chicken());
            animals.Add(new Rooster());
            // virtual method talk is invoked on each of the derived classes, not the base class. 
            foreach (Animal animal in animals)
            {
                // note we can handle this with one talk-method!
                animal.Talk();

                if (animal is Chicken)
                {
                    Console.WriteLine("This one is a chicken.");
                    Chicken chicken = animal as Chicken;
                    chicken.Talk();
                }
                //Console.WriteLine("ANIMAL IS: " + animal.GetType());
            }
        }
    }
}
