using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareWithMaximumSum
{
    class SquareWithMaximumSum
    {
        static void Main(string[] args)
        {
            var rowsAndColsParams = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndColsParams[0], rowsAndColsParams[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int maxSum = int.MinValue;
            int rowIndex = 0;
            int colIndex = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            for (int row = rowIndex; row < rowIndex + 2; row++)
            {
                for (int col = colIndex; col < colIndex + 2; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
