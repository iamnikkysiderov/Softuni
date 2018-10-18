using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68.LargestElementInArray
{
    class LargestElementInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] storage = new int[n];
            int maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int numberToCompare = int.Parse(Console.ReadLine());
                storage[i] = numberToCompare;
            }

            for (int i = 0; i < storage.Length; i++)
            {
                if (storage[i] > maxNumber)
                {
                    maxNumber = storage[i];
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
