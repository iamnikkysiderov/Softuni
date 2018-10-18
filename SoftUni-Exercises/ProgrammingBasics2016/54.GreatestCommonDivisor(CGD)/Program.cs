using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.GreatestCommonDivisor_CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int temp = 0;

            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            while (b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            Console.WriteLine(a);
        }
    }
}
