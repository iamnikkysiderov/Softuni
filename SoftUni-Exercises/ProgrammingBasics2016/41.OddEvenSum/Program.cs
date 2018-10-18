using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbers = double.Parse(Console.ReadLine());

            int firstSum = 0;
            int secondSum = 0;
            
            for (int i = 0; i < numbers; i++)
            {
                if (i % 2 == 0)
                {
                    int num = int.Parse(Console.ReadLine());
                    firstSum += num;
                }
                else
                {
                    int num1 = int.Parse(Console.ReadLine());
                    secondSum += num1;
                }
            }

            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes Sum = {0}", firstSum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(firstSum - secondSum));
            }
        }
    }
}
