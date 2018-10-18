using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SerializeString
{
    class SerializeString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, List<int>> characterIndexes = new Dictionary<char, List<int>>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!characterIndexes.ContainsKey(input[i]))
                {
                    characterIndexes[input[i]] = new List<int>();
                }

                characterIndexes[input[i]].Add(i);
            }

            foreach (var kvp in characterIndexes)
            {
                char character = kvp.Key;
                List<int> indexes = kvp.Value;

                Console.WriteLine($"{character}:{string.Join("/", indexes)}");
            }
        }
    }
}
