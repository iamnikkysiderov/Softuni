using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.FibonacciNumber
{
    class FibonacciNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(n));
        }

        static int Fib(int number)
        {
            int a = 1;
            int b = 1;

            for (int i = 0; i < number; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }
    }
}
