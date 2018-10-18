using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.AddingNumbersWithForLoop
{
    class AddingNumbersWithForLoop
    {
        static void Main(string[] args)
        {
            int totalNumbers = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int ifNumbers = 1; ifNumbers <= totalNumbers; ifNumbers++)
            {
                int numToCalculate = int.Parse(Console.ReadLine());
                sum = sum + numToCalculate;
            }

            Console.WriteLine(sum);
        }
    }
}
