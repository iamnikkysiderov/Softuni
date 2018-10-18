using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OptimizedBankingSystem
{
    class OptimizedBankingSystem
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<Person, decimal> storage = new Dictionary<Person, decimal>();

            while (input != "end")
            {
                List<string> inputParams = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Person currentPerson = new Person();
                currentPerson.Bank = inputParams[0];
                currentPerson.Name = inputParams[1];
                decimal balance = decimal.Parse(inputParams[2]);

                if (!storage.ContainsKey(currentPerson))
                {
                    storage[currentPerson] = 0m;
                }

                storage[currentPerson] += balance;

                input = Console.ReadLine();
            }

            Print(storage);
        }
        static void Print(Dictionary<Person, decimal> storage)
        {
            foreach (var kvp in storage.OrderByDescending(x => x.Value).ThenBy(x => x.Key.Bank))
            {
                Person currentPerson = kvp.Key;
                decimal balance = kvp.Value;

                Console.WriteLine($"{currentPerson.Name} -> {balance} ({currentPerson.Bank})");
            }
        }
    }
}
