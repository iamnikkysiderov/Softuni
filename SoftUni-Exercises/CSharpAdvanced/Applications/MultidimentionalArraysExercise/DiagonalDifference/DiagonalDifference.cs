using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int rowAndCol = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowAndCol, rowAndCol];
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            if (rowAndCol > 0)
            {
                for (int row = 0, secondRow = matrix.GetLength(0) - 1; row < matrix.GetLength(0); row++, secondRow--)
                {
                    var inputRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                    primaryDiagonalSum += inputRow[row];
                    secondaryDiagonalSum += inputRow[secondRow];
                }

                Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
            }
        }
    }
}
