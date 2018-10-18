using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayElementsEqualToTheirIndex
{
    class ArrayElementsEqualToTheirIndex
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int index = 0; index < numbers.Length; index++)
            {
                if (index == numbers[index])
                {
                    Console.Write(numbers[index] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
