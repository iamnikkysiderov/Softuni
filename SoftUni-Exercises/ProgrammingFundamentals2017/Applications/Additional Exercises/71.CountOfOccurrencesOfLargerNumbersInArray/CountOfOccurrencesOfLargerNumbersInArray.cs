using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71.CountOfOccurrencesOfLargerNumbersInArray
{
    class CountOfOccurrencesOfLargerNumbersInArray
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double maximum = double.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
