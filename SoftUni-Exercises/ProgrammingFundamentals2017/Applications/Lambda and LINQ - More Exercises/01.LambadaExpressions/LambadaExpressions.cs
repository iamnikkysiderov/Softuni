using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LambadaExpressions
{
    class LambadaExpressions
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> storeExpressions = new Dictionary<string, string>();

            while (input != "lambada")
            {
                List<string> inputParams = input.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (inputParams[0])
                {
                    case "dance":
                        storeExpressions = Dance(storeExpressions, inputParams);
                        break;
                    default:
                storeExpressions = AddExpressions(storeExpressions, inputParams);
                        break;

                }

                input = Console.ReadLine();
            }

            foreach (var kvp in storeExpressions)
            {
                Console.WriteLine($"{kvp.Key}.{kvp.Value}");
            }
        }
        static Dictionary<string, string> AddExpressions(Dictionary<string, string> storeExpressions, List<string> inputParams)
        {
            string key = inputParams[0];
            string value = inputParams[1];

            storeExpressions[key] = value;

            return storeExpressions;
        }
        static Dictionary<string, string> Dance(Dictionary<string, string> storeExpressions, List<string> inputParams)
        {
            Dictionary<string, string> copy = new Dictionary<string, string>();

            foreach (var kvp in storeExpressions)
            {
                copy.Add(kvp.Key, kvp.Value);
            }

            foreach (var kvp in storeExpressions)
            {
                string selector = GetSelector(kvp);
                copy[kvp.Key] = storeExpressions[kvp.Key].Insert(0, selector);
            }

            return copy;
        }
        static string GetSelector(KeyValuePair<string, string> kvp)
        {
            string selector = string.Empty;

            List<string> list = kvp.Key.Split(' ').ToList();
            selector = list[0] + ".";

            return selector;
        }
    }
}
