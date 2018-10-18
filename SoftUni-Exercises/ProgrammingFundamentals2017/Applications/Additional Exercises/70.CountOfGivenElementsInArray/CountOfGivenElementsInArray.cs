using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70.CountOfGivenElementsInArray
{
    class CountOfGivenElementsInArray
    {
        static void Main(string[] args)
        {
            int[] storage = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberToRepeat = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < storage.Length; i++)
            {
                if (numberToRepeat == storage[i])
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
