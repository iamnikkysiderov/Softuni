using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").Split(' ').ToArray();
            List<string> input = File.ReadAllText("input.txt").ToLower().Split(new[] { ' ', ',', '.', '?', '!', '-', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordsCount.Add(word, 0);
            }

            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (input[i] == words[j])
                    {
                        wordsCount[words[j]]++;
                    }
                }
            }

            List<string> result = new List<string>();

            foreach (var word in wordsCount.OrderByDescending(x => x.Value))
            {
                string currentWord = word.Key;
                string count = word.Value.ToString();
                string str = $"{currentWord} - {count}";

                result.Add(str);
            }

            File.WriteAllLines("output.txt", result);
        }
    }
}
