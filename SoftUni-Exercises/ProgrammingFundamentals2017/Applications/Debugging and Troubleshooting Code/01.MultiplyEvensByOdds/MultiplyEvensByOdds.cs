using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int result = GetEvenAndOddSum(n);

            Console.WriteLine(result);
        }

        static int GetEvenAndOddSum(int number)
        {
            int evenSum = 0;
            int oddSum = 0;

            foreach (char symbol in number.ToString())
            {
                int digits = symbol - '0';

                if (digits % 2 == 0)
                {
                    evenSum += digits;
                }
                else if (digits % 2 == 1)
                {
                    oddSum += digits;
                }
            }

            return evenSum * oddSum;
        }
    }
}
