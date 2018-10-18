using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int bigNum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (bigNum < num)
                {
                    bigNum = num;
                }

            }

            sum = sum - bigNum;

            if (sum == bigNum)
            {
                Console.WriteLine("Yes Sum = {0}", bigNum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(sum - bigNum));
            }
        }
    }
}
