using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double evenSum = 0;
            double oddSum = 0;
            double bigEven = double.MinValue;
            double smallEven = double.MaxValue;
            double bigOdd = double.MinValue;
            double smallOdd = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    double oddNum = double.Parse(Console.ReadLine());
                    oddSum += oddNum;

                    if (bigOdd < oddNum)
                    {
                        bigOdd = oddNum;
                    }
                    if (smallOdd > oddNum)
                    {
                        smallOdd = oddNum;
                    }
                }
                else
                {
                    double evenNum = double.Parse(Console.ReadLine());
                    evenSum += evenNum;

                    if (bigEven < evenNum)
                    {
                        bigEven = evenNum;
                    }
                    if (smallEven > evenNum)
                    {
                        smallEven = evenNum;
                    }
                }
            }

            if (n != 0 && n != 1)
            {
                Console.WriteLine("OddSum = {0}, OddMin = {1}, OddMax = {2}, EvenSum = {3}, EvenMin = {4}, EvenMax = {5}", oddSum, smallOdd, bigOdd, evenSum, smallEven, bigEven);
            }
            else if (n == 0)
            {
                Console.WriteLine("OddSum = 0, OddMin = No, OddMax = No, EvenSum = 0, EvenMin = No, EvenMax = No");
            }
            else if (n == 1)
            {
                Console.WriteLine("OddSum = {0}, OddMin = {0}, OddMax = {0}, EvenSum = 0, EvenMin = No, EvenMax = No", oddSum);
            }
        }
    }
}
