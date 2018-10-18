using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SalesReport
{
    class SalesReport
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Sale> salesByTowns = new Dictionary<string, Sale>();

            for (int i = 0; i < n; i++)
            {
                List<string> inputParams = Console.ReadLine().Split(' ').ToList();
                
                if (!salesByTowns.ContainsKey(inputParams[0]))
                {
                    salesByTowns[inputParams[0]] = new Sale();
                }
                salesByTowns[inputParams[0]].Product = inputParams[1];
                salesByTowns[inputParams[0]].Price = double.Parse(inputParams[2]);
                salesByTowns[inputParams[0]].Quantity = double.Parse(inputParams[3]);
                salesByTowns[inputParams[0]].Value += salesByTowns[inputParams[0]].Quantity * salesByTowns[inputParams[0]].Price;
            }

            foreach (var kvp in salesByTowns.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {salesByTowns[kvp.Key].Value:f2}");
            }
        }
    }
}
