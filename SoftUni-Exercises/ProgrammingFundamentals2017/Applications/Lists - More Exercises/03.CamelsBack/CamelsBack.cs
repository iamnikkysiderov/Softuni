using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CamelsBack
{
    class CamelsBack
    {
        static void Main(string[] args)
        {
            List<int> buildings = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelBackSize = int.Parse(Console.ReadLine());

            int rounds = 0;

            if (buildings.Count > camelBackSize)
            {
                for (int i = 0; i < buildings.Count;)
                {
                    buildings.RemoveAt(i);
                    buildings.Reverse();
                    buildings.RemoveAt(i);
                    buildings.Reverse();

                    rounds++;

                    if (buildings.Count == camelBackSize)
                    {
                        break;
                    }
                }

                Console.WriteLine("{0} rounds", rounds);
                Console.WriteLine("remaining: {0}", string.Join(" ", buildings));
            }
            else if (buildings.Count == camelBackSize)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", buildings));
            }
        }
    }
}