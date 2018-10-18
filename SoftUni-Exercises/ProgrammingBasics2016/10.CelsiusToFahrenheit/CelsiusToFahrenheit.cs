using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(c * 9 / 5 + 32, 2));
        }
    }
}
