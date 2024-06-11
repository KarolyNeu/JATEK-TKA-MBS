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
        public static Szorny Slime = new Szorny("Slime", "[o]", 1, 15);
        public static Szorny Zombi = new Szorny("Zombi", "[¬º _ °]¬", 2, 15);
        public static Szorny Trapchest = new Szorny("Trapchest", "[X]", 3, 30);
        public static Szorny Csonti = new Szorny("Csonti", "[|-_-|]", 3, 20);
        public static Szorny Vampir = new Szorny("Vampir", "[°|, ,|°]", 3, 30);
        public static Szorny BloodWarrior = new Szorny($"Blood Warrior", "[Q II /]", 4, 35);
        public static Szorny UndeadDragon = new Szorny("Undead Dragon", "<-()___---", 4, 50);
        public static Szorny Vexar = new Szorny("Vexar The Fear Devil", "(|- : * : -|)", 3, 75);

        public static int Elet { get; private set; }

        static void Main(string[] args)

        {
            Kezdes();
            Tutorial();
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
            Console.ForegroundColor= ConsoleColor.Green;
            lassuKiirás("\tDungeon Rush The Videogame!", 0.1);
            Console.WriteLine();
            lassuKiirás("\tAdja meg a játékos nevét: ", 0.1);
            jelenlegiJatekos.Nev = Console.ReadLine()!;
            lassuKiirás("\tFelébredtél egy sötét bányában azzal a küldetéssel ,hogy\n\tlegyőzd az ördögöt és zárd vissza a pecsétjébe.", 0.1);
            lassuKiirás("\n\tAmint készen állsz nyomj meg egy billentyűt!", 0.1);
            Console.ReadKey();
            Console.Clear();
            lassuKiirás("\tMost lábra állsz és elindulsz a nehéz utadra", 0.1);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Tutorial()
        {
            bool jatekvege = false;
            lassuKiirás("\n\tMég mielőtt elkezdenéd hosszú és nehéz utadat szeretnél vissza emlékezni az alapokra?( Tutorial )", 0.1);
            lassuKiirás("\n\t(i / n)", 0.1);
            char dontes = Console.ReadKey().KeyChar;
            if (dontes ==  'i')
            {
                jatekvege = true;
            }
            else
            {
                jatekvege = false;
            }
            lassuKiirás("\n\tKezdjük a pályával ez jel --> *   Az aranyt jelzi", 0.1);
            lassuKiirás("\n\tUtána ez a jel --> !   A szörnyeket jelzi", 0.1);
            lassuKiirás("\n\tÉs végső sorban ez a jel --> +   a kiutat jelzi a pályáról.", 0.1);
            lassuKiirás("\n\tTovább lapozhatunk?", 0.1);
            Console.ReadKey();
            Console.Clear();
            lassuKiirás("\tÉs ez lenne itt a harcrendszer:", 0.1);
            Console.WriteLine($"A szörny neve: {Slime.Nev}");
            Console.WriteLine($"A szörny életereje: {Slime.Elet}");
            Console.WriteLine($"A szörny rajza: {Slime.Rajz}");
            Console.WriteLine();
            Console.WriteLine($"=====================");
            Console.WriteLine($"| (A)ttack (D)efend |");
            Console.WriteLine($"| (R)un    (H)eal   |");
            Console.WriteLine($"=====================");
            Console.WriteLine();
            Console.WriteLine($"A {jelenlegiJatekos.Nev} életereje: {jelenlegiJatekos.Elet}");
            Console.Write("Nyomj meg egy billentyűt (a,d,r, h): ");

            Console.WriteLine($"Amint megvagy az elemzéssel készen állsz a játékra? Ha igen nyomj meg egy billentyűt!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            bool harcvan = false;
            int[,] palyaegy = new int[,] {
            {1,2,2,2,2,2,2,2,1},
            {1,0,0,0,0,0,0,0,1},
            {1,0,1,2,2,2,1,0,1},
            {1,0,1,0,4,0,1,0,1},
            {1,0,1,2,2,0,1,0,1},
            {1,0,0,6,0,0,1,0,1},
            {1,2,1,2,2,2,1,5,1},
            {1,5,0,0,0,0,0,0,1},
            {1,2,2,2,2,2,2,2,1}
            };
            int kockaX = 4;
            int kockaY = 7;
            Random random = new Random();
            int penzes = random.Next(1, 5);
            int hp = random.Next(1, 3);
            int slimetamadas = random.Next(1, Slime.Ero);

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
                    int korok = 0;
                    harcvan = true;
                    while (harcvan == true)
                    {
                        if (jelenlegiJatekos.Elet > 0)
                        {

                            Console.WriteLine($"A szörny neve: {Slime.Nev}");
                            Console.WriteLine($"A szörny életereje: {Slime.Elet}");
                            Console.WriteLine($"A szörny rajza: {Slime.Rajz}");
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
                                Slime.Elet = Slime.Elet - jatekostamad;
                                jelenlegiJatekos.Elet = jelenlegiJatekos.Elet - slimetamadas;
                                Console.WriteLine($"A szörny ennyit támadott: {slimetamadas}");
                                korok++;


                            }
                            else if (megadas == 'd')
                            {
                                Console.WriteLine("Kivédted a támadást!");
                                korok++;
                            }
                            else if (megadas == 'r')
                            {
                                harcvan = false;
                            }
                            else if (megadas == 'h' && (jelenlegiJatekos.Elet + hp) <= 15 && korok > 3)
                            {
                                jelenlegiJatekos.Elet += hp;
                                Console.WriteLine($"Ennyit healeltél: {hp}");
                                korok =- 3;
                            }

                        }
                        else
                        {
                            jatekvege = false;
                        }
                        if (Slime.Elet < 0)
                        {
                            Console.WriteLine($"A játékos ennyi pénzt nyert el a harcból: {penzes}");
                            jelenlegiJatekos.Penz += penzes;
                            harcvan = false;
                            palyaegy[kockaY, kockaX] = 0;
                            korok++;
                        }


                        Console.Clear();
                    }
                }
            }
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
        { 1,2,2,2,1,2,2,2,2,2,2,2,2,2,2,2,1,2,2,2,1,2,2,2,1 }
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
                    int korok = 0;
                    harcvan = true;
                    while (harcvan == true)
                    {
                        if (jelenlegiJatekos.Elet > 0)
                        {

                            Console.WriteLine($"A szörny neve: {Zombi.Nev}");
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
                                korok++;
                                

                            }
                            else if (megadas == 'd')
                            {
                                Console.WriteLine("Kivédted a támadást!");
                                korok++;
                            }
                            else if (megadas == 'r')
                            {
                                harcvan = false;
                                korok++;
                            }
                            else if (megadas == 'h' && (jelenlegiJatekos.Elet + hp) <= 15 && korok > 3)
                            {
                                jelenlegiJatekos.Elet += hp;
                                Console.WriteLine($"Ennyit healeltél: {hp}");
                                korok -= 3;
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
                    { 0, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1 ,4 ,4, 4, 1 , 2, 2, 2, 2, 2, 1},
                    { 0, 1, 0, 0, 0, 0, 5, 1, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 5, 0, 0, 1 ,0 ,0, 0, 0 , 0, 6, 0, 5, 0, 1},
                    { 0, 1, 0, 0, 0, 2, 2, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 2 ,2 ,2, 2, 1 , 2, 2, 0, 0, 0, 1},
                    { 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0 ,0, 0, 1 , 0, 0, 0, 0, 0, 1},
                    { 0, 1, 2, 2, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1 ,0 ,0, 0, 1 , 0, 5, 0, 2, 2, 1},
                    { 0, 1, 0, 5, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 5, 0, 0, 0, 0, 0, 0, 0, 0, 1 ,0 ,0, 0, 0 , 0, 0, 0, 0, 0, 1},
                    { 0, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 5, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1 ,2 ,2, 2, 2 , 2, 2, 0, 0, 0, 1},
                    { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 0, 0 ,0 ,0, 0, 0 , 0, 0, 0, 0, 0, 1},
                    { 0, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 ,2 ,2, 2, 2 , 2, 2, 2, 2, 2, 1}
                };


                // Kocka pozíciója
                int kockaX = 4;
                int kockaY = 7;

            // Fő ciklus
            Random random = new Random();
            int penzes = random.Next(1, 5);
            int hp = random.Next(1, 4);
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
                        else if (palyaegy[i, j] == 7)
                        {
                            Console.Write("!");
                        }
                    }
                    Console.WriteLine();
                }



                Console.Write("Nyomj meg egy billentyűt (w, s, d, a): ");
                Console.WriteLine();
                Console.WriteLine($"A {jelenlegiJatekos.Nev}\nPénze: {jelenlegiJatekos.Penz}\nÉlete: {jelenlegiJatekos.Elet}");

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
                            int korok = 0;
                    harcvan = true;
                    while (harcvan == true)
                    {
                        if (jelenlegiJatekos.Elet > 0)
                        {

                            Console.WriteLine($"A szörny neve: {Csonti.Nev}");
                            Console.WriteLine($"A szörny életereje: {Csonti.Elet}");
                            Console.WriteLine($"A szörny rajza: {Csonti.Rajz}");
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
                                Csonti.Elet = Csonti.Elet - jatekostamad;
                                jelenlegiJatekos.Elet = jelenlegiJatekos.Elet - zombitamadas;
                                Console.WriteLine($"A szörny ennyit támadott: {zombitamadas}");
                                korok++;


                            }
                            else if (megadas == 'd')
                            {
                                Console.WriteLine("Kivédted a támadást!");
                                korok++;
                            }
                            else if (megadas == 'r')
                            {
                                harcvan = false;
                                korok++;
                            }
                            else if (megadas == 'h' && (jelenlegiJatekos.Elet + hp) <= 20 && korok > 3)
                            {
                                jelenlegiJatekos.Elet += hp;
                                Console.WriteLine($"Ennyit healeltél: {hp}");
                                korok -= 3;
                            }

                        }
                        else
                        {
                            jatekvege = false;
                        }
                        if (Csonti.Elet < 0)
                        {
                            Console.WriteLine($"A játékos ennyi pénzt nyert el a harcból: {penzes}");
                            jelenlegiJatekos.Penz += penzes;
                            harcvan = false;
                            palyaegy[kockaY, kockaX] = 0;
                            jelenlegiJatekos.Ero += 1;
                        }


                        Console.Clear();
                    }
                }
                if (palyaegy[kockaY, kockaX] == 7)
                {
                            int korok = 0;
                    harcvan = true;
                    while (harcvan == true)
                    {
                        if (jelenlegiJatekos.Elet > 0)
                        {
                            Console.WriteLine($"A szörny neve: {Trapchest.Nev}");
                            Console.WriteLine($"A szörny életereje: {Trapchest.Elet}");
                            Console.WriteLine($"A szörny rajza: {Trapchest.Rajz}");
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
                                Trapchest.Elet = Trapchest.Elet - jatekostamad;
                                jelenlegiJatekos.Elet = jelenlegiJatekos.Elet - zombitamadas;
                                Console.WriteLine($"A szörny ennyit támadott: {zombitamadas}");
                                korok++;


                            }
                            else if (megadas == 'd')
                            {
                                Console.WriteLine("Kivédted a támadást!");
                                korok++;
                            }
                            else if (megadas == 'r')
                            {
                                harcvan = false;
                                korok++;
                            }
                            else if (megadas == 'h' && (jelenlegiJatekos.Elet + hp) <= 15 && korok > 3)
                            {
                                jelenlegiJatekos.Elet += hp;
                                Console.WriteLine($"Ennyit healeltél: {hp}");
                                korok -= 3;
                            }

                        }
                        else
                        {
                            jatekvege = false;
                        }
                        if (Trapchest.Elet < 0)
                        {
                            Console.WriteLine($"A játékos ennyi pénzt nyert el a harcból: {penzes}");
                            jelenlegiJatekos.Penz += penzes;
                            harcvan = false;
                            palyaegy[kockaY, kockaX] = 0;
                            jelenlegiJatekos.Ero += 1;
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
        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 5, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 5, 0, 0, 0, 1},
        {1, 0, 0, 5, 2, 2, 1, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 0, 0, 0, 1, 2, 2, 0, 0, 0, 1},
        {1, 0, 0, 0, 0, 7, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1},
        {1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 2, 2, 1},
        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 6, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
        {1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 1},
        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
        {1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1}
                };

            int kockaX = 38;
            int kockaY = 7;

            // Fő ciklus
            Random random = new Random();
            int penzes = random.Next(1, 5);
            int hp = random.Next(1, 5);
            int zombitamadas = random.Next(1, Vampir.Ero);

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
                        else if (palyaegy[i, j] == 7)
                        {
                            Console.Write("!");
                        }
                    }
                    Console.WriteLine();
                }



                Console.Write("Nyomj meg egy billentyűt (w, s, d, a): ");
                Console.WriteLine();
                Console.WriteLine($"A {jelenlegiJatekos.Nev}\nPénze: {jelenlegiJatekos.Penz}\nÉlete: {jelenlegiJatekos.Elet}");

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
                            int korok = 0;
                    harcvan = true;
                    while (harcvan == true)
                    {
                        if (jelenlegiJatekos.Elet > 0)
                        {
                            Console.WriteLine($"A szörny neve: {Vampir.Nev}");
                            Console.WriteLine($"A szörny életereje: {Vampir.Elet}");
                            Console.WriteLine($"A szörny rajza: {Vampir.Rajz}");
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
                                Vampir.Elet = Vampir.Elet - jatekostamad;
                                jelenlegiJatekos.Elet = jelenlegiJatekos.Elet - zombitamadas;
                                Console.WriteLine($"A szörny ennyit támadott: {zombitamadas}");
                                korok++;


                            }
                            else if (megadas == 'd')
                            {
                                Console.WriteLine("Kivédted a támadást!");
                                korok++;

                            }
                            else if (megadas == 'r')
                            {
                                harcvan = false;
                            }
                            else if (megadas == 'h' && (jelenlegiJatekos.Elet + hp) <= 30 && korok > 3) 
                            {
                                jelenlegiJatekos.Elet += hp;
                                Console.WriteLine($"Ennyit healeltél: {hp}");
                                korok -= 3;
                            }

                        }
                        else
                        {
                            jatekvege = false;
                        }
                        if (Vampir.Elet <= 0)
                        {
                            Console.WriteLine($"A játékos ennyi pénzt nyert el a harcból: {penzes}");
                            jelenlegiJatekos.Penz += penzes;
                            palyaegy[kockaY, kockaX] = 0;
                            jelenlegiJatekos.Ero += 1;
                            harcvan = false;
                        }


                        Console.Clear();
                    }
                }
                if (palyaegy[kockaY, kockaX] == 7)
                {
                            int korok = 0;
                    harcvan = true;
                    while (harcvan == true)
                    {
                        if (jelenlegiJatekos.Elet > 0)
                        {
                            Console.WriteLine($"A szörny neve: {BloodWarrior.Nev}");
                            Console.WriteLine($"A szörny életereje: {BloodWarrior.Elet}");
                            Console.WriteLine($"A szörny rajza: {BloodWarrior.Rajz}");
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
                                BloodWarrior.Elet = BloodWarrior.Elet - jatekostamad;
                                jelenlegiJatekos.Elet = jelenlegiJatekos.Elet - zombitamadas;
                                Console.WriteLine($"A szörny ennyit támadott: {zombitamadas}");
                                korok++;


                            }
                            else if (megadas == 'd')
                            {
                                Console.WriteLine("Kivédted a támadást!");
                                korok++;
                            }
                            else if (megadas == 'r')
                            {
                                harcvan = false;
                                korok++;
                            }
                            else if (megadas == 'h' && (jelenlegiJatekos.Elet + hp) <= 30 && korok > 3)
                            {
                                jelenlegiJatekos.Elet += hp;
                                Console.WriteLine($"Ennyit healeltél: {hp}");
                                korok =- 3;
                            }

                        }
                        else
                        {
                            jatekvege = false;
                        }
                        if (BloodWarrior.Elet < 0)
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
                 Random random = new Random();
                 int penzes = random.Next(1, 5);
                 int hp = random.Next(1, 7);
                 int zombitamadas = random.Next(1, Vexar.Ero);

                int jatekostamad = random.Next(1, jelenlegiJatekos.Ero);
                bool jatekvege = true;
            int korok = 0;
                lassuKiirás($"\n\tA szörny életereje: {Vexar.Elet} és neve: {Vexar.Nev}!", 0.1);
                while (jatekvege)
                {
                    Console.WriteLine($"A szörny neve: {Vexar.Nev} életereje: {Vexar.Elet}");
                    Console.WriteLine($"A szörny rajza: {Vexar.Rajz}");
                Console.WriteLine();
                    Console.WriteLine($"=====================");
                    Console.WriteLine($"| (A)ttack (D)efend |");
                    Console.WriteLine($"| (B)ow  (H)eal     |");
                    Console.WriteLine($"=====================");
                    Console.WriteLine();
                    Console.WriteLine($"A {jelenlegiJatekos.Nev} életereje: {jelenlegiJatekos.Elet}");
                    Console.Write("Nyomj meg egy billentyűt (a,d,r, h): ");
                    Console.WriteLine();
                    char megadas = Console.ReadKey().KeyChar;

                if (megadas == 'a')
                {
                    if (jatekostamad > 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Kritikus csapás!");
                    }
                    Vexar.Elet = Vexar.Elet - jatekostamad;
                    jelenlegiJatekos.Elet = jelenlegiJatekos.Elet - zombitamadas;
                    Console.WriteLine($"A szörny ennyit támadott: {zombitamadas}");
                    korok++;


                }
                if (megadas == 'b')
                {
                    if ((jatekostamad*2) > 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Kritikus csapás!");

                    }
                    Vexar.Elet = Vexar.Elet - (jatekostamad * 2);
                    jelenlegiJatekos.Elet = jelenlegiJatekos.Elet - zombitamadas;
                    Console.WriteLine($"A szörny ennyit támadott: {zombitamadas}");
                    korok++;


                }
                else if (megadas == 'd')
                {
                    Console.WriteLine("Kivédted a támadást!");
                    korok++;
                }
                else if (megadas == 'h' && (jelenlegiJatekos.Elet + hp) <= 35 && korok > 3)
                {
                    jelenlegiJatekos.Elet += hp;
                    Console.WriteLine($"Ennyit healeltél: {hp}");
                    korok-=3;
                }
                if (Vexar.Elet < 0)
                    {
                        jatekvege = false;
                    }

                }



            }
        static void Vege()
            {
                Console.WriteLine();
                lassuKiirás($"\tGratulálok {jelenlegiJatekos.Nev} a küldetésed sikeres volt ennyi aranyat szedtél össze: {jelenlegiJatekos.Penz}!", 0.2);
                Console.Clear();
                lassuKiirás($"\n\tViszont egy olyan információ jár körül a legközelebbi faluban ,hogy egy démon uralkodik ott.", 0.1);
                lassuKiirás("\n\tEzért a küldetésed majd tovább folytatódik!", 0.1);
                Console.Clear();
                lassuKiirás("\n\tNyomj meg egy billentyűt", 0.2);
                Console.ReadKey();
                Console.Clear();
                lassuKiirás($"\n\tA játékot készítették: \n\tTóth Károly Attila,\n\tMeng Balázs Sándor", 0.2);
                lassuKiirás($"\n\tDungeon Rush The VideoGame", 0.2);
            Console.Clear();
                lassuKiirás($"\n\tVége", 0.2);
            Console.ReadKey();
            }

        }
    }





