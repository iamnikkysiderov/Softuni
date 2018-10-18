using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StabilityCheck
{
    class StabilityCheck
    {
        static void Main(string[] args)
        {
            int sizeOfBuilding = int.Parse(Console.ReadLine());
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    matrix[j, i] = input[j];
                }
            }

            int sum = 0;
            int counterCols = 1;
            int cicles = 0;
            int nextCicle = 0;
            List<int> sums = new List<int>();
            bool onOff = false;

            for (int i = nextCicle; i < sizeOfMatrix; i++)
            {
                int counterRows = 1;

                for (int j = cicles; j < sizeOfMatrix; j++)
                {
                    sum += matrix[j, i];
                    counterRows++;

                    if (counterRows > sizeOfBuilding)
                    {
                        if (j == sizeOfMatrix - 1 && onOff)
                        {
                            nextCicle++;

                            onOff = false;
                            break;
                        }

                        break;
                    }
                }

                if (counterCols >= sizeOfBuilding)
                {
                    counterCols = 0;
                    i = nextCicle - 1;
                    cicles++;
                    sums.Add(sum);
                    sum = 0;
                }

                counterCols++;
            }

            Console.WriteLine(sums.Max());
        }
    }
}
