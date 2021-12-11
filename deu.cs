using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEU
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list1 = new string[15];
            string[] list2 = new string[15];
            string[] list3 = new string[15];


            string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
            int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };
            int[] playerScore = { 120, 120 };

            string[] deustr = { "D", "E", "U" };

            //winner - the player whose turn, turn - turns, n - random array, a - last filled slot of the array 1, b - last filled slot of the array 2, c - last filled slot of the array 3
            int winner = 0, turn = 0, n = 0, a = 0, b = 0, c = 0;
            Random rnd = new Random();
            //flag1 is for the while loop, flag 2 is for decide whether it have to print or not
            bool flag2 = false ,flag1 = true;
            while (flag1)
            {
                string deu;
                //Randomly selects an array
                n = rnd.Next(1, 4);
                //Randomly selects "D", "E" or "U"
                deu = deustr[rnd.Next(3)];
                switch (n)
                {
                    case 1:
                        if (a < 14)
                        {
                            list1[a] = deu;
                            flag1 = Checker(list1, list2, list3, a, b, c, a, 1);
                            a++;
                            flag2 = true;
                        }
                        break;
                    case 2:
                        if (b < 14)
                        {
                            list2[b] = deu;
                            flag1 = Checker(list1, list2, list3, a, b, c, b, 2);
                            b++;
                            flag2 = true;
                        }
                        break;
                    case 3:
                        if (c < 14)
                        {
                            list3[c] = deu;
                            flag1 = Checker(list1, list2, list3, a, b, c, c, 3);
                            c++;
                            flag2 = true;
                        }
                        break;
                }
                //Prints the game if there is a new element in any array
                if (flag2)
                {
                    turn++;
                    winner = turn % 2;
                    if (winner == 0)
                        winner = 2;
                    //Updates players' scores
                    playerScore[winner - 1] -= 5;
                    Print(winner, list1, list2, list3, playerScore);
                    flag2 = false;
                }
                //Loop stops if arrays are full
                if (a == 14 && b == 14 && c == 14)
                {
                    //-1 means tie
                    winner = -1;
                    flag1 = false;
                }
            }

            switch (winner)
            {
                case -1:
                    Console.WriteLine("Tie");
                    Table(names, scores);
                    break;
                default:
                    Console.WriteLine("Winner : Player {0}", winner);
                    Table(names, scores, playerScore, winner);
                    break;
            }
            //Waits for input to exit
            Console.ReadKey();

        }
        static void Print(int winner, string[] list1, string[] list2, string[] list3, int[] score)
        {
            Console.WriteLine("Player {0}: (P1-{1} P2-{2})", winner, score[0], score[1]);
            Console.Write("A: ");
            for (int i = 0; i < list1.Length; i++)
            {
                Console.Write(list1[i]);
            }
            Console.Write("\nA: ");
            for (int i = 0; i < list2.Length; i++)
            {
                Console.Write(list2[i]);
            }
            Console.Write("\nA: ");
            for (int i = 0; i < list3.Length; i++)
            {
                Console.Write(list3[i]);
            }
            Console.Write("\n-----------------\n");
        }
        static void Table(string[] names, int[] scores, int[] playerScore = null, int winner = 0)
        {
            //If it is a tie, playerScore array passes as null, therefore it doesn't print players 
            Console.WriteLine("\nHIGH SCORE TABLE\n");
            Console.WriteLine(string.Format("{0,-20} {1,-5} ", "name", "Score"));
            Console.WriteLine("---------------------------");
            bool flag = true;
            for (int i = 0; i < scores.Length; i++)
            {
                //Prints winner if there is one
                if (playerScore != null && (scores[i] < playerScore[winner - 1] && flag))
                {
                    Console.WriteLine(string.Format("{0,-20} {1,-5} ", "Player" + winner, playerScore[winner - 1]));
                    Console.WriteLine(string.Format("{0,-20} {1,-5} ", names[i], scores[i]));
                    flag = false;
                }
                else if (i == scores.Length - 1 && (scores[i] > playerScore[winner - 1]))
                {
                    Console.WriteLine(string.Format("{0,-20} {1,-5} ", names[i], scores[i]));
                    Console.WriteLine(string.Format("{0,-20} {1,-5} ", "Player" + winner, playerScore[winner - 1]));
                }
                else
                    Console.WriteLine(string.Format("{0,-20} {1,-5} ", names[i], scores[i]));
            }
            Console.WriteLine("\nPress Enter To Exit");
        }
        static bool Checker(string[] list1, string[] list2, string[] list3, int a, int b, int c, int n, int m)
        {
            switch (m)
            {
                case 1:
                    //Straight or reverse on array 1
                    if (a  >= 2 && ((list1[a] == "U" && list1[a - 1] == "E" && list1[a - 2] == "D") || (list1[a ] == "D" && list1[a - 1] == "E" && list1[a - 2] == "U")))
                        return false;
                    //Top left to bottom right diagonal
                    else if ((b >= n + 1 && c >= n + 2) && ((list1[n] == "D" && list2[n + 1] == "E" && list3[n + 2] == "U") || (list1[n] == "U" && list2[n + 1] == "E" && list3[n + 2] == "D")))
                        return false;
                    //Top right to bottom left diagonal
                    else if ((n - 2 >= 0 && a != 0 && b != 0 && c != 0) && (c >= n - 2 && b >= n - 1) && ((list1[n] == "D" && list2[n - 1] == "E" && list3[n - 2] == "U") || (list1[n] == "U" && list2[n - 1] == "E" && list3[n - 2] == "D")))
                        return false;
                    break;
                case 2:
                    //Straight or reverse on array 2
                    if (b  >= 2 && ((list2[b ] == "U" && list2[b - 1] == "E" && list2[b - 2] == "D") || (list2[b ] == "D" && list2[b - 1] == "E" && list2[b - 2] == "U")))
                        return false;
                    //Top left to bottom right diagonal
                    else if ((n - 1 >= 0 && a != 0 && b != 0 && c != 0) && (a >= n - 1 && c >= n + 1) && ((list1[n - 1] == "D" && list2[n] == "E" && list3[n + 1] == "U") || (list1[n - 1] == "U" && list2[n] == "E" && list3[n + 1] == "D")))
                        return false;
                    //Top right to bottom left diagonal
                    else if ((n - 1 >= 0 && a != 0 && b != 0 && c != 0) && (c >= n - 1 && a >= n + 1) && ((list1[n + 1] == "D" && list2[n] == "E" && list3[n - 1] == "U") || (list1[n + 1] == "U" && list2[n] == "E" && list3[n - 1] == "D")))
                        return false;

                    break;
                case 3:
                    //Straight or reverse on array 2
                    if (c  >= 2 &&((list3[c ] == "U" && list3[c - 1] == "E" && list3[c - 2] == "D") || (list3[c] == "D" && list3[c - 1] == "E" && list3[c - 2] == "U")))
                        return false;
                    //Top left to bottom right diagonal
                    else if ((n - 2 >= 0  &&a != 0 && b != 0 && c != 0) && (a >= n - 2 && c >= n - 1) && ((list1[n - 2] == "D" && list2[n - 1] == "E" && list3[n] == "U") || (list1[n - 2] == "U" && list2[n - 1] == "E" && list3[n] == "D")))
                        return false;
                    //Top right to bottom left diagonal
                    else if ((b >= n + 1 && a >= n + 2) && ((list1[n + 2] == "D" && list2[n + 1] == "E" && list3[n] == "U") || (list1[n + 2] == "U" && list2[n + 1] == "E" && list3[n] == "D")))
                        return false;
                    break;
            }
            //Vertical deu
            if (a >= n && b >= n && c >= n && ((list1[n] == "D" && list2[n] == "E" && list3[n] == "U") || (list1[n] == "U" && list2[n] == "E" && list3[n] == "D")))
                return false;

            else
                return true;
        }
    }
}


