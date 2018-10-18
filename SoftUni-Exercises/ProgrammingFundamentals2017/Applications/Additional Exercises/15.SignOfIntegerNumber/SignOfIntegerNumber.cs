using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.SignOfIntegerNumber
{
    class SignOfIntegerNumber
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            NumbersSign(num);
        }
        static void NumbersSign(int n)
        {
            if (n > 0)
            {
                Console.WriteLine("The number {0} is positive.",n);
            }
            else if (n < 0)
            {
                Console.WriteLine("The number {0} is negative.",n);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.",n);
            }
        }
    }
}
