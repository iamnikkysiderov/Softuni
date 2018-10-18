using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortArrayUsingBubbleSort
{
    class SortArrayUsingBubbleSort
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            bool swapped = true;

            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    int current = numbers[i];
                    int next = numbers[i + 1];

                    if (current > next)
                    {
                        numbers[i] = next;
                        numbers[i + 1] = current;

                        swapped = true;
                    }
                }

            } while (swapped);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
