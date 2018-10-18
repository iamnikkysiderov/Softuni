using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountOfCapitalLettersInArray
{
    class CountOfCapitalLettersInArray
    {
        static void Main(string[] args)
        {
            string[] countCapitalLetters = Console.ReadLine().Split(' ').ToArray();
            int counter = 0;

            for (int i = 0; i < countCapitalLetters.Length; i++)
            {
                if (countCapitalLetters[i].Length == 1 && char.Parse(countCapitalLetters[i]) >= 65 && char.Parse(countCapitalLetters[i]) <= 90)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
