using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
