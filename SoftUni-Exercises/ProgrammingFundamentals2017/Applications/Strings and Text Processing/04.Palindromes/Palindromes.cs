using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            List<string> inputWords = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            HashSet<string> palindromes = new HashSet<string>();

            for (int i = 0; i < inputWords.Count; i++)
            {
                string word = inputWords[i];
                string reversedWord = string.Empty;

                for (int j = word.Length-1; j >= 0; j--)
                {
                    reversedWord += word[j];
                }

                if (reversedWord == word)
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
        }
    }
}
