using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.EqualSequenceOfElementsInArray
{
    class EqualSequenceOfElementsInArray
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;

            for (int i = 0, j = 1; j < sequence.Length; i++, j++)
            {
                if (sequence[i] != sequence[j])
                {
                    counter++;
                }
            }

            if (counter > 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
