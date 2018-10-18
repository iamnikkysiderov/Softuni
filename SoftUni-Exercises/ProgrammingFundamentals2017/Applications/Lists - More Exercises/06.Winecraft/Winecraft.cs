using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Winecraft // nereshena
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int numberOrRounds = int.Parse(Console.ReadLine());
            int rounds = 0;

            for (int i = 0; i < grapes.Count; i++)
            {
                try
                {
                    if (grapes[i] > grapes[i - 1] && grapes[i] > grapes[i + 1])
                    {
                        grapes[i] += 2;
                        grapes[i - 1]--;
                        grapes[i + 1]++;
                    }
                    else if (grapes[i] < grapes[i+1] && grapes[i+2] < grapes[i+1])
                    {
                        grapes[i]--;
                        grapes[i + 1] += 2;
                        grapes[i + 2]--;
                    }
                    else if (grapes[i] < grapes[i - 1] && grapes[i - 2] < grapes[i + 1])
                    {
                        grapes[i]--;
                        grapes[i - 1] += 2;
                        grapes[i - 2]--;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    grapes[i]++;
                }
            }

            Console.WriteLine(string.Join(" ", grapes));
        }
    }
}
