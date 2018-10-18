using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefaultValues
{
    class DefaultValues
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, string> defaultValues = new Dictionary<string, string>();
            Dictionary<string, string> notDefaultValues = new Dictionary<string, string>();

            while (input[0] != "end")
            {
                string word = input[0];
                string value = input[2];

                if (value == "null")
                {
                    if (notDefaultValues.ContainsKey(word))
                    {
                        notDefaultValues.Remove(word);
                    }
                    defaultValues[word] = value;
                }
                else
                {
                    if (defaultValues.ContainsKey(word))
                    {
                        defaultValues.Remove(word);
                    }
                    notDefaultValues[word] = value;
                }

                input = Console.ReadLine().Split(' ').ToList();
            }

            string newValue = Console.ReadLine();

            notDefaultValues = notDefaultValues.OrderByDescending(x => x.Value.Length).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in notDefaultValues)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }
            foreach (var kvp in defaultValues)
            {
                Console.WriteLine($"{kvp.Key} <-> {newValue}");
            }
        }
    }
}
