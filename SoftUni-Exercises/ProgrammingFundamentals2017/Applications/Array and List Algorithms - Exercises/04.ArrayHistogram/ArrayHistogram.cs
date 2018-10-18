using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();
            List<string> singleWords = words.Distinct().ToList();

            int counter = 1;
            List<int> counters = new List<int>();

            Dictionary<string, int> occurencesOfAString = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (occurencesOfAString.ContainsKey(word))
                {
                    occurencesOfAString[word] += 1;
                }
                else
                {
                    counter = 1;
                    occurencesOfAString.Add(word, counter);
                }
            }

            occurencesOfAString = occurencesOfAString.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            int index = 0;

            foreach (var item in occurencesOfAString)
            {
                double percentage = (double)item.Value / (double)words.Count * 100;
                index++;
                Console.WriteLine("{0} -> {1} times ({2:f2}%)", item.Key, item.Value, percentage);
            }
        }
    }
}
