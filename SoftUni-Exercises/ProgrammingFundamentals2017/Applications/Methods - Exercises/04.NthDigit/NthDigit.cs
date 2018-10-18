using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NthDigit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            int result = FindNthDigit(number, index);
            Console.WriteLine(result);
        }

        static int FindNthDigit(int number, int index)
        {
            int nthDigit = 0;

            while (index - 1 > 0)
            {
                number = number / 10;
                index--;
            }
            nthDigit = number % 10;

            return nthDigit;
        }
    }
}
