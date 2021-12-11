using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cengers
{
    class Program
    {
        
        static char[,] board = new char[8, 8];
        static void Main(string[] args)
        {
            int x = 8, y = 8,selx = 0, sely =0;
            ConsoleKeyInfo cki;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = '.';
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = 'O';
                }
            }
            for (int i = 7; i > 4; i--)
            {
                for (int j = 7; j > 4; j--)
                {
                    board[i, j] = 'X';
                }
            }
            Console.Write("  12345678 \n" +
                          " +--------+\n");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(i+1+"|");
                for (int j = 0; j < 8; j++)
                {
                    
                    Console.Write(board[i, j]);
                }
                Console.Write("|\n");
            }
            Console.Write(" +--------+\n");

            while (true)
            {
                Console.SetCursorPosition(x, y);
                if (Console.KeyAvailable)
                {
                    cki = Console.ReadKey(true);
                    switch (cki.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (x > 2)
                              x--;
                            break;
                        case ConsoleKey.RightArrow:
                            if (x < 9)
                                x++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (y > 2)
                                y--;
                            break;
                        case ConsoleKey.DownArrow:
                            if (y < 9)
                                y++;
                            break;
                        case ConsoleKey.Escape:
                            Environment.Exit(1);
                            break;
                        case ConsoleKey.Z:
                            if(board[x-2,y-2] == 'X')
                            {
                                selx = x - 2;
                                sely = y - 2;

                            }
                            break;
                        case ConsoleKey.X:
                            if(board[x-2,y-2] == '.' && board[selx,sely] == 'X' && (Math.Abs(selx - x) <2 ^  Math.Abs(sely - y)  < 2 ))
                            {
                                board[x - 2, y - 2] = 'X';
                                board[selx, sely] = '.';
                                Console.SetCursorPosition(selx +2, sely+2);
                                Console.Write(".");
                                Console.SetCursorPosition(x, y);
                                Console.Write("X");
                                selx = 0;
                                sely = 0;
                            }
                            break;
                        case ConsoleKey.C:

                            break;
                    }
                }
            }
            
            Console.ReadKey();
        }

    }
}

olur gi