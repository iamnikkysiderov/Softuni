using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExactProductOfRealNumbers
{
    class ExactProductOfRealNumbers
    {
        static void Main(string[] args)
        {
            int numbersToCalculate = int.Parse(Console.ReadLine());

            decimal sum = decimal.Parse(Console.ReadLine());

            for (int i = 0; i < numbersToCalculate - 1; i++)
            {
                decimal numberToCalculate = decimal.Parse(Console.ReadLine());
                sum *= numberToCalculate;
            }

            Console.WriteLine(sum);
        }
    }
}
