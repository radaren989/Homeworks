using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word
{
    class Program
    {
        static void Main(string[] args)
        {

            int Lindex = 0, index = 0, Dindex = 0;
            string CPattern = "qwertyuiopasdfghjklzxcvbnm-*";
            string[] sliced = new string[index];
            string[] lower = new string[Lindex];
            string[] distinct = new string[Dindex];
            string text = "", pattern = "", word = "";
            //Sample text 
            text = "Miss Polly had a poor dolly, who was sick. She called for the talled doctor Solly to come quick.He knocked on the DOOR like a actor in the healthcare sector.";
            //text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            //Console.Write("Enter A Text: ");
            //text = Convert.ToString(Console.ReadLine());

            bool flag = true;
            while (flag)
            {
                Console.Write("\nEnter A Pattern: ");
                pattern = Convert.ToString(Console.ReadLine()).ToLower();
                if (pattern != "")
                {
                    string check = "";
                    for (int i = 0; i < pattern.Length; i++)
                    {
                        if (!CPattern.Contains(pattern[i]))
                        {
                            check += pattern[i];
                            break;
                        }
                    }
                    if (check == "")
                        flag = false;
                    else
                        Console.WriteLine("Entered incorrect pattern\nPattern can only contains letters , '-' and '*'");
                }
            }
            
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] <= 122 && text[i] >= 97) || (text[i] <= 90 && text[i] >= 65) || text[i] == '\'')
                {
                    word += Convert.ToString(text[i]);
                }
                else if(word != "")
                {
                    Array.Resize(ref sliced, index + 1);
                    Array.Resize(ref lower, index + 1);
                    sliced[index] = word;
                    if (lower.Contains(word.ToLower()) == true)
                        lower[index] = "";
                    else
                        lower[index] = word.ToLower();
                    if (lower[index] != "")
                    {
                        Array.Resize(ref distinct, Dindex + 1);
                        distinct[Dindex] = sliced[index];
                        Dindex++;
                    }
                    word = "";
                    index++;
                }
            }
            
            for (int i = 0; i < distinct.Length; i++)
            {
                string a = Output(distinct[i], pattern);
                if (a != "")
                    Console.WriteLine(a);
            }
            Console.ReadKey();
        }
        static string Output(string word, string input, bool flag = false, int starFound = 1)
        {
            int index = 0, wordindex = 0;
            string print = "";
            //if input and word have same length of letters and there is no letter to check OR last letter of input is '*'
            if (input.Length == word.Length && input == "" && flag ||(input =="" && starFound == 0))
            {
                return "ok";
            }
            else if(input != "" && word !="")  
            {
                switch (input[index])
                {
                    case '*':
                            print = Output(word.Substring(0), input.Substring(1), false ,0);
                        break;
                    case '-':
                        if (word != "")
                        {
                            flag = true;
                            print = Output(word.Substring(1), input.Substring(1), flag);
                        }
                        break;
                    default:
                        if (word != "" && char.ToLower(input[index]) == char.ToLower(word[wordindex]))
                        {
                            flag = true;
                            print = Output(word.Substring(1), input.Substring(1), flag);
                        }
                        else if (starFound == 0 && char.ToLower(input[index]) != char.ToLower(word[wordindex]))
                            print = Output(word.Substring(1), input.Substring(0), false, 0);
                        if (starFound == 0 && print == "" )
                        {
                            print = Output(word.Substring(1), input.Substring(0), false, 0);
                        }
                        else
                            flag = false;
                        break;
                }
            }
            if (print == "")
                return "";

            return word;
        }
    }
}
