using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            List<string> bannedWords = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Count; i++)
            {
                string bannedWord = bannedWords[i];
                int indexOfBannedWord = 0;

                while (true)
                {
                    indexOfBannedWord = text.IndexOf(bannedWord, indexOfBannedWord);
                    if (indexOfBannedWord >= 0)
                    {
                        text = text.Replace(bannedWord, new string('*', bannedWord.Length));
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(text);
        }
    }
}
