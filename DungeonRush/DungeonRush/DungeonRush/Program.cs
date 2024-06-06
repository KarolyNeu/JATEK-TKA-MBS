//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DungeonRush
//{
//    class Porgram
//    {
//        static void Main(string[] args)

//        {
//            JatekElso();
//        }
//            public void JatekElso()
//        {
//            bool harcvan = true;
//            bool jatekvege = true;
//            while (jatekvege = true)
//            {
//                string[,] matrix = new string[,]
//                {
//                {"║","═","═","═","═","═","═","═","═","═","═","║" },
//                {"║","X"," "," "," "," "," "," "," "," "," ","║" },
//                {"║"," "," "," "," "," "," "," "," "," "," ","║" },
//                {"║"," "," "," "," "," "," "," "," "," "," ","║" },
//                {"║"," "," "," "," "," "," "," "," "," "," ","║" },
//                {"║"," "," "," "," "," "," "," "," "," "," ","║" },
//                {"║"," "," "," "," "," "," "," "," "," "," ","║" },
//                {"║","═","═","═","═","═","═","═","═","═","═","║" }
//                };
//                int P_x = 1;
//                int P_y = 1;

//                void Print()
//                {

//                    for (int i = 0; i < matrix.GetLength(0); i++)
//                    {
//                        for (int j = 0; j < matrix.GetLength(1); j++)
//                        {
//                            Console.Write($"{matrix[i, j]}   ");
//                        }
//                        Console.WriteLine(Environment.NewLine + Environment.NewLine);
//                    }
//                }

//                void Move(int x, int y)
//                {
//                    int NewX = x + P_x;
//                    int Newy = y + P_y;

//                    if (matrix[NewX, Newy] == " "!)
//                    {
//                        matrix[NewX, Newy] = "X";
//                        matrix[P_x, P_y] = " ";
//                        P_x = NewX;
//                        P_y = Newy;
//                    }
//                }
//                ConsoleKeyInfo keyinfo;

//                while (true)
//                {
//                    Print();
//                    keyinfo = Console.ReadKey()!;

