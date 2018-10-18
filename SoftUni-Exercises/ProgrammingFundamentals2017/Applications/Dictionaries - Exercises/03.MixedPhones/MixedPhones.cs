using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> dictNameAndPhonePairs = new SortedDictionary<string, long>();
            List<string> listNamesAndPhones = Console.ReadLine().Split(':').ToList();

            while (listNamesAndPhones[0] != "Over")
            {
                string firstElement = listNamesAndPhones[0].Trim();
                string secondElement = listNamesAndPhones[listNamesAndPhones.Count - 1].Trim();
                long phoneNumber;

                bool isSecondElementInt = long.TryParse(secondElement, out phoneNumber);

                if (isSecondElementInt)
                {
                    string name = firstElement;

                    dictNameAndPhonePairs[name] = phoneNumber;
                }
                else
                {
                    string name = secondElement;
                    phoneNumber = long.Parse(firstElement);

                    dictNameAndPhonePairs[name] = phoneNumber;
                }

                listNamesAndPhones = Console.ReadLine().Split(':').ToList();
            }

            foreach (var kvp in dictNameAndPhonePairs)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
