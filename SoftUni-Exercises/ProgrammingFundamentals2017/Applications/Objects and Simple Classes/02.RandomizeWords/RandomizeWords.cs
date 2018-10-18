using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();

            Random word = new Random();

            while (words.Count > 0)
            {
                int index = word.Next(0, words.Count - 1);
                Console.WriteLine(words[index]);
                words.RemoveAt(index);
            }
        }
    }
}
