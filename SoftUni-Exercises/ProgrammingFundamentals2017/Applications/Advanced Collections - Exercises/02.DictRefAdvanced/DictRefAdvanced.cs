using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DictRefAdvanced
{
    class DictRefAdvanced
    {
        static void Main(string[] args)
        {
            List<string> nameAndValue = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, List<int>> result = new Dictionary<string, List<int>>();

            while (nameAndValue[0] != "end")
            {
                string name = nameAndValue[0].Trim();
                string listOfValues = string.Empty;

                for (int i = 2; i < nameAndValue.Count; i++)
                {
                    listOfValues += nameAndValue[i];
                }

                List<string> valuesStr = listOfValues.Split(',').ToList();

                int check;
                bool integer = int.TryParse(valuesStr[0], out check);

                if (integer)
                {
                    List<int> values = new List<int>();

                    for (int i = 0; i < valuesStr.Count; i++)
                    {
                        values.Add(int.Parse(valuesStr[i]));
                    }

                    if (!result.ContainsKey(name))
                    {
                        result[name] = new List<int>();
                    }
                    result[name].AddRange(values);
                }
                else
                {
                    if (result.ContainsKey(valuesStr[0]))
                    {
                        List<int> copyOfValues = new List<int>();

                        copyOfValues.AddRange(result[valuesStr[0]]);

                        result[name] = copyOfValues;
                    }
                }

                nameAndValue = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} === {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
