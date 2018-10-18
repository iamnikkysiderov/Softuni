using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> container = new List<string>();

            List<string> smallLetters = new List<string>();
            List<string> capitalLetters = new List<string>();
            List<string> mixedLetters = new List<string>();
            char[] charsToTrim = { ':', '.', ',', ';', '!', '(', ')', '"', '\'', '/', '\\', '[', ']', ' ' };

            container = text.Split(charsToTrim).ToList();

            foreach (string item in container)
            {
                int countOfCapitalLetters = 0;
                int countOfSmallLetters = 0;

                if (item != "")
                {

                    for (int j = 0; j < item.Length; j++)
                    {
                        if (item[j] >= 65 && item[j] <= 90)
                        {
                            countOfCapitalLetters++;
                        }
                        else if (item[j] >= 97 && item[j] <= 122)
                        {
                            countOfSmallLetters++;
                        }
                    }

                    if (countOfCapitalLetters == item.Length)
                    {
                        capitalLetters.Add(item);
                    }
                    else if (countOfSmallLetters == item.Length)
                    {
                        smallLetters.Add(item);
                    }
                    else
                    {
                        mixedLetters.Add(item);
                    }
                }
            }

            Console.Write("Lower-case: ");
            Console.WriteLine(string.Join(", ", smallLetters));
            Console.Write("Mixed-case: ");
            Console.WriteLine(string.Join(", ", mixedLetters));
            Console.Write("Upper-case: ");
            Console.WriteLine(string.Join(", ", capitalLetters));
        }
    }
}
