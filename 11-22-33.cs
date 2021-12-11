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
            int  row = 0, column = 0, num = 0, score = 0, x = 1, y = 1;
            Random rnd = new Random();
            ConsoleKeyInfo cki;

            Console.WriteLine("+------------------------------+");
            Console.WriteLine(string.Format("| {0,30}", "|"));
            Console.WriteLine(string.Format("| {0,30}", "|"));
            Console.WriteLine(string.Format("| {0,30}", "|"));
            Console.WriteLine("+------------------------------+");

            Console.SetCursorPosition(34, 1);
            Console.Write("Score:{0}", score);
            Console.SetCursorPosition(34, 3);
            Console.Write("Press Escape To Exit");

            //Filling the board
            for (int i = 0; i < 30;)
            {
                bool flag2 = false;
                row = rnd.Next(1, 4);
                column = rnd.Next(1, 31);
                num = rnd.Next(1, 4);

                switch (row)
                {
                    case 1:
                        if (set1[column - 1] == 0)
                        {
                            set1[column - 1] = num;
                            flag2 = true;
                            i++;
                        }
                        break;
                    case 2:
                        if (set2[column - 1] == 0)
                        {
                            set2[column - 1] = num;
                            flag2 = true;
                            i++;
                        }
                        break;
                    case 3:
                        if (set3[column - 1] == 0)
                        {
                            set3[column - 1] = num;
                            flag2 = true;
                            i++;
                        }
                        break;
                }
                if (set1[column - 1] != 0 && set1[column - 1] == set1[column])
                {
                    set1[column - 1] = 0;
                    set1[column] = 0;
                    Console.SetCursorPosition(column + 1, row);
                    Console.Write(" ");
                    Console.SetCursorPosition(column, row);
                    score += 10;
                    i -=2;
                    flag2 = false;
                    Console.SetCursorPosition(34, 1);
                    Console.Write("Score:{0}", score);
                }
                else if (column - 2 >= 0 && (set1[column - 1] != 0 && set1[column - 1] == set1[column - 2]))
                {
                    set1[column - 1] = 0;
                    set1[column - 2] = 0;
                    Console.SetCursorPosition(column - 1, row);
                    Console.Write(" ");
                    Console.SetCursorPosition(column, row);
                    i -= 2;
                    flag2 = false;
                    score += 10;
                    Console.SetCursorPosition(34, 1);
                    Console.Write("Score:{0}", score);
                }
                else if (set2[column - 1] != 0 && set2[column - 1] == set2[column])
                {
                    set2[column - 1] = 0;
                    set2[column] = 0;
                    Console.SetCursorPosition(column + 1, row);
                    Console.Write(" ");
                    Console.SetCursorPosition(column, row);
                    score += 10;
                    i -= 2;
                    flag2 = false;
                    Console.SetCursorPosition(34, 1);
                    Console.Write("Score:{0}", score);
                }
                else if (column - 2 >= 0 && (set2[column - 1] != 0 && set2[column - 1] == set2[column - 2]))
                {
                    set2[column - 1] = 0;
                    set2[column - 2] = 0;
                    Console.SetCursorPosition(column - 1, row);
                    Console.Write(" ");
                    Console.SetCursorPosition(column, row);
                    score += 10;
                    i -= 2;
                    flag2 = false;
                    Console.SetCursorPosition(34, 1);
                    Console.Write("Score:{0}", score);
                }
                else if (set3[column - 1] != 0 && set3[column - 1] == set3[column])
                {
                    set3[column - 1] = 0;
                    set3[column] = 0;
                    Console.SetCursorPosition(column + 1, row);
                    Console.Write(" ");
                    Console.SetCursorPosition(column, row);
                    score += 10;
                    i -= 2;
                    flag2 = false;
                    Console.SetCursorPosition(34, 1);
                    Console.Write("Score:{0}", score);
                }
                else if (column - 2 >= 0 && (set3[column - 1] != 0 && set3[column - 1] == set3[column - 2]))
                {
                    set3[column - 1] = 0;
                    set3[column - 2] = 0;
                    Console.SetCursorPosition(column - 1, row);
                    Console.Write(" ");
                    Console.SetCursorPosition(column, row);
                    score += 10;
                    i -= 2;
                    flag2 = false;
                    Console.SetCursorPosition(34, 1);
                    Console.Write("Score:{0}", score);

                }
                if (flag2)
                {
                    Console.SetCursorPosition(column, row);
                    Console.Write(num);
                }

            }
            Console.SetCursorPosition(x, y);
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    bool  flag2 = false;
                    int flag1 = 2;
                    cki = Console.ReadKey(true);
                    //W up
                    if ((cki.KeyChar == 87 || cki.KeyChar == 119) & y - 1 > 0)
                    {
                        switch (y)
                        {
                            case 2:
                                if ((set2[x - 1] != 0 && set1[x - 1] == 0))
                                {
                                    set1[x - 1] = set2[x - 1];
                                    set2[x - 1] = 0;
                                    Console.Write(" ");
                                    Console.SetCursorPosition(x, y - 1);
                                    Console.Write(set1[x - 1]);
                                    y--;
                                    Console.SetCursorPosition(x, y);
                                }
                                break;
                            case 3:
                                if (set3[x - 1] != 0 && set2[x - 1] == 0)
                                {
                                    set2[x - 1] = set3[x - 1];
                                    set3[x - 1] = 0;
                                    Console.Write(" ");
                                    Console.SetCursorPosition(x, y - 1);
                                    Console.Write(set2[x - 1]);
                                    y--;
                                    Console.SetCursorPosition(x, y);
                                }
                                break;
                        }
                    }
                    //S down
                    if ((cki.KeyChar == 83 || cki.KeyChar == 115) & y + 1 < 4)
                    {
                        switch (y)
                        {
                            case 1:
                                if ((set1[x - 1] != 0 && set2[x - 1] == 0))
                                {
                                    set2[x - 1] = set1[x - 1];
                                    set1[x - 1] = 0;
                                    Console.Write(" ");
                                    Console.SetCursorPosition(x, y + 1);
                                    Console.Write(set2[x - 1]);
                                    y++;
                                    Console.SetCursorPosition(x, y);
                                }
                                break;
                            case 2:
                                if (set2[x - 1] != 0 && set3[x - 1] == 0)
                                {
                                    set3[x - 1] = set2[x - 1];
                                    set2[x - 1] = 0;
                                    Console.Write(" ");
                                    Console.SetCursorPosition(x, y + 1);
                                    Console.Write(set3[x - 1]);
                                    y++;
                                    Console.SetCursorPosition(x, y);
                                }
                                break;
                        }
                    }
                    //A left
                    if ((cki.KeyChar == 65 || cki.KeyChar == 97) & x - 1 > 0)
                    {
                        bool flag = true;
                        while (flag)
                        {
                            switch (y)
                            {
                                case 1:
                                    if ((x != 1 && set1[x - 1] != 0 && set1[x - 2] == 0))
                                    {
                                        set1[x - 2] = set1[x - 1];
                                        set1[x - 1] = 0;
                                        Console.Write(" ");
                                        Console.SetCursorPosition(x - 1, y);
                                        Console.Write(set1[x - 2]);
                                        x--;
                                        Console.SetCursorPosition(x, y);
                                    }
                                    else
                                        flag = false;
                                    break;
                                case 2:
                                    if (x != 1 && set2[x - 1] != 0 && set2[x - 2] == 0)
                                    {
                                        set2[x - 2] = set2[x - 1];
                                        set2[x - 1] = 0;
                                        Console.Write(" ");
                                        Console.SetCursorPosition(x - 1, y);
                                        Console.Write(set2[x - 2]);
                                        x--;
                                        Console.SetCursorPosition(x, y);
                                    }
                                    else
                                        flag = false;
                                    break;
                                case 3:
                                    if (x != 1 && set3[x - 1] != 0 && set3[x - 2] == 0)
                                    {
                                        set3[x - 2] = set3[x - 1];
                                        set3[x - 1] = 0;
                                        Console.Write(" ");
                                        Console.SetCursorPosition(x - 1, y);
                                        Console.Write(set3[x - 2]);
                                        x--;
                                        Console.SetCursorPosition(x, y);
                                    }
                                    else
                                        flag = false;
                                    break;

                            }
                        }
                    }

                    //D right
                    if ((cki.KeyChar == 68 || cki.KeyChar == 100) & x + 1 < 31)
                    {
                        bool flag = true;
                        while (flag)
                        {
                            switch (y)
                            {
                                case 1:
                                    if (x != 30 &&(set1[x - 1] != 0 && set1[x] == 0))
                                    {
                                        set1[x] = set1[x - 1];
                                        set1[x - 1] = 0;
                                        Console.Write(" ");
                                        Console.SetCursorPosition(x + 1, y);
                                        Console.Write(set1[x]);
                                        x++;
                                        Console.SetCursorPosition(x, y);
                                    }
                                    else
                                        flag = false;
                                    break;
                                case 2:
                                    if (x != 30 && set2[x - 1] != 0 && set2[x] == 0)
                                    {
                                        set2[x] = set2[x - 1];
                                        set2[x - 1] = 0;
                                        Console.Write(" ");
                                        Console.SetCursorPosition(x + 1, y);
                                        Console.Write(set2[x]);
                                        x++;
                                        Console.SetCursorPosition(x, y);
                                    }
                                    else
                                        flag = false;
                                    break;
                                case 3:
                                    if (x != 30 && set3[x - 1] != 0 && set3[x] == 0)
                                    {
                                        set3[x] = set3[x - 1];
                                        set3[x - 1] = 0;
                                        Console.Write(" ");
                                        Console.SetCursorPosition(x + 1, y);
                                        Console.Write(set3[x]);
                                        x++;
                                        Console.SetCursorPosition(x, y);
                                    }
                                    else
                                        flag = false;
                                    break;
                            }
                        }
                    }
                    if(cki.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(1);
                    }
                    if (cki.Key == ConsoleKey.LeftArrow && x - 1 > 0)
                    {
                        x--;
                        Console.SetCursorPosition(x, y);
                    }
                    if (cki.Key == ConsoleKey.RightArrow && x + 1 < 31)
                    {
                        x++;
                        Console.SetCursorPosition(x, y);
                    }
                    if (cki.Key == ConsoleKey.UpArrow && y - 1 > 0)
                    {
                        y--;
                        Console.SetCursorPosition(x, y);
                    }
                    if (cki.Key == ConsoleKey.DownArrow && y + 1 < 4)
                    {
                        y++;
                        Console.SetCursorPosition(x, y);
                    }
                    switch (y)
                    {
                        case 1:
                            if (set1[x] != 0 && set1[x - 1] != 0 && set1[x - 1] == set1[x])
                            {
                                set1[x - 1] = 0;
                                set1[x] = 0;
                                Console.Write(" ");
                                Console.SetCursorPosition(x + 1, y);
                                Console.Write(" ");
                                Console.SetCursorPosition(34, 1);
                                score += 10;
                                Console.Write("Score:{0}", score);
                                Console.SetCursorPosition(x, y);
                                flag1 = 0;
                            }
                            if (x != 1 && set1[x - 1] != 0 && set1[x - 2] != 0 && set1[x - 1] == set1[x - 2])
                            {
                                set1[x - 1] = 0;
                                set1[x - 2] = 0;
                                Console.Write(" ");
                                Console.SetCursorPosition(x - 1, y);
                                Console.Write(" ");
                                Console.SetCursorPosition(34, 1);
                                score += 10;
                                Console.Write("Score:{0}", score);
                                Console.SetCursorPosition(x, y);
                                flag1 = 0;

                            }
                            break;
                        case 2:
                            if (set2[x] != 0 && set2[x - 1] != 0 && set2[x - 1] == set2[x])
                            {
                                set2[x - 1] = 0;
                                set2[x] = 0;
                                Console.Write(" ");
                                Console.SetCursorPosition(x + 1, y);
                                Console.Write(" ");
                                Console.SetCursorPosition(34, 1);
                                score += 10;
                                Console.Write("Score:{0}", score);
                                Console.SetCursorPosition(x, y);
                                flag1 = 0;
                            }
                            if (x != 1 && set2[x - 1] != 0 && set2[x - 2] != 0 && set2[x - 1] == set2[x - 2])
                            {
                                set2[x - 1] = 0;
                                set2[x - 2] = 0;
                                Console.Write(" ");
                                Console.SetCursorPosition(x - 1, y);
                                Console.Write(" ");
                                Console.SetCursorPosition(34, 1);
                                score += 10;
                                Console.Write("Score:{0}", score);
                                Console.SetCursorPosition(x, y);
                                flag1 = 0;

                            }
                            break;
                        case 3:
                            if (set3[x] != 0 && set3[x - 1] != 0 && set3[x - 1] == set3[x])
                            {
                                set3[x - 1] = 0;
                                set3[x] = 0;
                                Console.Write(" ");
                                Console.SetCursorPosition(x + 1, y);
                                Console.Write(" ");
                                Console.SetCursorPosition(34, 1);
                                score += 10;
                                Console.Write("Score:{0}", score);
                                Console.SetCursorPosition(x, y);
                                flag1 = 0;
                            }
                            if (x != 1 && set3[x - 1] != 0 && set3[x - 2] != 0 && set3[x - 1] == set3[x - 2])
                            {
                                set3[x - 1] = 0;
                                set3[x - 2] = 0;
                                Console.Write(" ");
                                Console.SetCursorPosition(x - 1, y);
                                Console.Write(" ");
                                Console.SetCursorPosition(34, 1);
                                score += 10;
                                Console.Write("Score:{0}", score);
                                Console.SetCursorPosition(x, y);
                                flag1 = 0;

                            }
                            break;
                    }
                    while (flag1 < 2)
                    {
                        row = rnd.Next(1, 4);
                        column = rnd.Next(1, 31);
                        num = rnd.Next(1, 4);

                        switch (row)
                        {
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
                        if (set1[column - 1] != 0 & set1[column - 1] == set1[column])
                        {
                            set1[column - 1] = 0;
                            set1[column] = 0;
                            Console.SetCursorPosition(column + 1, row);
                            Console.Write(" ");
                            Console.SetCursorPosition(column, row);
                            flag1--;
                            score += 10;
                            flag2 = false;
                            Console.SetCursorPosition(34, 1);
                            Console.Write("Score:{0}", score);
                        }
                        else if (column - 2 >= 0 && (set1[column - 1] != 0 & set1[column - 1] == set1[column - 2]))
                        {
                            set1[column - 1] = 0;
                            set1[column - 2] = 0;
                            Console.SetCursorPosition(column - 1, row);
                            Console.Write(" ");
                            Console.SetCursorPosition(column, row);
                            flag1--;
                            flag2 = false;
                            score += 10;
                            Console.SetCursorPosition(34, 1);
                            Console.Write("Score:{0}", score);
                        }
                        else if (set2[column - 1] != 0 & set2[column - 1] == set2[column])
                        {
                            set2[column - 1] = 0;
                            set2[column] = 0;
                            Console.SetCursorPosition(column + 1, row);
                            Console.Write(" ");
                            Console.SetCursorPosition(column, row);
                            flag1--;
                            score += 10;
                            flag2 = false;
                            Console.SetCursorPosition(34, 1);
                            Console.Write("Score:{0}", score);
                        }
                        else if (column - 2 >= 0 && (set2[column - 1] != 0 & set2[column - 1] == set2[column - 2]))
                        {
                            set2[column - 1] = 0;
                            set2[column - 2] = 0;
                            Console.SetCursorPosition(column - 1, row);
                            Console.Write(" ");
                            Console.SetCursorPosition(column, row);
                            flag1--;
                            score += 10;
                            flag2 = false;
                            Console.SetCursorPosition(34, 1);
                            Console.Write("Score:{0}", score);
                        }
                        else if (set3[column - 1] != 0 & set3[column - 1] == set3[column])
                        {
                            set3[column - 1] = 0;
                            set3[column] = 0;
                            Console.SetCursorPosition(column + 1, row);
                            Console.Write(" ");
                            Console.SetCursorPosition(column, row);
                            flag1--;
                            score += 10;
                            flag2 = false;
                            Console.SetCursorPosition(34, 1);
                            Console.Write("Score:{0}", score);
                        }
                        else if (column - 2 >= 0 && (set3[column - 1] != 0 & set3[column - 1] == set3[column - 2]))
                        {
                            set3[column - 1] = 0;
                            set3[column - 2] = 0;
                            Console.SetCursorPosition(column - 1, row);
                            Console.Write(" ");
                            Console.SetCursorPosition(column, row);
                            flag1--;
                            score += 10;
                            flag2 = false;
                            Console.SetCursorPosition(34, 1);
                            Console.Write("Score:{0}", score);

                        }
                        if (flag2)
                        {
                            Console.SetCursorPosition(column, row);
                            Console.Write(num);
                            Console.SetCursorPosition(x, y);
                            flag1 +=1;
                            flag2 = false;
                        }
                    }
                }
            }
        }
    }
}

