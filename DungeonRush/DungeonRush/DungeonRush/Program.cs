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
            Jatek();

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
            lassuKiirás("\tDungeon Rush The Videogame!", 0.2);
            Console.WriteLine();
            lassuKiirás("\tA játékos neve: ", 0.3);
            jelenlegiJatekos.Nev = Console.ReadLine();
            lassuKiirás("\tFelébredtél egy sötét bányában azzal a küldetéssel,\n\tlegyőzd az ördögöt és zárd vissza a pecsétjébe.", 0.1);
            lassuKiirás("\n\tAmint készen állsz nyomj meg egy billentyűt!", 0.2);
            Console.ReadKey();
            Console.Clear();
            lassuKiirás("\tMost lábra állsz és elindulsz a nehéz utadra", 0.1);
            Console.WriteLine();
        }
        static void Jatek()
        {

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
            while (true)
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
                Console.Clear();
            }
        }
    }
}

    

