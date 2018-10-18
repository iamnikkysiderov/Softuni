using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58.MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginning = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxCombos = int.Parse(Console.ReadLine());

            for (int i = beginning, j = beginning, combos = 1; j <= end; combos++, j++)
            {
                if (i <= end && j <= end)
                {
                    Console.Write("<{0}-{1}>", i, j);

                    if (j == end)
                    {
                        ++i;
                        j = beginning - 1;
                    }

                    if (combos == maxCombos)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
