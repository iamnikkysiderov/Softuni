using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120.OddOccurences
{
    class OddOccurences
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower().Split(' ').ToList();
            List<string> distinctWords = new List<string>();
            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 0; i < words.Count; i++)
            {
                distinctWords.Add(words[i]);
            }

            distinctWords = distinctWords.Distinct().ToList();

            for (int i = 0; i < distinctWords.Count; i++)
            {
                string currentWord = distinctWords[i];
                int occurences = 0;

                for (int j = 0; j < words.Count; j++)
                {
                    if (currentWord == words[j])
                    {
                        occurences++;
                    }
                }

                if (occurences % 2 != 0)
                {
                    result.Add(currentWord, occurences);
                }
            }

            Console.WriteLine(string.Join(", ",result.Keys));
        }
    }
}
