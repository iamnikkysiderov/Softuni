using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DictRef
{
    class DictRef
    {
        static void Main(string[] args)
        {
            List<string> nameAndValue = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, int> result = new Dictionary<string, int>();

            while (nameAndValue[0] != "end")
            {
                string name = nameAndValue[0].Trim();
                string valueString = nameAndValue[nameAndValue.Count - 1].Trim();

                int value;
                bool integer = int.TryParse(valueString, out value);

                if (integer)
                {
                    result[name] = value;
                }
                else
                {
                    if (result.ContainsKey(valueString))
                    {
                        result[name] = result[valueString];
                    }
                }

                nameAndValue = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
