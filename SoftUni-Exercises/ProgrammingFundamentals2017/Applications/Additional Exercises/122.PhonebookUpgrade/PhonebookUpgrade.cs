using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122.PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            List<string> addOrSearchPhone = Console.ReadLine().Split(' ').ToList();
            SortedDictionary<string, string> namePhonePairs = new SortedDictionary<string, string>();

            while (addOrSearchPhone[0] != "END")
            {
                string addOrSearch = addOrSearchPhone[0];
                string name;
                string phoneNumber;

                if (addOrSearch == "A")
                {
                    name = addOrSearchPhone[1];
                    phoneNumber = addOrSearchPhone[2];

                    namePhonePairs[name] = phoneNumber;
                }
                else if (addOrSearch == "S")
                {
                    name = addOrSearchPhone[1];
                    bool exist = namePhonePairs.ContainsKey(name);

                    if (exist == true)
                    {
                        Console.WriteLine($"{name} -> {namePhonePairs[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (addOrSearch == "ListAll")
                {
                    foreach (var key in namePhonePairs.Keys)
                    {
                        Console.WriteLine($"{key} -> {namePhonePairs[key]}");
                    }
                }

                addOrSearchPhone = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
