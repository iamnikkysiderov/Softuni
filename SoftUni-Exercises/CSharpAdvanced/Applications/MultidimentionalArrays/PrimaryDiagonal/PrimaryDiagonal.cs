using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryDiagonal
{
    class PrimaryDiagonal
    {
        static void Main(string[] args)
        {
            int rowAndCol = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowAndCol, rowAndCol];
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                sum += inputRow[row];
            }

            Console.WriteLine(sum);
        }
    }
}
