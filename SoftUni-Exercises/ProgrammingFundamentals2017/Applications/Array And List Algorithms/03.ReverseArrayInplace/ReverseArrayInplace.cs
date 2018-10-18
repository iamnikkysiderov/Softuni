using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReverseArrayInPlace
{
    class ReverseArrayInPlace
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ", Reverse(numbers)));
        }

        static List<int> Reverse(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int number = numbers[i];
                int numberFromTheBack = numbers[numbers.Count - i - 1];

                numbers[i] = numberFromTheBack;
                numbers[numbers.Count - i - 1] = number;
            }

            return numbers;
        }
    }
}