//                    if (keyinfo.Key == ConsoleKey.W)
//                    {
//                        Move(0, 1);
//                    }
//                    else if (keyinfo.Key == ConsoleKey.S)
//                    {
//                        Move(0, -1);
//                    }
//                    else if (keyinfo.Key == ConsoleKey.A)
//                    {
//                        Move(-1, 0);
//                    }
//                    else if (keyinfo.Key == ConsoleKey.D)
//                    {
//                        Move(1, 0);
//                    }
//                }
//            }
//        }
//    }
//}

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
        public static Szorny Zombi = new Szorny("Zombi", "[¬º -°]¬", 3, 15);

        public static int Elet { get; private set; }

        static void Main(string[] args)

        {
            Kezdes();
            JatekElso();
            EgyKetto();
            JatekMasodik();
            KettoHarom();
            JatekHarmadik();
            HaromNegy();
            Vegso();
            Vege();
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
            bool harcvan = false;
            bool jatekvege = true;

            int[,] palyaegy = new int[,] {
        { 1,2,2,2,2,2,2,2,2,2,1,2,2,2,2,2,2,2,2,2,1,2,2,2,1 },
        { 1,0,5,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,4 },
        { 1,2,2,2,2,2,2,0,0,0,1,0,0,0,2,2,2,2,2,2,1,0,0,0,4 },
        { 1,0,6,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,4 },
        { 1,0,0,0,1,2,2,2,2,0,0,0,2,2,2,2,1,0,0,0,1,2,2,2,1 },
        { 1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1 },
        { 1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,5,0,1 },
        { 1,2,2,2,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,2,2,2,1 }
                };

            int kockaX = 10;
            int kockaY = 6;
            Random random = new Random();
            int penzes = random.Next(1, 5);
            int hp = random.Next(1, 3);
            int zombitamadas = random.Next(1, Zombi.Ero);

            int jatekostamad = random.Next(1, jelenlegiJatekos.Ero);


            // Fő ciklus

            while (jatekvege && jelenlegiJatekos.Elet > 0)
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
                        else if (palyaegy[i, j] == 5)
                        {
                            Console.Write("*");
                        }
                        else if (palyaegy[i, j] == 6)
                        {
                            Console.Write("!");
                        }
                    }
                    Console.WriteLine();
                }



                Console.Write("Nyomj meg egy billentyűt (w, s, d, a): ");
                Console.WriteLine();
                Console.WriteLine($"A {jelenlegiJatekos.Nev}\nPénze: {jelenlegiJatekos.Penz}\nÉlete: {jelenlegiJatekos.Elet}");
                Console.WriteLine(palyaegy[kockaY, kockaX]);

                char billentyu = Console.ReadKey().KeyChar;
                Console.Clear();


                if (billentyu == 'w')
                {
                    if (palyaegy[kockaY - 1, kockaX] != 1 && palyaegy[kockaY - 1, kockaX] != 2)
                    {
                        kockaY -= 1;
                    }
                }
                else if (billentyu == 's')
                {
                    if (palyaegy[kockaY + 1, kockaX] != 1 && palyaegy[kockaY + 1, kockaX] != 2)
                    {
                        kockaY += 1;
                    }
                }
                else if (billentyu == 'a')
                {
                    if (palyaegy[kockaY, kockaX - 1] != 1 && palyaegy[kockaY, kockaX - 1] != 2)
                    {
                        kockaX -= 1;
                    }
                }
                else if (billentyu == 'd')
                {
                    if (palyaegy[kockaY, kockaX + 1] != 1 && palyaegy[kockaY, kockaX + 1] != 2)
                    {
                        kockaX += 1;
                    }
                }
                // Határok ellenőrzése

                if (palyaegy[kockaY, kockaX] == 4)
                {
                    jatekvege = false;
                }
                if (palyaegy[kockaY, kockaX] == 5)
                {
                    jelenlegiJatekos.Penz += penzes;
                    palyaegy[kockaY, kockaX] = 0;
                }

                if (palyaegy[kockaY, kockaX] == 6)
                {
                    harcvan = true;
                    while (harcvan == true)
                    {
                        if (jelenlegiJatekos.Elet > 0)
                        {


                            Console.WriteLine($"A szörny életereje: {Zombi.Elet}");
                            Console.WriteLine($"A szörny rajza: {Zombi.Rajz}");
                            Console.WriteLine();
                            Console.WriteLine($"=====================");
                            Console.WriteLine($"| (A)ttack (D)efend |");
                            Console.WriteLine($"| (R)un    (H)eal   |");
                            Console.WriteLine($"=====================");
                            Console.WriteLine();
                            Console.WriteLine($"A {jelenlegiJatekos.Nev} életereje: {jelenlegiJatekos.Elet}");
                            Console.Write("Nyomj meg egy billentyűt (a,d,r, h): ");
                            Console.WriteLine();
                            char megadas = Console.ReadKey().KeyChar;
                            if (megadas == 'a')
                            {
                                if (jatekostamad > 3)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(" Kritikus csapás!");

                                }
                                Zombi.Elet = Zombi.Elet - jatekostamad;
                                jelenlegiJatekos.Elet = jelenlegiJatekos.Elet - zombitamadas;
                                Console.WriteLine($"A szörny ennyit támadott: {zombitamadas}");

                                

                            }
                            else if (megadas == 'd')
                            {
                                Console.WriteLine("Kivédted a támadást!");
                            }
                            else if (megadas == 'r')
                            {
                                harcvan = false;
                            }
                            else if (megadas == 'h' && (jelenlegiJatekos.Elet + hp) <= 15)
                            {
                                jelenlegiJatekos.Elet += hp;
                                Console.WriteLine($"Ennyit healeltél: {hp}");
                            }

                        }
                        else
                        {
                            jatekvege = false;
                        }
                        if (Zombi.Elet < 0)
                        {
                            Console.WriteLine($"A játékos ennyi pénzt nyert el a harcból: {penzes}");
                            jelenlegiJatekos.Penz += penzes;
                            harcvan = false;
                            palyaegy[kockaY, kockaX] = 0;
                        }


                        Console.Clear();
                    }
                }
            }
        }

        static void EgyKetto()
            {

                lassuKiirás($"\tSikerült kijutnod az első pályáról gratulálok! {jelenlegiJatekos.Nev}", 0.1);
                Console.Clear();
                lassuKiirás($"\tDe a küldetésednek nincsen vége. \n\tMenj tovább és ne állj meg!", 0.1);
                lassuKiirás("\n\tAmint készen állsz nyomj meg egy billentyűt!", 0.1);
                Console.ReadKey();
                Console.Clear();
            }
        static void JatekMasodik()
            {
            bool harcvan = false;
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
            Random random = new Random();
            int penzes = random.Next(1, 5);
            int hp = random.Next(1, 3);
            int zombitamadas = random.Next(1, Zombi.Ero);

            int jatekostamad = random.Next(1, jelenlegiJatekos.Ero);


            // Fő ciklus

            while (jatekvege && jelenlegiJatekos.Elet > 0)
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
                        else if (palyaegy[i, j] == 5)
                        {
                            Console.Write("*");
                        }
                        else if (palyaegy[i, j] == 6)
                        {
                            Console.Write("!");
                        }
                    }
                    Console.WriteLine();
                }



                Console.Write("Nyomj meg egy billentyűt (w, s, d, a): ");
                Console.WriteLine();
                Console.WriteLine($"A {jelenlegiJatekos.Nev}\nPénze: {jelenlegiJatekos.Penz}\nÉlete: {jelenlegiJatekos.Elet}");
                Console.WriteLine(palyaegy[kockaY, kockaX]);

                char billentyu = Console.ReadKey().KeyChar;
                Console.Clear();


                if (billentyu == 'w')
                {
                    if (palyaegy[kockaY - 1, kockaX] != 1 && palyaegy[kockaY - 1, kockaX] != 2)
                    {
                        kockaY -= 1;
                    }
                }
                else if (billentyu == 's')
                {
                    if (palyaegy[kockaY + 1, kockaX] != 1 && palyaegy[kockaY + 1, kockaX] != 2)
                    {
                        kockaY += 1;
                    }
                }
                else if (billentyu == 'a')
                {
                    if (palyaegy[kockaY, kockaX - 1] != 1 && palyaegy[kockaY, kockaX - 1] != 2)
                    {
                        kockaX -= 1;
                    }
                }
                else if (billentyu == 'd')
                {
                    if (palyaegy[kockaY, kockaX + 1] != 1 && palyaegy[kockaY, kockaX + 1] != 2)
                    {
                        kockaX += 1;
                    }
                }
                // Határok ellenőrzése

                if (palyaegy[kockaY, kockaX] == 4)
                {
                    jatekvege = false;
                }
                if (palyaegy[kockaY, kockaX] == 5)
                {
                    jelenlegiJatekos.Penz += penzes;
                    palyaegy[kockaY, kockaX] = 0;
                }

                if (palyaegy[kockaY, kockaX] == 6)
                {
                    harcvan = true;
                    while (harcvan == true)
                    {
                        if (jelenlegiJatekos.Elet > 0)
                        {


                            Console.WriteLine($"A szörny életereje: {Zombi.Elet}");
                            Console.WriteLine($"A szörny rajza: {Zombi.Rajz}");
                            Console.WriteLine();
                            Console.WriteLine($"=====================");
                            Console.WriteLine($"| (A)ttack (D)efend |");
                            Console.WriteLine($"| (R)un    (H)eal   |");
                            Console.WriteLine($"=====================");
                            Console.WriteLine();
                            Console.WriteLine($"A {jelenlegiJatekos.Nev} életereje: {jelenlegiJatekos.Elet}");
                            Console.Write("Nyomj meg egy billentyűt (a,d,r, h): ");
                            Console.WriteLine();
                            char megadas = Console.ReadKey().KeyChar;
                            if (megadas == 'a')
                            {
                                if (jatekostamad > 3)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(" Kritikus csapás!");

                                }
                                Zombi.Elet = Zombi.Elet - jatekostamad;
                                jelenlegiJatekos.Elet = jelenlegiJatekos.Elet - zombitamadas;
                                Console.WriteLine($"A szörny ennyit támadott: {zombitamadas}");



                            }
                            else if (megadas == 'd')
                            {
                                Console.WriteLine("Kivédted a támadást!");
                            }
                            else if (megadas == 'r')
                            {
                                harcvan = false;
                            }
                            else if (megadas == 'h' && (jelenlegiJatekos.Elet + hp) <= 15)
                            {
                                jelenlegiJatekos.Elet += hp;
                                Console.WriteLine($"Ennyit healeltél: {hp}");
                            }

                        }
                        else
                        {
                            jatekvege = false;
                        }
                        if (Zombi.Elet < 0)
                        {
                            Console.WriteLine($"A játékos ennyi pénzt nyert el a harcból: {penzes}");
                            jelenlegiJatekos.Penz += penzes;
                            harcvan = false;
                            palyaegy[kockaY, kockaX] = 0;
                        }


                        Console.Clear();
                    }
                }
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
            bool harcvan = false;
            bool jatekvege = true;
                // Mátrix definiálása
                int[,] palyaegy = new int[,] {
        {1, 2, 2, 2, 2, 2, 1, 4, 4, 4, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1},
        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
        {1, 0, 0, 5, 2, 2, 1, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 0, 0, 0, 1, 2, 2, 0, 0, 0, 1},
        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1},
        {1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 2, 2, 1},
        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 6, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
        {1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1},
        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
        {1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 0, 0, 0, 2, 2, 2, 1}
                };

            int kockaX = 5;
            int kockaY = 8;

            // Fő ciklus
            Random random = new Random();
            int penzes = random.Next(1, 5);
            int hp = random.Next(1, 3);
            int zombitamadas = random.Next(1, Zombi.Ero);

            int jatekostamad = random.Next(1, jelenlegiJatekos.Ero);
            while (jatekvege && jelenlegiJatekos.Elet > 0)
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
                        else if (palyaegy[i, j] == 5)
                        {
                            Console.Write("*");
                        }
                        else if (palyaegy[i, j] == 6)
                        {
                            Console.Write("!");
                        }
                    }
                    Console.WriteLine();
                }



                Console.Write("Nyomj meg egy billentyűt (w, s, d, a): ");
                Console.WriteLine();
                Console.WriteLine($"A {jelenlegiJatekos.Nev}\nPénze: {jelenlegiJatekos.Penz}\nÉlete: {jelenlegiJatekos.Elet}");
                Console.WriteLine(palyaegy[kockaY, kockaX]);

                char billentyu = Console.ReadKey().KeyChar;
                Console.Clear();


                if (billentyu == 'w')
                {
                    if (palyaegy[kockaY - 1, kockaX] != 1 && palyaegy[kockaY - 1, kockaX] != 2)
                    {
                        kockaY -= 1;
                    }
                }
                else if (billentyu == 's')
                {
                    if (palyaegy[kockaY + 1, kockaX] != 1 && palyaegy[kockaY + 1, kockaX] != 2)
                    {
                        kockaY += 1;
                    }
                }
                else if (billentyu == 'a')
                {
                    if (palyaegy[kockaY, kockaX - 1] != 1 && palyaegy[kockaY, kockaX - 1] != 2)
                    {
                        kockaX -= 1;
                    }
                }
                else if (billentyu == 'd')
                {
                    if (palyaegy[kockaY, kockaX + 1] != 1 && palyaegy[kockaY, kockaX + 1] != 2)
                    {
                        kockaX += 1;
                    }
                }
                // Határok ellenőrzése

                if (palyaegy[kockaY, kockaX] == 4)
                {
                    jatekvege = false;
                }
                if (palyaegy[kockaY, kockaX] == 5)
                {
                    jelenlegiJatekos.Penz += penzes;
                    palyaegy[kockaY, kockaX] = 0;
                }

                if (palyaegy[kockaY, kockaX] == 6)
                {
                    harcvan = true;
                    while (harcvan == true)
                    {
                        if (jelenlegiJatekos.Elet > 0)
                        {


                            Console.WriteLine($"A szörny életereje: {Zombi.Elet}");
                            Console.WriteLine($"A szörny rajza: {Zombi.Rajz}");
                            Console.WriteLine();
                            Console.WriteLine($"=====================");
                            Console.WriteLine($"| (A)ttack (D)efend |");
                            Console.WriteLine($"| (R)un    (H)eal   |");
                            Console.WriteLine($"=====================");
                            Console.WriteLine();
                            Console.WriteLine($"A {jelenlegiJatekos.Nev} életereje: {jelenlegiJatekos.Elet}");
                            Console.Write("Nyomj meg egy billentyűt (a,d,r, h): ");
                            Console.WriteLine();
                            char megadas = Console.ReadKey().KeyChar;
                            if (megadas == 'a')
                            {
                                if (jatekostamad > 3)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(" Kritikus csapás!");

                                }
                                Zombi.Elet = Zombi.Elet - jatekostamad;
                                jelenlegiJatekos.Elet = jelenlegiJatekos.Elet - zombitamadas;
                                Console.WriteLine($"A szörny ennyit támadott: {zombitamadas}");



                            }
                            else if (megadas == 'd')
                            {
                                Console.WriteLine("Kivédted a támadást!");
                            }
                            else if (megadas == 'r')
                            {
                                harcvan = false;
                            }
                            else if (megadas == 'h' && (jelenlegiJatekos.Elet + hp) <= 15)
                            {
                                jelenlegiJatekos.Elet += hp;
                                Console.WriteLine($"Ennyit healeltél: {hp}");
                            }

                        }
                        else
                        {
                            jatekvege = false;
                        }
                        if (Zombi.Elet < 0)
                        {
                            Console.WriteLine($"A játékos ennyi pénzt nyert el a harcból: {penzes}");
                            jelenlegiJatekos.Penz += penzes;
                            harcvan = false;
                            palyaegy[kockaY, kockaX] = 0;
                        }


                        Console.Clear();
                    }
                }
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
        static void Vegso()
            {
                bool jatekvege = true;
                lassuKiirás($"\n\tA szörny életereje: {Zombi.Elet} és neve: {Zombi.Nev}!", 0.1);
                while (jatekvege)
                {
                    Console.WriteLine($"A szörny életereje: {Zombi.Elet}");
                    Console.WriteLine();
                    Console.WriteLine($"=====================");
                    Console.WriteLine($"| (A)ttack (D)efend |");
                    Console.WriteLine($"| (R)un    (H)eal   |");
                    Console.WriteLine($"=====================");
                    Console.WriteLine();
                    Console.Write("Nyomj meg egy billentyűt (a,d,r, h): ");
                    Console.WriteLine();
                    char megadas = Console.ReadKey().KeyChar;

                    if (megadas == 'a')
                    {
                        Random random = new Random();
                        int tamadas = random.Next(1, 4);
                        Zombi.Elet = Zombi.Elet - tamadas;
                        if (tamadas > 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Kritikus csapás!");
                        }

                    }
                    if (Zombi.Elet < 0)
                    {
                        jatekvege = false;
                    }
                }



            }
        static void Vege()
            {
                Console.WriteLine();
                lassuKiirás($"\tGratulálok {jelenlegiJatekos.Nev} a küldetésed sikeres volt!", 0.2);
                Console.Clear();
                lassuKiirás($"\n\tViszont egy olyan információ jár körül a legközelebbi faluban ,hogy egy démon uralkodik ott.", 0.1);
                lassuKiirás("\n\tEzért a küldetésed majd tovább folytatódik!", 0.1);
                Console.Clear();
                lassuKiirás("\n\tNyomj meg egy billentyűt", 0.2);
                Console.ReadKey();
                Console.Clear();
                lassuKiirás($"\n\tA játékot készítették: \n\tTóth Károly Attila,\n\tMeng Balázs Sándor", 0.2);
                lassuKiirás($"\n\tDungeon Rush The VideoGame", 0.2);
                lassuKiirás($"\n\tVége", 0.2);
            }

        }
    }





