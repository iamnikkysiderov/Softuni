using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int toPower = int.Parse(Console.ReadLine());

            Console.WriteLine(GetResultFromNumberToPower(number, toPower));
        }

        static double GetResultFromNumberToPower(double number, int power)
        {
            double sum = 1;

            for (int i = 1; i <= power; i++)
            {
                sum *= number;
            }

            return sum;
        }
    }
}
