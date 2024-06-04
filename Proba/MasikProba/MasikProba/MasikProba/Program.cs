using System;


class Program
{
    static void Main(string[] args)
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
                if (palyaegy[kockaY -= 1, kockaX] == 0)
                {
                    kockaY -= 1;
                }
                else
                {
                    Console.WriteLine("Neki mentél a falnak");
                }
            }
            else if (billentyu == 's')
            {
                if (palyaegy[kockaY += 1, kockaX] == 0)
                {
                    kockaY += 1;
                }
                else
                {
                    Console.WriteLine("Neki mentél a falnak");
                }
            }
            else if (billentyu == 'a')
            {
                if (palyaegy[kockaY, kockaX -= 1] == 0)
                {
                    kockaX -= 1;
                }
                else
                {
                    Console.WriteLine("Neki mentél a falnak");
                }
            }
            else if (billentyu == 'd')
            {
                if (palyaegy[kockaY, kockaX += 1] == 0)
                {
                    kockaX += 1;
                }
                else if (palyaegy[kockaY, kockaX += 1] == 1)
                {
                    kockaX -= 1;
                    Console.WriteLine("Neki mentél a falnak");
                }
                else if (palyaegy[kockaY, kockaX += 1] == 2)
                {
                    kockaX -= 1;
                    Console.WriteLine("Neki mentél a falnak");
                }
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

