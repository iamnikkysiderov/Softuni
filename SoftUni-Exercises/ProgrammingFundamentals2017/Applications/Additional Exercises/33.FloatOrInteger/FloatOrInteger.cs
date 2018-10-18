using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.FloatOrInteger
{
    class FloatOrInteger
    {
        static void Main(string[] args)
        {
            double numberToCheck = double.Parse(Console.ReadLine());

            if (numberToCheck.ToString().Contains("."))
            {
                numberToCheck = Math.Round(numberToCheck);
            }

            Console.WriteLine(numberToCheck);
        }
    }
}
