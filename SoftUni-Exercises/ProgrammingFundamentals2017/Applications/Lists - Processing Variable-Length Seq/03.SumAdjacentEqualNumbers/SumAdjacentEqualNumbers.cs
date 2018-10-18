using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            decimal sum = 0;

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
                {
                    sum = input[i] + input[i - 1];
                    input[i - 1] = sum;
                    input.RemoveAt(i);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
