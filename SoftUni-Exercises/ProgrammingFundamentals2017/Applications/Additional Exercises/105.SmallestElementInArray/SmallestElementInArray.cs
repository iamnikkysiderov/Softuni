using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105.SmallestElementInArray
{
    class SmallestElementInArray
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int smallestElement = int.MaxValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < smallestElement)
                {
                    smallestElement = numbers[i];
                }
            }

            Console.WriteLine(smallestElement);
        }
    }
}
