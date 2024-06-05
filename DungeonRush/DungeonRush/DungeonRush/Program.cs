using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonRush
{
    class Program
    {
        public static Jatekos jelenlegiJatekos = new Jatekos();
        static void Main(string[] args)

        {
            Kezdes();
            JatekElso();
            EgyKetto();
            JatekMasodik();
            KettoHarom();
            JatekHarmadik();
            HaromNegy();
        }
        static void lassuKiirás(string szöveg, double szünetMásodperc)
        {
            for (int i = 0; i < szöveg.Length; i++)
            {
                Console.Write(szöveg[i]);
                Thread.Sleep((int)(szünetMásodperc * 1000));
            }
        }
        static void Kezdes()
        {
            lassuKiirás("\tDungeon Rush The Videogame!", 0.1);
            Console.WriteLine();
            lassuKiirás("\tAdja meg a játékos nevét: ", 0.1);
            jelenlegiJatekos.Nev = Console.ReadLine();
            lassuKiirás("\tFelébredtél egy sötét bányában azzal a küldetéssel,\n\tlegyőzd az ördögöt és zárd vissza a pecsétjébe.", 0.1);
            lassuKiirás("\n\tAmint készen állsz nyomj meg egy billentyűt!", 0.1);
            Console.ReadKey();
            Console.Clear();
            lassuKiirás("\tMost lábra állsz és elindulsz a nehéz utadra", 0.1);
            Console.WriteLine();
        }
        static void JatekElso()
        {
            bool jatekvege = true;
            // Mátrix definiálása
            int[,] palyaegy = new int[,] {
{ 1,2,2,2,2,2,2,2,2,2,1,2,2,2,2,2,2,2,2,2,1,0,0,0,1 },
{ 1,4,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,1 },
{ 1,2,2,2,2,2,2,0,0,0,1,0,0,0,2,2,2,2,2,2,1,0,0,0,1 },
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1 },
{ 1,0,0,0,1,2,2,2,2,0,0,0,2,2,2,2,1,0,0,0,1,0,0,0,1 },
{ 1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1 },
{ 1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,1 },
{ 1,2,2,2,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,2,2,2,1 }
        };

            // Kocka pozíciója
            int kockaX = 10;
            int kockaY = 6;

            // Fő ciklus
            while (jatekvege)
            {
                // Mátrix kiírása

                for (int i = 0; i < palyaegy.GetLength(0); i++)
                {
                    for (int j = 0; j < palyaegy.GetLength(1); j++)
                    {
                        if (i == kockaY && j == kockaX)
                        {
                            Console.Write("X"); // Kocka karaktere
                        }
                        else if (palyaegy[i, j] == 1)
                        {
                            Console.Write("║"); // Kocka karaktere
                        }
                        else if (palyaegy[i, j] == 2)
                        {
                            Console.Write("═");
                        }
                        else if (palyaegy[i, j] == 4)
                        {
                            Console.Write("+");
                        }
                        else if (palyaegy[i, j] == 0)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }



                Console.Write("Nyomj meg egy billentyűt (w, s, d, a): ");
                Console.WriteLine(palyaegy[kockaY, kockaX]);

                char billentyu = Console.ReadKey().KeyChar;
                Console.Clear();


                if (billentyu == 'w')
                {
                    kockaY -= 1;
                }
                else if (billentyu == 's')
                {
                    kockaY += 1;
                }
                else if (billentyu == 'a')
                {
                    kockaX -= 1;
                }
                else if (billentyu == 'd')
                {
                    kockaX += 1;
                }
                // Határok ellenőrzése
                if (kockaX < 0 || kockaX >= palyaegy.GetLength(1) ||
                kockaY < 0 || kockaY >= palyaegy.GetLength(0))
                {
                    Console.WriteLine("Határt túllépted!");
                    kockaX -= 10;
                    kockaY = 6;
                }
                if (palyaegy[kockaY, kockaX] == 4)
                {
                    jatekvege = false;
                }
                Console.Clear();
            }
        }
        static void EgyKetto() { 

        lassuKiirás($"\tSikerült kijutnod az első pályáról gratulálok! {jelenlegiJatekos.Nev}", 0.1);
        Console.Clear();
        lassuKiirás($"\tDe a küldetésednek nincsen vége. \n\tMenj tovább és ne állj meg!", 0.1);
        lassuKiirás("\n\tAmint készen állsz nyomj meg egy billentyűt!", 0.1);
        Console.ReadKey();
        Console.Clear();
        }
        static void JatekMasodik()
        {
            bool jatekvege = true;
            // Mátrix definiálása
            int[,] palyaegy = new int[,] {
            { 0, 1, 2, 2, 2, 2, 2, 2 , 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1 ,4 ,4, 4, 1 , 2, 2, 2, 2, 2, 1},
            { 0, 1, 0, 0, 0, 0, 0, 0 , 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0 ,0, 0, 0 , 0, 0, 0, 0, 0, 1},
            { 0, 1, 0, 0, 0, 2, 2, 1 , 0, 0, 0, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 2 ,0 ,0, 0, 1 , 2, 2, 0, 0, 0, 1},
            { 0, 1, 0, 0, 0, 0, 0, 1 , 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0 ,0, 0, 1 , 0, 0, 0, 0, 0, 1},
            { 0, 1, 2, 2, 0, 0, 0, 1 , 0, 0, 0, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1 ,0 ,0, 0, 1 , 0, 0, 0, 2, 2, 1},
            { 0, 1, 0, 0, 0, 0, 0, 0 , 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 ,0 ,0, 0, 0 , 0, 0, 0, 0, 0, 1},
            { 0, 1, 0, 0, 0, 2, 2, 2 , 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1 ,2 ,2, 2, 2 , 2, 2, 0, 0, 0, 1},
            { 0, 1, 0, 0, 0, 0, 0, 0 , 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0 ,0, 0, 0 , 0, 0, 0, 0, 0, 1},
            { 0, 1, 2, 2, 0, 0, 0, 2 , 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 ,2 ,2, 2, 2 , 2, 2, 2, 2, 2, 1}
        };


            // Kocka pozíciója
            int kockaX = 5;
            int kockaY = 8;

            // Fő ciklus
            while (jatekvege)
            {
                // Mátrix kiírása

                for (int i = 0; i < palyaegy.GetLength(0); i++)
                {
                    for (int j = 0; j < palyaegy.GetLength(1); j++)
                    {
                        if (i == kockaY && j == kockaX)
                        {
                            Console.Write("X"); // Kocka karaktere
                        }
                        else if (palyaegy[i, j] == 1)
                        {
                            Console.Write("║"); // Kocka karaktere
                        }
                        else if (palyaegy[i, j] == 2)
                        {
                            Console.Write("═");
                        }
                        else if (palyaegy[i, j] == 4)
                        {
                            Console.Write("+");
                        }
                        else if (palyaegy[i, j] == 0)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }



                Console.Write("Nyomj meg egy billentyűt (w, s, d, a): ");
                Console.WriteLine(palyaegy[kockaY, kockaX]);

                char billentyu = Console.ReadKey().KeyChar;
                Console.Clear();


                if (billentyu == 'w')
                {
                    kockaY -= 1;
                }
                else if (billentyu == 's')
                {
                    kockaY += 1;
                }
                else if (billentyu == 'a')
                {
                    kockaX -= 1;
                }
                else if (billentyu == 'd')
                {
                    kockaX += 1;
                }
                // Határok ellenőrzése
                if (kockaX < 0 || kockaX >= palyaegy.GetLength(1) ||
                kockaY < 0 || kockaY >= palyaegy.GetLength(0))
                {
                    Console.WriteLine("Határt túllépted!");
                    kockaX -= 10;
                    kockaY = 6;
                }
                if (palyaegy[kockaY, kockaX] == 4)
                {
                    jatekvege = false;
                }
                Console.Clear();
            }
        }
        static void KettoHarom()
        {

            lassuKiirás($"\tAhogy látom tényleg teljesíteni fogod a küldetésed!{jelenlegiJatekos.Nev}", 0.1);
            Console.Clear();
            lassuKiirás($"\n\tMenj tovább és ne állj meg!", 0.1);
            lassuKiirás("\n\tAmint készen állsz nyomj meg egy billentyűt!", 0.1);
            Console.ReadKey();
            Console.Clear();
        }
        static void JatekHarmadik()
        {
            bool jatekvege = true;
            // Mátrix definiálása
            int[,] palyaharom = new int[,] {
{1, 2, 2, 2, 2, 2, 1, 4, 4, 4, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1},
{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
{1, 0, 0, 0, 2, 2, 1, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 0, 0, 0, 1, 2, 2, 0, 0, 0, 1},
{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1},
{1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 2, 2, 1},
{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
{1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1},
{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
{1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 0, 0, 0, 2, 2, 2, 1}
        };


            // Kocka pozíciója
            int kockaX = 35;
            int kockaY = 8;

            // Fő ciklus
            while (jatekvege)
            {
                // Mátrix kiírása

                for (int i = 0; i < palyaharom.GetLength(0); i++)
                {
                    for (int j = 0; j < palyaharom.GetLength(1); j++)
                    {
                        if (i == kockaY && j == kockaX)
                        {
                            Console.Write("X"); // Kocka karaktere
                        }
                        else if (palyaharom[i, j] == 1)
                        {
                            Console.Write("║"); // Kocka karaktere
                        }
                        else if (palyaharom[i, j] == 2)
                        {
                            Console.Write("═");
                        }
                        else if (palyaharom[i, j] == 4)
                        {
                            Console.Write("+");
                        }
                        else if (palyaharom[i, j] == 0)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }



                Console.Write("Nyomj meg egy billentyűt (w, s, d, a): ");
                Console.WriteLine(palyaharom[kockaY, kockaX]);

                char billentyu = Console.ReadKey().KeyChar;
                Console.Clear();


                if (billentyu == 'w')
                {
                    kockaY -= 1;
                }
                else if (billentyu == 's')
                {
                    kockaY += 1;
                }
                else if (billentyu == 'a')
                {
                    kockaX -= 1;
                }
                else if (billentyu == 'd')
                {
                    kockaX += 1;
                }
                // Határok ellenőrzése
                if (kockaX < 0 || kockaX >= palyaharom.GetLength(1) ||
                kockaY < 0 || kockaY >= palyaharom.GetLength(0))
                {
                    Console.WriteLine("Határt túllépted!");
                    kockaX -= 10;
                    kockaY = 6;
                }
                if (palyaharom[kockaY, kockaX] == 4)
                {
                    jatekvege = false;
                }
                Console.Clear();
            }
        }
        static void HaromNegy()
        {

            lassuKiirás($"\tElértél a bánya végére az ÖRDÖG helyére. Innentől már nincsen vissza út.", 0.1);
            Console.Clear();
            lassuKiirás($"\n\tLe kell győznöd! {jelenlegiJatekos.Nev} Értetted?", 0.1);
            lassuKiirás("\n\tAmint készen állsz nyomj meg egy billentyűt!", 0.1);
            Console.ReadKey();
            Console.Clear();
        }
    }

}

    

