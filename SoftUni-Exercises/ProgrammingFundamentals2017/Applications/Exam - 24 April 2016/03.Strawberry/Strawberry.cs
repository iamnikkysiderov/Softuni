using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Strawberry
{
    class Strawberry
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1, j = 0, k = n; i <= n / 2; i++, j += 2, k -= 2)
            {
                Console.WriteLine(new string('-', j) + new string('\\', 1) + new string('-', k) + "|" + new string('-', k) + new string('/', 1) + new string('-', j));
            }

            double rows = Math.Ceiling((double)n / 2);

            for (int i = 1, j = n, k = 1; i <= rows; i++, j -= 2, k += 4)
            {
                Console.WriteLine(new string('-', j) + "#" + new string('.', k) + "#" + new string('-', j));
            }

            Console.WriteLine("#" + new string('.', n * 2 + 1) + "#");

            for (int i = 1, j = n * 2 - 1; i <= n; i++, j -= 2)
            {
                Console.WriteLine(new string('-', i) + "#" + new string('.', j) + "#" + new string('-', i));
            }
        }
    }
}
