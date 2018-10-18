using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LetterRepetition
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            string characters = Console.ReadLine();
            Dictionary<char, int> characterOccurences = new Dictionary<char, int>();

            char[] distinctCharacters = new char[characters.Length];
            distinctCharacters = characters.ToCharArray();
            distinctCharacters = distinctCharacters.Distinct().ToArray();

            for (int i = 0; i < distinctCharacters.Length; i++)
            {
                char currentChar = distinctCharacters[i];

                for (int j = 0; j < characters.Length; j++)
                {
                    if (currentChar == characters[j])
                    {
                        if (!characterOccurences.ContainsKey(currentChar))
                        {
                            characterOccurences[currentChar] = 0;
                        }

                        characterOccurences[currentChar]++;
                    }
                }
            }

            foreach (var kvp in characterOccurences)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
