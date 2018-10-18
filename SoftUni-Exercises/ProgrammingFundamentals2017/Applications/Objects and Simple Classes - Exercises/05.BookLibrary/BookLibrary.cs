using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BookLibrary
{
    class BookLibrary
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> result = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                List<string> inputParams = Console.ReadLine().Split(' ').ToList();
                string author = inputParams[1];
                double price = double.Parse(inputParams[inputParams.Count - 1]);

                if (!result.ContainsKey(author))
                {
                    result[author] = 0.0;
                }
                result[author] += price;
            }

            foreach (var kvp in result.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }
    }
}
