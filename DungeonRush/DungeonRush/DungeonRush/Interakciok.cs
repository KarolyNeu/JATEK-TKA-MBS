using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonRush
{
    class Interakciok
    {

        public static void Harc(bool random, string Nev, int Ero, int Elet)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {

            }
            else
            {
                n = Nev;
                p = Ero;
                h = Elet;
            }
            while (h > 0)
            {
                Console.WriteLine($"=====================");
                Console.WriteLine($"| (A)ttack (D)efend |");
                Console.WriteLine($"| (R)un    (H)eal   |");
                Console.WriteLine($"=====================");
            }
        }
        //Akció

    }
}
