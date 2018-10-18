using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63.MultiplyAnArrayOfDoubles
{
    class MultiplyAnArrayOfDoubles
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double numberToMultiplyWith = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= numberToMultiplyWith;
            }

            string result = string.Join(" ", numbers);

            Console.WriteLine(result);
        }
    }
}
