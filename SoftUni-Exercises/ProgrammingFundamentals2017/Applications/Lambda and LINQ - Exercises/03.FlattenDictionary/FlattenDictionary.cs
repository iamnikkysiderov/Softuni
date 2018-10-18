using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FlattenDictionary
{
    class FlattenDictionary
    {
        static void Main(string[] args)
        {
            List<string> tokens = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, Dictionary<string, string>> categories = new Dictionary<string, Dictionary<string, string>>();

            while (tokens[0] != "end")
            {
                if (tokens[0] == "flatten")
                {
                    string categoryToFlatten = tokens[1];
                    categories = FlattenElementsInCategory(categories, categoryToFlatten);
                }
                else
                {
                    string currentCategory = tokens[0];
                    string currentSubCategory = tokens[1];
                    string currentModel = tokens[2];
                    categories = AddToDict(categories, currentCategory, currentSubCategory, currentModel);
                }

                tokens = Console.ReadLine().Split(' ').ToList();
            }

            PrintResult(categories);
        }
        static Dictionary<string, Dictionary<string, string>> AddToDict(Dictionary<string, Dictionary<string, string>> categories
            , string currentCategory, string currentSubCategory, string currentModel)
        {
            if (!categories.ContainsKey(currentCategory))
            {
                categories[currentCategory] = new Dictionary<string, string>();
            }
            categories[currentCategory][currentSubCategory] = currentModel;

            return categories;
        }
        static Dictionary<string, Dictionary<string, string>> FlattenElementsInCategory(Dictionary<string, Dictionary<string, string>> categories
            , string categoryToFlatten)
        {
            if (categories.ContainsKey(categoryToFlatten))
            {
                List<string> flattened = new List<string>();

                Dictionary<string, string> copy = new Dictionary<string, string>();

                foreach (var kvp in categories[categoryToFlatten])
                {
                    copy.Add(kvp.Key + kvp.Value, string.Empty);
                }

                categories.Remove(categoryToFlatten);

                categories[categoryToFlatten] = new Dictionary<string, string>();

                foreach (var kvp in copy)
                {
                    categories[categoryToFlatten].Add(kvp.Key, string.Empty);
                }

            }

            return categories;
        }
        static void PrintResult(Dictionary<string, Dictionary<string, string>> categories)
        {
            foreach (var kvp in categories.OrderByDescending(x => x.Key.Length))
            {
                Console.WriteLine(kvp.Key);
                var innerDict = kvp.Value;

                int index = 0;

                foreach (var item in innerDict.OrderBy(x => x.Key.Length))
                {

                    if (item.Value != "")
                    {
                        index++;
                        Console.WriteLine($"{index}. {item.Key} - {item.Value}");
                    }

                }
                foreach (var item in innerDict)
                {
                    if (item.Value == "")
                    {
                        index++;
                        Console.WriteLine($"{index}. {item.Key}");
                    }
                }
            }
        }
        static string ConvertCharsToString(List<char> flattenedToChar)
        {
            string converted = string.Empty;

            foreach (var character in flattenedToChar)
            {
                converted += character;
            }

            return converted;
        }
    }
}