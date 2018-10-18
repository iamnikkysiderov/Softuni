using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum = 0;
                int num = i;
                Console.Write(i + " -> ");

                int lastDigit = 0;

                while (num != 0)
                {
                    lastDigit = num % 10;
                    num = num / 10;
                    sum = lastDigit + sum;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }

            }
        }
    }
}
