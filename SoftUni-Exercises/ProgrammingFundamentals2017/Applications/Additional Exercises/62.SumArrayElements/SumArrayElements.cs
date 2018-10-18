using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62.SumArrayElements
{
    class SumArrayElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbersToSum = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbersToSum[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            foreach (int number in numbersToSum)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
