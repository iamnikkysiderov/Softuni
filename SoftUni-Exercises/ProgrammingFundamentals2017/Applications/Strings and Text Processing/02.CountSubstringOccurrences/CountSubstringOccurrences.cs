using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string wordToBeCountedInInput = Console.ReadLine().ToLower();

            int counter = 0;
            int i = 0;

            while (i <= input.Length-1)
            {
                i = input.IndexOf(wordToBeCountedInInput, i);

                if (i < 0)
                {
                    break;
                }
                else
                {
                    counter++;
                    i++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
