using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            numbers.Sort();

            Console.Write(numbers[0]);

            for (int i = 1; i < numbers.Count; i++)
            {
                Console.Write(" <= {0}", numbers[i]);
            }
        }
    }
}
