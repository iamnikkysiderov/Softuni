using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103.Winecraft // nereshena
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int numberOfRounds = int.Parse(Console.ReadLine());
            int rounds = 0;

            for (int i = 1; i < grapes.Count - 1; i++)
            {
                int mainGrape = grapes[i];
                int grapeToLeft = grapes[i - 1];
                int grapeToRight = grapes[i + 1];

                for (int k = 0; k < numberOfRounds; k++)
                {
                    if (mainGrape > grapeToLeft && mainGrape > grapeToRight)
                    {
                        grapes[i] += 2;
                        grapes[i - 1] -= 1;
                        grapes[i + 1] -= 1;

                        rounds++;
                    }
                    else
                    {
                        grapes[i - 1] += 1;
                        grapes[i + 1] += 1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", grapes));
        }
    }
}
