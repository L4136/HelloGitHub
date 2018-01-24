using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amplifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahvistin vahvari = new Vahvistin();
            while (true)
            {
                vahvari.ChangeVolume();
            }

        }
    }
}
