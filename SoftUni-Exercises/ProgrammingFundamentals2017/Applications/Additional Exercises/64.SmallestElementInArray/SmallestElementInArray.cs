using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64.SmallestElementInArray
{
    class SmallestElementInArray
    {
        static void Main(string[] args)
        {
            int[] numbersToCompare = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int minNum = int.MaxValue;

            for (int i = 0; i < numbersToCompare.Length; i++)
            {
                if (numbersToCompare[i] < minNum)
                {
                    minNum = numbersToCompare[i];
                }
            }

            Console.WriteLine(minNum);
        }
    }
}
