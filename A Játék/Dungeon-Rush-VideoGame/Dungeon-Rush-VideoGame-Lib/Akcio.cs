﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Rush_VideoGame_Lib
{
    class Akcio
    {
        public static Jatekos jelenlegiJatekos = new Jatekos();
        static void Main(string[] args)
        {
            Kezdes();
        }
        
        static void Kezdes()
        {
            Console.WriteLine("Dungeon Rush The Videogame!");
            Console.WriteLine("A játékos neve: ");
            jelenlegiJatekos.Nev = Console.ReadLine();
            Console.WriteLine($"Felébredtél egy sötét bányában azzal a küldetéssel ,hogy legyőzd az ördögöt és zárd vissza a pecsétjébe.");
            Console.WriteLine("Amint készen állsz nyomj meg egy billentyűt!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Most lábra állsz és elindulsz nehéz utadra!");




        }
        //Interakció;
        //Console.WriteLine($"=====================");
        //Console.WriteLine($"| (A)ttack (D)efend |");
        //Console.WriteLine($"| (R)un    (H)eal   |");
        //Console.WriteLine($"=====================");
        //string action = Console.ReadLine();
    }
}
