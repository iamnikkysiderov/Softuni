using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(n));
        }

        static int GetFibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            else
            {
                return GetFibonacci(n - 1) + GetFibonacci(n - 2);
            }
        }
    }
}
