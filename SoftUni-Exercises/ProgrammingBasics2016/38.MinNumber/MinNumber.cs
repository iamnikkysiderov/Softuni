using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            double numbers = double.Parse(Console.ReadLine());
            double updateNums = 1;
            double min = double.MaxValue;

            while (updateNums <= numbers)
            {
                updateNums++;
                double numToCompare = double.Parse(Console.ReadLine());

                if (numToCompare < min)
                {
                    min = numToCompare;
                }
            }

            Console.WriteLine(min);
        }
    }
}
