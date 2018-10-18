using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.InchesToCentimeters
{
    class InchesToCentimeters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input inches:");
            double inches = double.Parse(Console.ReadLine());
            double cm = inches * 2.54;
            Console.WriteLine("Result in centimeters is {0}", cm);
        }
    }
}
