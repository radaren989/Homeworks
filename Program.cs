using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_22_33
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] set1 = new int[31];
            int[] set2 = new int[31];
            int[] set3 = new int[31];
            int a = 0, b = 0, row = 0, column = 0, num = 0, score = 0;

            Console.WriteLine("+------------------------------+");
            Console.WriteLine(string.Format("| {0,30}", "|"));
            Console.WriteLine(string.Format("| {0,30}", "|"));
            Console.WriteLine(string.Format("| {0,30}", "|"));
            Console.WriteLine("+------------------------------+");

            Console.SetCursorPosition(34, 1);
            Console.Write("Score:{0}", score);

            for (int i = 0; i < 30; i++)
            {
                //booleans for loops
                bool flag1 = true, flag2 = false;
                while (flag1)
                {
                    //random integer generator. Computer is too fast therefore it generates same number over and over. 
                    //To prevent this loop checks whetherthe numbers are the same or not
                    while (a == row || b == column)
                    {
                        Random rnd = new Random();
                        row = rnd.Next(1, 4);
                        column = rnd.Next(1, 31);
                        num = rnd.Next(1, 4);
                    }
                    //Writes the number to selected row
                    switch (row)
                    {
                        //writes the number to selected column
                        case 1:
                            if (set1[column - 1] == 0)
                            {
                                set1[column - 1] = num;
                                flag2 = true;
                            }

                            break;
                        case 2:
                            if (set2[column - 1] == 0)
                            {
                                set2[column - 1] = num;
                                flag2 = true;
                            }
                            break;
                        case 3:
                            if (set3[column - 1] == 0)
                            {
                                set3[column - 1] = num;
                                flag2 = true;
                            }
                            break;
                    }
                    //Checks if the number at the right side is same for set 1
                    if (set1[column - 1] != 0 & set1[column - 1] == set1[column])
                    {
                        set1[column - 1] = 0;
                        score += 10;
                        flag1 = true;
                        flag2 = false;
                        Console.SetCursorPosition(34, 1);
                        Console.Write("Score:{0}", score);
                    }
                    //Checks if the number at the left side is same for set 1
                    else if (column - 2 >= 0 && (set1[column - 1] != 0 & set1[column - 1] == set1[column - 2]))
                    {
                        set1[column - 1] = 0;
                        flag1 = true;
                        flag2 = false;
                        score += 10;
                        Console.SetCursorPosition(34, 1);
                        Console.Write("Score:{0}", score);
                    }
                    //Checks if the number at the right side is same for set 2
                    else if (set2[column - 1] != 0 & set2[column - 1] == set2[column])
                    {
                        set2[column - 1] = 0;
                        score += 10;
                        flag1 = true;
                        flag2 = false;
                        Console.SetCursorPosition(34, 1);
                        Console.Write("Score:{0}", score);
                    }
                    //Checks if the number at the left side is same for set 2
                    else if (column - 2 >= 0 && (set2[column - 1] != 0 & set2[column - 1] == set2[column - 2]))
                    {
                        set2[column - 1] = 0;
                        score += 10;
                        flag1 = true;
                        flag2 = false;
                        Console.SetCursorPosition(34, 1);
                        Console.Write("Score:{0}", score);
                    }
                    //Checks if the number at the right side is same for set 3
                    else if (set3[column - 1] != 0 & set3[column - 1] == set3[column])
                    {
                        set1[column - 1] = 0;
                        score += 10;
                        flag1 = true;
                        flag2 = false;
                        Console.SetCursorPosition(34, 1);
                        Console.Write("Score:{0}", score);
                    }
                    //Checks if the number at the left side is same for set 3
                    else if (column - 2 >= 0 && (set3[column - 1] != 0 & set3[column - 1] == set3[column - 2]))
                    {
                        set3[column - 1] = 0;
                        score += 10;
                        flag1 = true;
                        flag2 = false;
                        Console.SetCursorPosition(34, 1);
                        Console.Write("Score:{0}", score);

                    }
                    //Checks if the number above set2 is the same
                    else if (set1[column - 1] != 0 & set2[column - 1] != 0 & set2[column - 1] == set1[column - 1])
                    {
                        set1[column - 1] = 0;
                        set2[column - 1] = 0;
                        score += 10;
                        flag1 = true;
                        flag2 = false;
                        Console.SetCursorPosition(34, 1);
                        Console.Write("Score:{0}", score);
                    }
                    //Checks if the number beneath set 2 is the same
                    else if (set3[column - 1] != 0 & set2[column - 1] != 0 & set2[column - 1] == set3[column - 1])
                    {
                        set3[column - 1] = 0;
                        set2[column - 1] = 0;
                        score += 10;
                        flag1 = true;
                        flag2 = false;
                        Console.SetCursorPosition(34, 1);
                        Console.Write("Score:{0}", score);
                    }
                    //Sets a and b for random number generator
                    a = row;
                    b = column;
                    //Prints numbers
                    if (flag2)
                    {
                        Console.SetCursorPosition(column, row);
                        Console.Write(num);
                        flag1 = false;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
