using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(", ",PrintPrimesList(startNum, endNum)));
        }

        static List<int> PrintPrimesList(int start, int end)
        {
            List<int> range = new List<int>();

            for (int i = start, j = 2; i <= end; i++, j++)
            {
                if (IsPrime(i))
                {
                    range.Add(i);
                }
            }

            return range;
        }

        static bool IsPrime(long number)
        {
            if (number == 1 || (number % 2 == 0 && number != 2))
            {
                return false;
            }

            for (long i = 3; i < number; i += 2)
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
