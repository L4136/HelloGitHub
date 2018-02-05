using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // create persons collection
            Dictionary<string, Person> persons = new Dictionary<string, Person>();
            // create persons
            Person person1 = new Person { Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "010190-111A" };
            Person person2 = new Person { Firstname = "Matti", Lastname = "Husso", SocialSecurityNumber = "020292-222A" };
            Person person3 = new Person { Firstname = "Teppo", Lastname = "Vuolle", SocialSecurityNumber = "030393-333A" };
            // add persons to collection
            persons.Add(person1.SocialSecurityNumber, person1);
            persons.Add(person2.SocialSecurityNumber, person2);
            persons.Add(person3.SocialSecurityNumber, person3);
            // find person with key
            string ssn = "020292-222A";
            Person found;
            if (persons.TryGetValue(ssn, out found))
            {
                Console.WriteLine("Person with social security number {0} is {1}.", ssn, found.ToString());
                // output
                //  Person with social security number 020292-222A is Matti.
            }
            else
            {
                Console.WriteLine("Person with SSN {0} NOT FOUND", ssn);
            }

            // go through all keys
            foreach (string key in persons.Keys)
            {
                Console.WriteLine(key);
                // output
                //  010190-111A
                //  020292-222A
                //  030393-333A   
            }
            //go through all values
            foreach (Person person in persons.Values)
            {
                Console.WriteLine(person);
                // output
                //  Kirsi Mainio 010190-111A
                //  Matti Husso 020292-222A
                //  Teppo Vuolle 030393-333A
            }
            foreach (KeyValuePair<string, Person> kvp in persons)
            {
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
                // output
                //  010190-111A: Kirsi Mainio 010190-111A
                //  020292-222A: Matti Husso 020292-222A
                //  030393-333A: Teppo Vuolle 030393-333A
            }

            // remove object
            if (persons.ContainsKey(ssn))
            {
                persons.Remove(ssn);
            }

            // size
            Console.WriteLine("Collection size is {0}", persons.Count); // 2
        }

        /*{
        Queue<string> queue = new Queue<string>();
        // add values
        queue.Enqueue("first");
        queue.Enqueue("second");
        queue.Enqueue("third");
        // get first and leave it to collection
        string first = queue.Peek();
        Console.WriteLine("first in queue is {0}", first); // first
        Console.WriteLine("Count is {0}", queue.Count); // 3
                                                        // get first and remove it from collecion
        first = queue.Dequeue();
        Console.WriteLine("first in queue is {0}", first);  // first
        Console.WriteLine("Count is {0}", queue.Count); // 2
    }



        /*Stack<string> stackStrings = new Stack<string>();
        // add strings
        stackStrings.Push("first");
        stackStrings.Push("second");
        stackStrings.Push("third");

        Console.WriteLine(stackStrings.Peek()); //peek palauttaa viimeisenä lisätyn

        foreach (string s in stackStrings)
        {
            Console.WriteLine(s);
        }

        string temp = stackStrings.Pop();
        Console.WriteLine("Just popped: {0}", temp);
        Console.WriteLine("Stack count: {0}", stackStrings.Count);
    }


        /* var persons = new List<Person>();
        persons.Add(new Person { Firstname = "Jani", Lastname = " Hyyrynen", SocialSecurityNumber = "1234567" });
        persons.Add(new Person { Firstname = "Henna", Lastname = " Hyyrynen", SocialSecurityNumber = "9876543" });
        persons.Add(new Person { Firstname = "Tuija", Lastname = " Hyyrynen", SocialSecurityNumber = "2468013" });
        persons.Add(new Person { Firstname = "Jukka", Lastname = " Hyyrynen", SocialSecurityNumber = "1357924" });

        Console.WriteLine(persons.ElementAt(0).ToString());
        Console.WriteLine(persons[0].ToString());

        foreach (Person person in persons)
        {
            Console.WriteLine(person.ToString());
            if (person == persons.Last())
            {
                Console.WriteLine("LAST!");
            }
        }
        //persons.Sort((x, y) => x.Firstname.CompareTo(y.Firstname));
        persons.Sort();
        foreach (Person person in persons)
        {
            Console.WriteLine(person.ToString());
        }
    }


        /* {

        var names = new List<string>
        {
            "Anna", "Pekka", "Kimmo", "Daavetti"
        };

        //names.ForEach(name => Console.WriteLine($"Hello {name}")); //$ mahdollistaa muuttujien nimet lainausmerkkien sisällä ( vs. "Hello {0}" + name)
        names.ForEach(ShowInConsole);
    }

    private static void ShowInConsole(string txt)
    {
        Console.WriteLine(txt);
    }

    /*List < int > list = new List<int>();

    bool result = false;

    do
    {
        Console.WriteLine("Gimme a number");
        string line = Console.ReadLine();

        int number;
            result = int.TryParse(line, out number);
        if (result)
        {
            list.Add(number);
        }
    } while (result);

    for (int i = 0; i< list.Count; i++)
    {
        int number = list[i];
        if (i == list.Count - 1)
        {
            Console.Write(number + "\n");
        }
        else
        {
            Console.Write(number + ", ");
        }
        /*if (number == list.Last())   tää pätkä ei toimi oikein, tulostaa rivinvaihdon jos sama numero kuin viimeinen listalla
         * 
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.Write(number + ", ");
        }
    }
    int j = 0;
    foreach (int number in list)
    {
        if (++j == list.Count)
        {
            Console.Write(number + "\n");
        }
        else
        {
            Console.Write(number + ", ");
        }
    }
    Console.WriteLine("Average: {0}", list.Average());
    Console.WriteLine("Min: {0}", list.Min());
    Console.WriteLine("Max: {0}", list.Max());
    Console.WriteLine("Count: {0}", list.Count);

    list.Sort();
    list.ForEach(item => Console.Write(item + ", "));


}*/
        }
    }

