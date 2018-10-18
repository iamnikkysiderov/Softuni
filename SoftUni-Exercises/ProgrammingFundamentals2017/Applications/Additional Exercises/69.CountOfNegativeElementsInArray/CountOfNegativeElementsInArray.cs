using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69.CountOfNegativeElementsInArray
{
    class CountOfNegativeElementsInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] storage = new int[n];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                storage[i] = numbers;
            }

            for (int i = 0; i < storage.Length; i++)
            {
                if (storage[i].ToString().Contains("-"))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
