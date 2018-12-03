using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            var rowAndColParams = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowCount = rowAndColParams[0];
            int colCount = rowAndColParams[1];
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string[,] matrix = new string[rowCount, colCount];

            if (rowCount + colCount <= 27)
            {
                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        matrix[row, col] = alphabet[row].ToString() + alphabet[col + row].ToString() + alphabet[row].ToString();
                    }
                }

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
