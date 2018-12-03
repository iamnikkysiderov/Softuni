using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] jaggedArray = new long[n][];
            bool smallN = false;

            switch (n)
            {
                case 1:
                    Console.WriteLine(1);
                    smallN = true;
                    break;
                case 2:
                    Console.WriteLine(1 + " " + 1);
                    smallN = true;
                    break;
            }

            if (smallN == false && n > 0 && n <= 60)
            {
                jaggedArray[0] = new long[1];
                jaggedArray[1] = new long[2];
                jaggedArray[0][0] = 1;
                jaggedArray[1][0] = 1;
                jaggedArray[1][1] = 1;

                for (int row = 2; row < n; row++)
                {
                    jaggedArray[row] = new long[row + 1];

                    for (int col = 0; col < row + 1; col++)
                    {
                        if (col == 0)
                        {
                            jaggedArray[row][col] = 1;
                        }
                        else if (col == row)
                        {
                            jaggedArray[row][col] = 1;
                        }
                        else
                        {
                            jaggedArray[row][col] = jaggedArray[row - 1][col - 1] + jaggedArray[row - 1][col];
                        }
                    }
                }
            }

            foreach (var subString in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", subString));
            }
        }
    }
}
