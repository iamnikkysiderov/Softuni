using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int firstSum = 0;
            int secondSum = 0;

            for (int update = 1; update <= numbers; update++)
            {
                int nums = int.Parse(Console.ReadLine());
                firstSum += nums;
            }

            for (int update = 1; update <= numbers; update++)
            {
                int nums = int.Parse(Console.ReadLine());
                secondSum += nums;
            }

            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes, sum = {0}", firstSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(firstSum - secondSum));
            }
        }
    }
}
