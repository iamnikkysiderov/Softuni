using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CircleArea_12DigitsPrecision_
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f12}", Math.PI * a * a);
        }
    }
}
