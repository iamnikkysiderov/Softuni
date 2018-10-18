using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61.LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main(string[] args) // Nereshena
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] sequence = new int[n];

            for (int i = 1; i <= n; i++)
            {
                sequence[i - 1] = i;
            }
        }
    }
}
