using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Rush_Lib
{
    public class Karakter
    {
        public string Nev { get; init; }
        public int Level { get; set; } = 1;
        public int XP { get; set; }
        public int XPKoviszint { get; set; } = 10;
        public int HP { get; set; } = 5;
        public int MaxHP => Level * 5;
        public int Arany { get; set; }
        public int Speed { get; set; } = 1;
        public int Damage { get; set; } = 1;
    }
}
