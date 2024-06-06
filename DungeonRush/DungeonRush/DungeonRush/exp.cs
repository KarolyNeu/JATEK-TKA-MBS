//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DungeonRush
//{
//    public class exp
//    {
//        public void JatekElso()
//        {
//            bool harcvan = true;
//            bool jatekvege = true;
//            while (jatekvege = true) { 
//            string[,] matrix = new string[,]
//            {
//                {"║","═","═","═","═","═","═","═","═","═","═","║" },
//                {"║","X"," "," "," "," "," "," "," "," "," ","║" },
//                {"║"," "," "," "," "," "," "," "," "," "," ","║" },
//                {"║"," "," "," "," "," "," "," "," "," "," ","║" },
//                {"║"," "," "," "," "," "," "," "," "," "," ","║" },
//                {"║"," "," "," "," "," "," "," "," "," "," ","║" },
//                {"║"," "," "," "," "," "," "," "," "," "," ","║" },
//                {"║","═","═","═","═","═","═","═","═","═","═","║" }
//            };
//            int P_x = 1;
//            int P_y = 1;

//            void Print()
//            {
                
//                for (int i = 0; i < matrix.GetLength(0); i++)
//                {
//                    for (int j = 0; j < matrix.GetLength(1); j++)
//                    {
//                        Console.Write($"{matrix[i, j]}   ");
//                    }
//                    Console.WriteLine(Environment.NewLine + Environment.NewLine);
//                }
//            }

//            void Move(int x, int y)
//            {
//                int NewX = x + P_x;
//                int Newy = y + P_y;

//                if (matrix[NewX, Newy] == " "!)
//                {
//                    matrix[NewX, Newy] = "X";
//                    matrix[P_x, P_y] = " ";
//                    P_x = NewX;
//                    P_y = Newy;
//                }
//            }
//            ConsoleKeyInfo keyinfo;

//            while (true)
//            {
//                Print();
//                keyinfo = Console.ReadKey()!;

//                if (keyinfo.Key == ConsoleKey.W)
//                {
//                    Move(0, 1);
//                }
//                else if (keyinfo.Key == ConsoleKey.S)
//                {
//                    Move(0, -1);
//                }
//                else if (keyinfo.Key == ConsoleKey.A)
//                {
//                    Move(-1, 0);
//                }
//                else if (keyinfo.Key == ConsoleKey.D)
//                {
//                    Move(1, 0);
//                }
//            }
//        }
//        }
//    }
//}
