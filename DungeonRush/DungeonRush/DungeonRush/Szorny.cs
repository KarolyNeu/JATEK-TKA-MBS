using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonRush
{
    class Szorny
    {
        public Szorny(string Nev, string Rajz, int Ero, int Elet) { 

            this.Nev = Nev;
            this.Rajz = Rajz;
            this.Ero = Ero;
            this.Elet = Elet;
    }
        public string Nev;
        public string Rajz;
        public int Ero { get; set; }
        public int Elet { get; set; }

}
}
