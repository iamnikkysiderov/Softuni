using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, HashSet<ulong>> shells = new Dictionary<string, HashSet<ulong>>();

            while (input[0] != "Aggregate")
            {
                string region = input[0];
                ulong size = ulong.Parse(input[1]);

                if (!shells.ContainsKey(region))
                {
                    shells[region] = new HashSet<ulong>();
                }
                shells[region].Add(size);

                input = Console.ReadLine().Split(' ').ToList();
            }

            foreach (var kvp in shells)
            {
                string currentRegion = kvp.Key;
                List<ulong> sizesOfCurrentShells = kvp.Value.ToList();
                ulong giantShell = 0;

                for (int i = 0; i < sizesOfCurrentShells.Count; i++)
                {
                    giantShell += sizesOfCurrentShells[i];
                }

                giantShell = giantShell - giantShell / (ulong)sizesOfCurrentShells.Count;

                Console.WriteLine($"{currentRegion} -> {string.Join(", ", sizesOfCurrentShells)} ({giantShell})");
            }
        }
    }
}
