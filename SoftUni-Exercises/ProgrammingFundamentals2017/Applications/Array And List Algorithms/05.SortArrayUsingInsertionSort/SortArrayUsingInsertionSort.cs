using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortArrayUsingInsertionSort
{
    class SortArrayUsingInsertionSort
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int k = 0; k < numbers.Count; k++)
            {
                for (int i = 1; i < numbers.Count; i++)
                {
                    int current = numbers[i];
                    int previous = numbers[i - 1];

                    while (current < previous)
                    {
                        numbers.Remove(numbers[i]);
                        numbers.Insert(i - 1, current);

                        current = numbers[i];
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
