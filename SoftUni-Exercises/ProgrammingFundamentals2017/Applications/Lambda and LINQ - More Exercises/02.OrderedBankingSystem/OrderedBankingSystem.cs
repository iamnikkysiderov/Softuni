using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OrderedBankingSystem
{
    class OrderedBankingSystem
    {
        static void Main(string[] args)
        {
            List<string> inputParams = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, Dictionary<string, decimal>> allBanks = new Dictionary<string, Dictionary<string, decimal>>();

            while (inputParams[0] != "end")
            {
                string currentBank = inputParams[0];
                string currentName = inputParams[1];
                decimal moneyOfCurrentName = decimal.Parse(inputParams[2]);

                allBanks = AddBankValues(allBanks, currentBank, currentName, moneyOfCurrentName);

                inputParams = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            allBanks = OrderDescendingBySumValue(allBanks);

            foreach (var kvp in allBanks)
            {
                foreach (var item in allBanks[kvp.Key])
                {
                    Console.WriteLine(allBanks[kvp.Key][item.Key]);
                }
            }
        }
        static Dictionary<string, Dictionary<string, decimal>> AddBankValues(Dictionary<string, Dictionary<string, decimal>> allBanks
            , string currentBank, string currentName, decimal moneyOfCurrentName)
        {
            if (!allBanks.ContainsKey(currentBank))
            {
                allBanks[currentBank] = new Dictionary<string, decimal>();
            }
            if (!allBanks[currentBank].ContainsKey(currentName))
            {
                allBanks[currentBank][currentName] = 0m;
            }
            allBanks[currentBank][currentName] += moneyOfCurrentName;

            return allBanks;
        }
        static Dictionary<string, Dictionary<string, decimal>> OrderDescendingBySumValue(Dictionary<string, Dictionary<string, decimal>> allBanks)
        {
            Dictionary<string, Dictionary<string, decimal>> copy = new Dictionary<string, Dictionary<string, decimal>>();

            foreach (var kvp in allBanks)
            {
                copy.Add(kvp.Key, allBanks[kvp.Key]);
            }

            foreach (var kvp in allBanks)
            {
                copy = copy.OrderByDescending(x => x.Value.Sum(x => x.Value);
            }

            return copy;
        }
    }
}