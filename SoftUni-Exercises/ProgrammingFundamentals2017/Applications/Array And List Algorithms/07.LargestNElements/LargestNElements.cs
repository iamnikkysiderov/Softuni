using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LargestNElements
{
    class LargestNElements
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int maxNumber = int.MinValue;

                for (int k = 0; k < numbers.Count; k++)
                {
                    if (numbers[k] > maxNumber)
                    {
                        maxNumber = numbers[k];
                    }
                }

                result.Add(maxNumber);
                numbers.Remove(maxNumber);
            }

            result.Sort();
            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
