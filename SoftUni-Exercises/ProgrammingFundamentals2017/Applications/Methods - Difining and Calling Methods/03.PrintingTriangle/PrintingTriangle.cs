using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Print(n);
        }
        static void Print(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");

                }
                Console.WriteLine();
            }
            for (int row = n - 1; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");

                }
                Console.WriteLine();
            }
        }

    }
}
