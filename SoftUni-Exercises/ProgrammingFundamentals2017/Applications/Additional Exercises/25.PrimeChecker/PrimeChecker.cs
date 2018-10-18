using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.PrimeChecker
{
    class PrimeChecker
    { // 87/100 Time limit
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(long number)
        {
            if (number == 1 || (number % 2 == 0 && number != 2))
            {
                return false;
            }

            for (long i = 3; i < number; i+=2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
