using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            List<string> addOrSearchPhone = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, string> namePhonePairs = new Dictionary<string, string>();

            while (addOrSearchPhone[0] != "END")
            {
                string addOrSearch = addOrSearchPhone[0];
                string name = addOrSearchPhone[1];
                string phoneNumber;

                if (addOrSearch == "A")
                {
                    phoneNumber = addOrSearchPhone[2];

                    namePhonePairs[name] = phoneNumber;
                }
                else if (addOrSearch == "S")
                {
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

                addOrSearchPhone = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
