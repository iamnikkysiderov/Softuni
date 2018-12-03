using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMatrixColumns
{
    class SumMatrixColumns
    {
        static void Main(string[] args)
        {
            var inputRowsColsParams = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[,] matrix = new int[inputRowsColsParams[0], inputRowsColsParams[1]];
            int[] sum = new int[inputRowsColsParams[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputParams = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputParams[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum[col] += matrix[row, col];
                }
            }

            foreach (var item in sum)
            {
                Console.WriteLine(item);
            }
        }
    }
}
