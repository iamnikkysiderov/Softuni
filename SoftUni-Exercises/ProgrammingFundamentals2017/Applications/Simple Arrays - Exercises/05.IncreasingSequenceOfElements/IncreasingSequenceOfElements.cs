using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.IncreasingSequenceOfElements
{
    class IncreasingSequenceOfElements
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                if (i != sequence.Length - 1)
                {
                    if (sequence[i] > sequence[i + 1])
                    {
                        count++;
                    }
                }
                else
                {
                    if (sequence.Length - 1 < sequence.Length - 2)
                    {
                        count++;
                    }
                }

            }

            if (count > 0)
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
