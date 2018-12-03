using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoByTwoSquaresInMatrix
{
    class TwoByTwiSquaresInMatrix
    {
        static void Main(string[] args)
        {
            var rowsAndColsParams = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowCount = rowsAndColsParams[0];
            int colCount = rowsAndColsParams[1];
            string[,] matrix = new string[rowCount, colCount];
            int counter = 0;

            for (int row = 0; row < rowCount; row++)
            {
                var inputRow = Console.ReadLine().Split(' ').ToArray();

                for (int col = 0; col < colCount; col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            for (int row = 0; row < rowCount - 1; row++)
            {
                for (int col = 0; col < colCount - 1; col++)
                {
                    if (matrix[row + 1, col] == matrix[row, col + 1] && matrix[row + 1, col] == matrix[row, col] && matrix[row + 1, col] == matrix[row + 1, col + 1] &&
                         matrix[row, col + 1] == matrix[row, col] && matrix[row, col + 1] == matrix[row + 1, col + 1] &&
                         matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
