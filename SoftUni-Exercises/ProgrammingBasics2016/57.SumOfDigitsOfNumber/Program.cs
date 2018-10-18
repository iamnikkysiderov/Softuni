using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.SumOfDigitsOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 3456

            int sum = 0;

            while (n > 0) // 3456; 34
            {
                int lastDigit = n % 10; // 6; 4
                n = n / 10; // 345; 3
                int lastDigit2 = n % 10; // 5; 3
                n = n / 10; // 34; 0
                sum = sum + lastDigit + lastDigit2; // 6 + 5; 4 + 3
            }
            Console.WriteLine(sum);
        }
    }
}
