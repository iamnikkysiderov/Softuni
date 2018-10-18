using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WordEncounter
{
    class WordEncounter
    {
        static void Main(string[] args)
        {
            string letterDigit = Console.ReadLine();
            string sentence = Console.ReadLine();
            
            while (sentence != "end")
            {
                bool valid = false;

                if (sentence[0] >= 65 && sentence[0] <= 90)
                {
                    if (sentence[sentence.Length-1] == '.' || sentence[sentence.Length-1] == '?' || sentence[sentence.Length-1] == '!')
                    {
                        valid = true;
                    }
                }

                if (valid)
                {
                    char[] separators =
                    {
                        '.', ' ', '?', '!', ';', ':', '\'', '\"', '\n'
                    };

                    List<string> words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

                    int counter = 0;
                    string character = letterDigit[0].ToString();

                    for (int i = 0; i < words.Count; i++)
                    {
                        string tempWord = words[i];

                        string word = words[i];

                        if (tempWord.Contains(character))
                        {
                            
                        }
                    }
                }

                sentence = Console.ReadLine();
            }
        }
    }
}
