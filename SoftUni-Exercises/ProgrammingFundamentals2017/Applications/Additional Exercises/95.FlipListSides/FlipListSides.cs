using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _95.FlipListSides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            List<int> numbersToFlip = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>(numbersToFlip.Count);

            result.Add(numbersToFlip[0]);

            for (int i = 1, j = 2; i < numbersToFlip.Count-1; i++, j++)
            {
                result.Add(numbersToFlip[numbersToFlip.Count - j]);
            }

            result.Add(numbersToFlip[numbersToFlip.Count - 1]);

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
