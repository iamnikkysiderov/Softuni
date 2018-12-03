using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMatrixElements
{
    class SumMatrixElements
    {
        static void Main(string[] args)
        {
            var inputParams = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[,] matrix = new int[inputParams[0], inputParams[1]];
            int totalMatrixSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputMatrixValueParams = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputMatrixValueParams[col];
                }
            }

            Console.WriteLine(inputParams[0]);
            Console.WriteLine(inputParams[1]);

            foreach (var item in matrix)
            {
                totalMatrixSum += item;
            }

            Console.WriteLine(totalMatrixSum);
        }
    }
}
