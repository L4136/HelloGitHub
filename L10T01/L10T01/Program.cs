using System;
using System.Collections.Generic;
using System.IO;  //tiedostojen käsittelyä varten
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class NamesToFile
    {
        static void Test()
        {
            
            try
            {
                string line;
                string myfile = @"D:\L4136\testi.txt";
                //luodaan tiedosto
                using (StreamWriter sw = new StreamWriter(myfile))
                {

                    //kysytään käyttäjältä nimet ja kirjoitetaan nimet tiedostoon
                    do
                    {
                        Console.WriteLine("Anna henkilön nimi (tyhjä lopettaa)");
                        line = Console.ReadLine();
                        if (line.Length > 0)
                            sw.WriteLine(line);
                    } while (line.Length > 0);
                    // sw.Close();  tätä ei tarvita, jos käyttää usingia.
                }
                //avataan tiedosto lukua varten 
                if (File.Exists(myfile))
                {

                    string txt = File.ReadAllText(myfile);

                    //näytetään nimet
                    Console.WriteLine("Tiedostossa {0} on nimet: \n{1}", myfile, txt);
                }
                else
                {
                    Console.WriteLine("Tiedostoa {0} ei löydy", myfile);
                }
               
            }
            catch (Exception)
            {

                throw;
            }
            

        }
        static void Main(string[] args)
        {
            try
            {
                Test();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
