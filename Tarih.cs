using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarih
{
    class Program
    {
        static void Main(string[] args)
        {
            //nm1 and nm2 is the numerical values of the months (jan is 1 and dec is 12)
            //pm1 and pm2 is the special values of the months. It is required by the algorithm
            //daynum is numerical value of the day of the weeks (sunday is 0 and saturday is 6)
            //seasons boolean is determines whether printing the season is required or not
            int d1 = 0, d2 = 0, y1 = 0, y2 = 0, n = 0, nm1 = 0, nm2 = 0, pm1 = 0, pm2 = 0, daynum;
            string m1 = "", m2 = "", stringday = "";
            bool seasons = true;

            //date 1
            bool flag1 = true;
            while (flag1)
            {
                //Day of the 1st date
                Console.Write("D1: ");
                //Checks whether input is valid or not
                string sd1 = Console.ReadLine();
                if (!int.TryParse(sd1, out d1))
                {
                    while (!int.TryParse(sd1, out d1))
                    {
                        Console.WriteLine("This is not a number!");
                        Console.Write("D1:");
                        sd1 = Console.ReadLine();
                    }
                }
                //Month of the 1st date
                bool m1flag = true;
                //Checks whether input is valid or not
                while (m1flag)
                {
                    Console.Write("M1: ");
                    m1 = Console.ReadLine();
                    bool result = m1.All(Char.IsLetter);
                    if (result == true & m1 != "")
                    {
                        m1flag = false;
                    }
                    else
                        Console.WriteLine("This is not a month");
                }
                m1 = m1.ToLower();
                //Year of the 1st date
                Console.Write("Y1: ");
                //Checks whether input is valid or not
                string sy1 = Console.ReadLine();
                if (!int.TryParse(sy1, out y1))
                {
                    while (!int.TryParse(sy1, out y1))
                    {
                        Console.WriteLine("This is not a number!");
                        Console.Write("Y1:");
                        sy1 = Console.ReadLine();
                    }
                }

                //Checks whether the date is valid or not
                if (y1 < 2015)
                {
                    Console.WriteLine("Wrong date!");
                }
                else if (m1 != "january" & m1 != "march" & m1 != "may" & m1 != "july" & m1 != "august" & m1 != "october" & m1 != "december" &
                    m1 != "april" & m1 != "june" & m1 != "september" & m1 != "november" & m1 != "february")
                {
                    Console.WriteLine("Wrong date!");
                }
                else if (m1 == "january" | m1 == "march" | m1 == "may" | m1 == "july" | m1 == "august" | m1 == "october" | m1 == "december")
                {
                    if (d1 < 1 | d1 > 31)
                    {
                        Console.WriteLine("Wrong date!");
                    }
                    else
                    {
                        flag1 = false;
                    }
                    switch (m1)
                    {
                        case "january":
                            pm1 = 1;
                            nm1 = 0;
                            break;
                        case "march":
                            pm1 = 3;
                            nm1 = 3;
                            break;
                        case "may":
                            pm1 = 5;
                            nm1 = 1;
                            break;
                        case "july":
                            pm1 = 7;
                            nm1 = 6;
                            break;
                        case "august":
                            pm1 = 8;
                            nm1 = 2;
                            break;
                        case "october":
                            pm1 = 10;
                            nm1 = 0;
                            break;
                        case "december":
                            pm1 = 12;
                            nm1 = 5;
                            break;
                    }

                }
                else if (m1 == "april" | m1 == "june" | m1 == "september" | m1 == "november")
                {
                    if (d1 < 1 | d1 > 30)
                    {
                        Console.WriteLine("Wrong date!");
                    }
                    else
                    {
                        flag1 = false;
                    }

                    switch (m1)
                    {
                        case "april":
                            pm1 = 4;
                            nm1 = 6;
                            break;
                        case "june":
                            pm1 = 6;
                            nm1 = 4;
                            break;
                        case "september":
                            pm1 = 9;
                            nm1 = 5;
                            break;
                        case "november":
                            pm1 = 11;
                            nm1 = 3;
                            break;
                    }
                }
                else if (m1 == "february")
                {
                    if (y1 % 4 == 0 & (d1 < 1 | d1 > 29))
                    {
                        Console.WriteLine("Wrong date!");

                    }
                    if (y1 % 4 != 0 & (d1 < 1 | d1 > 28))
                    {
                        Console.WriteLine("Wrong date!");
                    }
                    else
                    {
                        flag1 = false;
                    }
                    pm1 = 2;
                    nm1 = 3;
                }
            }

            //date 2
            bool flag2 = true;
            while (flag2)
            {
                //Day of the 2nd date
                Console.Write("D2: ");
                //Checks whether input is valid or not
                string sd2 = Console.ReadLine();
                if (!int.TryParse(sd2, out d2))
                {
                    while (!int.TryParse(sd2, out d2))
                    {
                        Console.WriteLine("This is not a number!");
                        Console.Write("D2:");
                        sd2 = Console.ReadLine();
                    }
                }
                //Month of the 2nd date
                bool m2flag = true;
                //Checks whether input is valid or not
                while (m2flag)
                {
                    Console.Write("M2: ");
                    m2 = Console.ReadLine();
                    bool result = m2.All(Char.IsLetter);
                    if (result == true & m2 != "")
                    {
                        m2flag = false;
                    }
                    else
                        Console.WriteLine("This is not a month");
                }
                m2 = m2.ToLower();
                //Year of the 2nd date
                Console.Write("Y2: ");
                //Checks whether input is valid or not
                string sy2 = Console.ReadLine();
                if (!int.TryParse(sy2, out y2))
                {
                    while (!int.TryParse(sy2, out y2))
                    {
                        Console.WriteLine("This is not a number!");
                        Console.Write("Y2:");
                        sy2 = Console.ReadLine();
                    }
                }
                //Checks whether the date is valid or not
                if (y2 < 2015)
                {
                    Console.WriteLine("Wrong date!");
                }
                else if (m2 != "january" & m2 != "march" & m2 != "may" & m2 != "july" & m2 != "august" & m2 != "october" & m2 != "december" &
                    m2 != "april" & m2 != "june" & m2 != "september" & m2 != "november" & m2 != "february")
                {
                    Console.WriteLine("Wrong date!");
                }
                else if (m2 == "january" | m2 == "march" | m2 == "may" | m2 == "july" | m2 == "august" | m2 == "october" | m2 == "december")
                {
                    if (d2 < 1 | d2 > 31)
                    {
                        Console.WriteLine("Wrong date!");
                    }
                    else
                    {
                        flag2 = false;
                    }
                    switch (m2)
                    {
                        case "january":
                            pm2 = 1;
                            nm2 = 0;
                            break;
                        case "march":
                            pm2 = 3;
                            nm2 = 3;
                            break;
                        case "may":
                            pm2 = 5;
                            nm2 = 1;
                            break;
                        case "july":
                            pm2 = 7;
                            nm2 = 6;
                            break;
                        case "august":
                            pm2 = 8;
                            nm2 = 2;
                            break;
                        case "october":
                            pm2 = 10;
                            nm2 = 0;
                            break;
                        case "december":
                            pm2 = 12;
                            nm2 = 5;
                            break;
                    }
                }
                else if (m2 == "april" | m2 == "june" | m2 == "september" | m2 == "november")
                {
                    if (d2 < 1 | d2 > 30)
                    {
                        Console.WriteLine("Wrong date!");
                    }
                    else
                    {
                        flag2 = false;
                    }
                    switch (m2)
                    {
                        case "april":
                            pm2 = 4;
                            nm2 = 6;
                            break;
                        case "june":
                            pm2 = 6;
                            nm2 = 4;
                            break;
                        case "september":
                            pm2 = 9;
                            nm2 = 5;
                            break;
                        case "november":
                            pm2 = 11;
                            nm2 = 3;
                            break;
                    }
                }
                else if (m2 == "february")
                {
                    if (y2 % 4 == 0 & (d2 < 1 | d2 > 29))
                    {
                        Console.WriteLine("Wrong date!");

                    }
                    if (y2 % 4 != 0 & (d2 < 1 | d2 > 28))
                    {
                        Console.WriteLine("Wrong date!");
                    }
                    else
                    {
                        flag2 = false;
                    }
                    pm2 = 2;
                    nm2 = 3;
                }
            }
            //Positive integer
            bool flag3 = true;
            while (flag3)
            {
                Console.Write("n: ");
                string sn = Console.ReadLine();
                if (!int.TryParse(sn, out n))
                {
                    while (!int.TryParse(sn, out n))
                    {
                        Console.WriteLine("This is not a number!");
                        Console.Write("n: ");
                        sn = Console.ReadLine();
                    }
                }
                if (n < 1)
                {
                    Console.WriteLine("Enter positive integer");
                }
                else
                {
                    flag3 = false;
                }
            }

            //Readjusting the dates if the first date is berfore the second date
            if (y1 > y2 || (y1 == y2 & pm1 > pm2) || (y1 == y2 & pm1 == pm2 & d1 > d2))
            {
                int temp = d1;
                d1 = d2;
                d2 = temp;
                string stemp = m1;
                m1 = m2;
                m2 = stemp;
                temp = y1;
                y1 = y2;
                y2 = temp;
                temp = nm1;
                nm1 = nm2;
                nm2 = temp;
                temp = pm1;
                pm1 = pm2;
                pm2 = temp;
            }

            Console.Write("\nOutput:\n");

            //Prints the days
            for (int k = y1; k <= y2; k++)
            {
                string month = "";
                for (int i = pm1; i < 13; i++)
                {
                    switch (i)
                    {
                        case 1:
                            //Prints the seasons
                            if (seasons)
                            {
                                Console.WriteLine("Winter");
                                seasons = false;
                            }
                            month = " January ";
                            //Reassinging month number for the algorithm
                            nm1 = 0;
                            break;
                        case 2:
                            //Prints the seasons
                            if (seasons)
                            {
                                Console.WriteLine("Winter");
                                seasons = false;
                            }
                            month = " February ";
                            //Reassinging month number for the algorithm
                            nm1 = 3;
                            break;
                        case 3:
                            //Prints the seasons
                            if (seasons)
                            {
                                Console.WriteLine("Spring");
                                seasons = false;
                            }
                            month = " March ";
                            //Reassinging month number for the algorithm
                            nm1 = 3;
                            break;
                        case 4:
                            //Prints the seasons
                            if (seasons)
                            {
                                Console.WriteLine("Spring");
                                seasons = false;
                            }
                            month = " April ";
                            //Reassinging month number for the algorithm
                            nm1 = 6;
                            break;
                        case 5:
                            //Prints the seasons
                            if (seasons)
                            {
                                Console.WriteLine("Spring");
                                seasons = false;
                            }
                            month = " May ";
                            //Reassinging month number for the algorithm
                            nm1 = 1;
                            break;
                        case 6:
                            //Prints the seasons
                            if (seasons)
                            {
                                Console.WriteLine("Summer");
                                seasons = false;
                            }
                            month = " June ";
                            //Reassinging month number for the algorithm
                            nm1 = 4;
                            break;
                        case 7:
                            //Prints the seasons
                            if (seasons)
                            {
                                Console.WriteLine("Summer");
                                seasons = false;
                            }
                            month = " July ";
                            //Reassinging month number for the algorithm
                            nm1 = 6;
                            break;
                        case 8:
                            //Prints the seasons
                            if (seasons)
                            {
                                Console.WriteLine("Summer");
                                seasons = false;
                            }
                            month = " August ";
                            //Reassinging month number for the algorithm
                            nm1 = 2;
                            break;
                        case 9:
                            //Prints the seasons
                            if (seasons)
                            {
                                Console.WriteLine("Autumn");
                                seasons = false;
                            }
                            month = " September ";
                            //Reassinging month number for the algorithm
                            nm1 = 5;
                            break;
                        case 10:
                            //Prints the seasons
                            if (seasons)
                            {
                                Console.WriteLine("Autumn");
                                seasons = false;
                            }
                            month = " October ";
                            //Reassinging month number for the algorithm
                            nm1 = 0;
                            break;
                        case 11:
                            //Prints the seasons
                            if (seasons)
                            {
                                Console.WriteLine("Autumn");
                                seasons = false;
                            }
                            month = " November ";
                            //Reassinging month number for the algorithm
                            nm1 = 3;
                            break;
                        case 12:
                            //Prints the seasons
                            if (seasons)
                            {
                                Console.WriteLine("Winter");
                                seasons = false;
                            }
                            month = " December ";
                            //Reassinging month number for the algorithm
                            nm1 = 5;
                            break;
                    }

                    for (int j = d1; j < 32; j += n)
                    {
                        //Stops the loop if it has reached the target date or stops if it will exceed the target date 
                        if (k == y2 & i == pm2 & j + n > d2)
                        {
                            d1 = j;
                            y1 = k;
                            break;
                        }

                        //determining the day of the week
                        //Algorithm is as the follows (day number + special number for the month + last two digits of the year + last two digits of the year divided by 4 (only the remainder) mod 7
                        int LTwoDgtOfYr, divedtowdig;
                        LTwoDgtOfYr = k % 1000;
                        divedtowdig = LTwoDgtOfYr / 4;
                        //6 is the centuary number
                        //0 means sunday and 6 means saturday
                        daynum = (j + nm1 + 6 + LTwoDgtOfYr + divedtowdig) % 7;
                        //Leap year has an exception. You subtract 1 from the result
                        if (k % 4 == 0)
                            daynum -= 1;
                        //assigning vars to print
                        switch (daynum)
                        {
                            case 0:
                                stringday = " Sunday";
                                break;
                            case 1:
                                stringday = " Monday";
                                break;
                            case 2:
                                stringday = " Tuesday";
                                break;
                            case 3:
                                stringday = " Wednesday";
                                break;
                            case 4:
                                stringday = " Thursday";
                                break;
                            case 5:
                                stringday = " Friday";
                                break;
                            case 6:
                                stringday = " Saturday";
                                break;
                        }

                        //Prints the days (j is day number, k is year, stringday is the day of the week)
                        Console.Write(j + month + k + stringday + "\n");

                        //Finds the reminder for the months that have 30 days
                        if (j + n > 30 & (i == 4 | i == 6 | i == 9 | i == 11))
                        {
                            d1 = (j + n) - 30;
                            //Skiping to next season
                            if (i == 11)
                            {
                                seasons = true;
                                Console.Write("\n");
                            }
                            break;
                        }
                        //Finds the reminder for february if it is the leap year
                        else if (j + n > 29 & i == 2 & (k % 4 == 0))
                        {
                            d1 = (j + n) - 29;
                            //Skiping to next season
                            seasons = true;
                            Console.Write("\n");
                            break;
                        }
                        //Finds the reminder for february if it is not the leap year
                        else if (j + n > 29 & i == 2)
                        {
                            d1 = (j + n) - 28;
                            //Skiping to next season
                            seasons = true;
                            Console.Write("\n");
                            break;
                        }
                        //Finds the reminder for the months that have 31 days
                        else if (j + n > 31 & (i == 1 | i == 3 | i == 5 | i == 7 | i == 8 | i == 10 | i == 12))
                        {
                            d1 = (j + n) - 31;
                            //Skiping to next season
                            if (i == 5 | i == 8)
                            {
                                seasons = true;
                                Console.Write("\n");
                            }
                            break;
                        }
                        //Sets the month(i) variable to 1 when a year is complete
                        if (i + 1 > 12)
                        {
                            d1 = j;
                            pm1 = 1;
                        }
                    }
                    //Stops the loop if it has reached the target date or stops if it will exceed the target date
                    if (k == y2 & i == pm2 & d1 + n > d2)
                    {
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
