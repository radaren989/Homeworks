using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            float x = 0, aside = 0, bside = 0, cside = 0, per = 0, medianax = 0, medianay = 0, medianby = 0, medianbx = 0, mediancx = 0, mediancy = 0, centerx = 0, centery = 0, bisec = 0;
            double A = 0, B = 0, C = 0, radA = 0, radB = 0, radC = 0, incircle = 0, area = 0, outcircle = 0, area1 = 0, area2 = 0, area3 = 0;
            int ax = 0, ay = 0, bx = 0, by = 0, cx = 0, cy = 0;
            string typeS = "", typeA = "", name="";
            int select = 0;
            bool shot = true;
            bool exit = false;

            while (exit == false) {
                Console.WriteLine("             -MENU-\n" +
                "PLEASE SELCET FROM THE OPTIONS BELOW:\n    " +
                "1 - Enter ship location\n    " +
                "2 - Ship info\n    " +
                "3 - Shoot at the ship\n    " +
                "4 - Show high score table\n    " +
                "5 - Exit");

                Console.Write("Enter option number to proceed: ");
                var Sselect = Console.ReadLine();
                if (!int.TryParse(Sselect, out select))
                {
                    while (!int.TryParse(Sselect, out select))
                    {
                        Console.WriteLine("This is not a number!");
                        Console.Write("Enter option number to proceed: ");
                        Sselect = Console.ReadLine();
                    }

                }
                Console.Clear();

                switch (select)
                {

                    case 1:
                        Console.Write("Please enter the location of the ship \n\nX axis A(_,_): ");

                        //String controller   
                        var sax = Console.ReadLine();

                        if (!int.TryParse(sax, out ax))
                        {
                            while (!int.TryParse(sax, out ax))
                            {
                                Console.WriteLine("This is not a number!");
                                Console.Write("X axis A(_,_): ");
                                sax = Console.ReadLine();
                            }

                        }
                        //ax = Convert.ToInt32(sax);
                        if (ax < 1 || ax > 30)
                        {
                            while (ax < 1 || ax > 30)
                            {
                                Console.Write("Please enter the location between 1 and 30 \n\nX axis A(_,_): ");
                                ax = Convert.ToInt32(Console.ReadLine());

                            }
                        }

                        Console.Write("Y axis A(" + ax + ",_): ");

                        //String controller   
                        var say = Console.ReadLine();
                        if (!int.TryParse(say, out ay))
                        {
                            while (!int.TryParse(say, out ay))
                            {
                                Console.WriteLine("This is not a number!");
                                Console.Write("Y axis A(" + ax + ",_): ");
                                say = Console.ReadLine();
                            }
                        }
                        if (ay < 1 || ay > 12)
                        {
                            while (ay < 1 || ay > 12)
                            {
                                Console.Write("Please enter the location between 1 and 12 \n\nY axis A(_,_): ");
                                ay = Convert.ToInt32(Console.ReadLine());

                            }
                        }
                        Console.WriteLine("A(" + ax + "," + ay + ")");

                        Console.Write(" \nX axis B(_,_): ");
                        //String controller   
                        var sbx = Console.ReadLine();
                        if (!int.TryParse(sbx, out bx))
                        {
                            while (!int.TryParse(sbx, out bx))
                            {
                                Console.WriteLine("This is not a number!");
                                Console.Write("X axis B(_,_): ");
                                sbx = Console.ReadLine();
                            }
                        }
                        if (bx < 1 || bx > 30)
                        {

                            while (bx < 1 || bx > 30)
                            {
                                Console.Write("Please enter the location between 1 and 30 \n\nX axis B(_,_): ");
                                bx = Convert.ToInt32(Console.ReadLine());

                            }
                        }
                        Console.Write("Y axis B(" + bx + ",_): ");

                        //String controller   
                        var sby = Console.ReadLine();
                        if (!int.TryParse(sby, out by))
                        {
                            while (!int.TryParse(sby, out by))
                            {
                                Console.WriteLine("This is not a number!");
                                Console.Write("Y axis B(" + bx + ",_): ");
                                sby = Console.ReadLine();
                            }
                        }
                        if (by < 1 || by > 12)
                        {
                            while (by < 1 || by > 12)
                            {
                                Console.Write("Please enter the location between 1 and 12 \n\nY axis B(_,_): ");
                                by = Convert.ToInt32(Console.ReadLine());
                            }
                        }

                        Console.WriteLine("B(" + bx + "," + by + ")");

                        Console.Write(" \nX axis C(_,_): ");
                        //String controller   
                        var scx = Console.ReadLine();
                        if (!int.TryParse(scx, out cx))
                        {
                            while (!int.TryParse(scx, out cx))
                            {
                                Console.WriteLine("This is not a number!");
                                Console.Write("X axis C(_,_): ");
                                scx = Console.ReadLine();
                            }
                        }
                        if (cx < 1 || cx > 30)
                        {
                            while (cx < 1 || cx > 30)
                            {
                                Console.Write("Please enter the location between 1 and 30 \n\nX axis C(_,_): ");
                                cx = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        Console.Write("Y axis C(" + cx + ",_): ");

                        //String controller   
                        var scy = Console.ReadLine();
                        if (!int.TryParse(scy, out cy))
                        {
                            while (!int.TryParse(scy, out cy))
                            {
                                Console.WriteLine("This is not a number!");
                                Console.Write("Y axis B(" + cx + ",_): ");
                                scy = Console.ReadLine();
                            }
                        }
                        if (cy < 1 || cy > 12)
                        {

                            while (cy < 1 || cy > 12)
                            {
                                Console.Write("Please enter the location between 1 and 12 \n\nY axis C(_,_): ");
                                cy = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        Console.WriteLine("C(" + cx + "," + cy + ")");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        //Lenght of the  edges
                        cside = (float)Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2));
                        aside = (float)Math.Sqrt(Math.Pow((bx - cx), 2) + Math.Pow((by - cy), 2));
                        bside = (float)Math.Sqrt(Math.Pow((ax - cx), 2) + Math.Pow((ay - cy), 2));

                        //median points
                        mediancx = (ax + bx) / 2;
                        mediancy = (ay + by) / 2;
                        medianax = (bx + cx) / 2;
                        medianay = (by + cy) / 2;
                        medianbx = (ax + cx) / 2;
                        medianby = (ay + cy) / 2;

                        //perimeter
                        per = aside + bside + cside;

                        //area
                        area = (float)Math.Sqrt(((per / 2) * (per / 2 - aside) * (per / 2 - bside) * (per / 2 - cside)));

                        //Centroid
                        centerx = (float)(medianax + medianbx + mediancx) / 3;
                        centery = (float)(medianay + medianby + mediancy) / 3;

                        //angles
                        radA = Math.Acos(((Math.Pow(aside, 2) - Math.Pow(bside, 2) - Math.Pow(cside, 2)) / (-2 * bside * cside)));
                        A = (radA * (180 / Math.PI));
                        radB = Math.Acos(((Math.Pow(bside, 2) - Math.Pow(aside, 2) - Math.Pow(cside, 2)) / (-2 * aside * cside)));
                        B = (radB * (180 / Math.PI));
                        radC = Math.Acos(((Math.Pow(cside, 2) - Math.Pow(aside, 2) - Math.Pow(bside, 2)) / (-2 * bside * aside)));
                        C = (radC * (180 / Math.PI));

                        //Bisector's length of point A
                        x = aside * cside / (bside + cside);
                        bisec = (float)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(cside, 2) - 2 * cside * x * Math.Cos(radB));

                        //Area of Insribed Circle
                        incircle = (double)Math.PI * Math.Pow(2 * area / per, 2);

                        //Area of Circumscribed Circle
                        outcircle = (double)Math.PI * Math.Pow(aside / (2 * Math.Sin(radA)), 2);

                        //Type of the triangle by side
                        typeS = ""; typeA = "";
                        if (A == B & A == C)
                        {
                            typeS = "Equilateral";
                        }
                        else if (A == B | A == C | B == C)
                        {
                            typeS = "Isosceles";
                        }
                        else if (aside != bside & aside != cside & cside != bside)
                        {
                            typeS = "Scalene";
                        }

                        //Type of the triangle by angles
                        if (A == 90 | B == 90 | C == 90)
                        {
                            typeA = "Right-angled";
                        }
                        else if (A <= 90 && B <= 90 && C <= 90)
                        {
                            typeA = "Acute-angle";
                        }
                        else if (A >= 90 | B >= 90 | C >= 90)
                        {
                            typeA = "Obtuse-angled";
                        }
                        break;
                    case 2:                       
                        if (A + B + C < 181 & A + B + C > 179)
                        {
                            //Cordinates
                            Console.Write("12|\n11|\n10|\n9 |\n8 | \n7 |\n6 |\n5 |\n4 |\n3 |\n2 |          \n1 | \n  +------------------------------\n   123456789012345678901234567890");
                            Console.SetCursorPosition(3 + ax, 12 - ay);
                            Console.WriteLine("A");
                            Console.SetCursorPosition(3 + bx, 12 - by);
                            Console.WriteLine("B");
                            Console.SetCursorPosition(3 + cx, 12 - cy);
                            Console.WriteLine("C");
                            Console.SetCursorPosition(0, 15);

                            //Informations
                            Console.WriteLine("The size of the ship: a = {0}, b = {1}, c = {2}", $"{aside:0.0#}", $"{bside:0.0#}", $"{cside:0.0#}");
                            Console.WriteLine("The perimeter of the ship: {0}", $"{per:0.0#}");
                            Console.WriteLine("The area of the ship: {0}", $"{area:0.0#}");
                            Console.WriteLine("The angles of the ship: A = {1} B = {0} C = {2} ", $"{A:0.0#}", $"{B: 0.0#}", $"{C:0.0#}");
                            Console.WriteLine("The median points: ({0}, {1}) ({2}, {3}) ({4}, {5})", $"{medianax:0.0#}", $"{medianay:0.0#}", $"{medianbx:0.0#}", $"{medianby:0.0#}", $"{mediancx:0.0#}", $"{mediancy:0.0#}");
                            Console.WriteLine("The centroid of the ship:  ({0}, {1})", $"{centerx:0.0#}", $"{centery:0.0#}");
                            Console.WriteLine("The length of the bisector: {0}", $"{bisec: 0.0#}");
                            Console.WriteLine("The area of the inscribed circle: {0} ", $"{incircle: 0.0#}");
                            Console.WriteLine("The area of circumscribed circle: {0}", $"{outcircle: 0.0#}");
                            Console.WriteLine("The type of the ship: {0} ({1})", typeS, typeA);
                            Console.WriteLine("\nPress enter to continue");
                           
                        }
                        else          
                            Console.WriteLine("Invalid triangle! Please Enter the location correctly");
                          
                         Console.ReadKey();
                            Console.Clear();
                        break;
                    case 3:
                        if (A + B + C < 181 & A + B + C > 179) { 
                            Console.Write("12|\n11|\n10|\n9 |\n8 | \n7 |\n6 |\n5 |\n4 |\n3 |\n2 |          \n1 | \n  +------------------------------\n   123456789012345678901234567890");
                        Console.SetCursorPosition(3 + ax, 12 - ay);
                        Console.WriteLine("A");
                        Console.SetCursorPosition(3 + bx, 12 - by);
                        Console.WriteLine("B");
                        Console.SetCursorPosition(3 + cx, 12 - cy);
                        Console.WriteLine("C");
                        Console.SetCursorPosition(0, 15);
                        Console.WriteLine("\nPress enter to shoot");
                        Console.ReadLine();
                        Random rand = new Random();
                        int shootx, shooty;
                        shootx = rand.Next(0, 31);
                        shooty = rand.Next(0, 13);
                        Console.Clear();
                        
                        Console.WriteLine("shoot: (" + shootx + "," + shooty + ")");
                        Console.Write("12|\n11|\n10|\n9 |\n8 | \n7 |\n6 |\n5 |\n4 |\n3 |\n2 |          \n1 | \n  +------------------------------\n   123456789012345678901234567890");
                        Console.SetCursorPosition(3 + ax, 13 - ay);
                        Console.WriteLine("A");
                        Console.SetCursorPosition(3 + bx, 13 - by);
                        Console.WriteLine("B");
                        Console.SetCursorPosition(3 + cx, 13 - cy);
                        Console.WriteLine("C");
                        Console.SetCursorPosition(3 + shootx, 13 - shooty);
                        Console.WriteLine("X");
                        Console.SetCursorPosition(1, 16);
                        
                        
                        area1 = Math.Round(Math.Abs((((double)ax * ((double)by - (double)shooty) + (double)bx * ((double)shooty - (double)ay) + (double)shootx * ((double)ay - (double)by)) / 2)),2);
                        area2 = Math.Round(Math.Abs((((double)cx * ((double)by - (double)shooty) + (double)bx * ((double)shooty - (double)cy) + (double)shootx * ((double)cy - (double)by)) / 2)),2);
                        area3 = Math.Round(Math.Abs((((double)ax * ((double)cy - (double)shooty) + (double)cx * ((double)shooty - (double)ay) + (double)shootx * ((double)ay - (double)cy)) / 2)),2);
                        area = Math.Round(area, 2);
                            if ((area1 + area2 + area3) == area)
                            {
                                Console.WriteLine("Your ship sank!!");
                                shot = true;
                            }
                            else
                            {
                                Console.WriteLine("Your ship survived \n Your Score is " + $"{area:0.0#}");
                                shot = false;
                                bool flag = true;
                                while (flag)
                                {
                                    Console.Write(" Enter Your Name: ");
                                    name = Console.ReadLine();
                                    bool result = name.All(Char.IsLetter);
                                    if (result == true)
                                    {
                                        flag = false;
                                    }
                                }
                            }
                        
                        }
                        else
                            Console.WriteLine("Invalid triangle! Please Enter the location correctly");

                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                       
                        //Score table
                        string player1 = "Beypazarı", player2 = "Kula";
                        int splayer1 = 60, splayer2 = 30;

                        if (shot == false)
                        {
                            
                            Console.WriteLine("HIGH SCORE TABLE\n");
                            Console.WriteLine(string.Format("{0,-20} |{1,-5} ", "name", "Score"));
                            Console.WriteLine("---------------------------");
                            if ((int)area <= splayer2)
                            {
                                Console.WriteLine(string.Format("{0,-20} |{1,-5} ", player1, splayer1));
                                Console.WriteLine(string.Format("{0,-20} |{1,-5} ", player2, splayer2));
                                Console.WriteLine(string.Format("{0,-20} |{1,-5} ", name, $"{area:0.0#}"));
                            }
                            if ((int)area > splayer1)
                            {
                                Console.WriteLine(string.Format("{0,-20} |{1,-5} ", name, $"{area:0.0#}"));
                                Console.WriteLine(string.Format("{0,-20} |{1,-5} ", player1, splayer1));
                                Console.WriteLine(string.Format("{0,-20} |{1,-5} ", player2, splayer2));
                            }
                            if ((int)area <= splayer1 & area > splayer2)
                            {
                                Console.WriteLine(string.Format("{0,-20} |{1,-5} ", player1, splayer1));
                                Console.WriteLine(string.Format("{0,-20} |{1,-5} ", name, $"{area:0.0#}"));
                                Console.WriteLine(string.Format("{0,-20} |{1,-5} ", player2, splayer2));
                            }

                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("HIGH SCORE TABLE\n");
                            Console.WriteLine(string.Format("{0,-20} |{1,-5} ", "name", "Score"));
                            Console.WriteLine("---------------------------");
                            Console.WriteLine(string.Format("{0,-20} |{1,-5} ", player1, splayer1));
                            Console.WriteLine(string.Format("{0,-20} |{1,-5} ", player2, splayer2));
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Thank you for playing\n*************\nCredits\n------------\nTuğrul Demirözer\nÖzgün Özer\nMuhammed Azimov");
                        Console.ReadKey();
                        exit = true;
                        break;

                }


            }
        }
    }
}
