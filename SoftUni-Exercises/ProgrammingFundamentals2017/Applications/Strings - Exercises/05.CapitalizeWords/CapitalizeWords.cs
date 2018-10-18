using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CapitalizeWords
{
    class CapitalizeWords
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                List<string> inputParams = input.Split(new[] { ' ', '.', ',', '!', '?', ':', ';', '"', '\n', ']', '[', '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int i = 0; i < inputParams.Count; i++)
                {
                    StringBuilder word = new StringBuilder();
                    word.Append(inputParams[i]);
                    word[0] = char.Parse(word[0].ToString().ToUpper());

                    for (int j = 1; j < word.Length; j++)
                    {
                        word[j] = char.Parse(word[j].ToString().ToLower());
                    }

                    inputParams[i] = word.ToString();
                }

                Console.WriteLine(string.Join(", ", inputParams));

                input = Console.ReadLine();
            }
        }
    }
}
