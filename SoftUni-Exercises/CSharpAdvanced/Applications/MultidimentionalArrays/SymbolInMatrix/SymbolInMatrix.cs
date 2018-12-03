using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolInMatrix
{
    class SymbolInMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            bool found = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentRow = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            char elementToSearch = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == elementToSearch)
                    {
                        found = true;
                        Console.WriteLine("({0}, {1})", row, col);
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }

            if (found == false)
            {
                Console.WriteLine("{0} does not occur in the matrix", elementToSearch);
            }
        }
    }
}
