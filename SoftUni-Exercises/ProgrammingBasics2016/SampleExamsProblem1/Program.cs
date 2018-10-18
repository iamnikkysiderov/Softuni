using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamsProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string krisko = new string('.', n) + new string('*', n * 3) + new string('.', n);
            Console.WriteLine(krisko);

            for (int i = 1, j = n-1, k = n*3; i <= n-1; i++,j--, k+=2)
            {
                string marso = new string('.', j) + "*" + new string('.', k) + "*" + new string('.', j);
                Console.WriteLine(marso);
            }

            string bobkata = new string('*', n * 5);
            Console.WriteLine(bobkata);

            for (int i = 1,j = n*5-3; i <= n*2; i++, j-=2)
            {
                string kilata = new string('.', i) + "*" + new string('.', j) + "*" + new string('.', i);
                Console.WriteLine(kilata);
            }
        }
    }
}
