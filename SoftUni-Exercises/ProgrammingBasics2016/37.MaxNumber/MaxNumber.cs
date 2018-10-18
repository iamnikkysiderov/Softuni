using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37.MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            double numbers = double.Parse(Console.ReadLine());
            double updateNums = 1;
            double max = double.MinValue;

            while (updateNums <= numbers)
            {
                updateNums++;
                double numToCompare = double.Parse(Console.ReadLine());

                if (numToCompare > max)
                {
                    max = numToCompare;
                }
            }

            Console.WriteLine(max);
        }
    }
}
