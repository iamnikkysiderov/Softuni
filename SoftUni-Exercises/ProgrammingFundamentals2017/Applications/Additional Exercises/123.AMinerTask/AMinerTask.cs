using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123.AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> resourceQuantityPairs = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resourceQuantityPairs.ContainsKey(resource))
                {
                    resourceQuantityPairs[resource] = 0;
                }

                resourceQuantityPairs[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var key in resourceQuantityPairs.Keys)
            {
                Console.WriteLine($"{key} -> {resourceQuantityPairs[key]}");
            }
        }
    }
}
