using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortEvenNumbers
{
    class SortEvenNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(", ", input.Where(x => x % 2 == 0).OrderBy(x => x)));
        }
    }
}
