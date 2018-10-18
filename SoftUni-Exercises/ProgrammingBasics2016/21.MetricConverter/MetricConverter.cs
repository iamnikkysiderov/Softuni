using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            //Reshih ya ama ne ya razbrah... :D
            double unitSum = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            if (inputUnit == "m") unitSum = unitSum / 1;
            else if (inputUnit == "mm") unitSum = unitSum / 1000;
            else if (inputUnit == "cm") unitSum = unitSum / 100;
            else if (inputUnit == "mi") unitSum = unitSum / 0.000621371192;
            else if (inputUnit == "in") unitSum = unitSum / 39.3700787;
            else if (inputUnit == "km") unitSum = unitSum / 0.001;
            else if (inputUnit == "ft") unitSum = unitSum / 3.2808399;
            else if (inputUnit == "yd") unitSum = unitSum / 1.0936133;

            if (outputUnit == "m") unitSum = unitSum * 1;
            else if (outputUnit == "mm") unitSum = unitSum * 1000;
            else if (outputUnit == "cm") unitSum = unitSum * 100;
            else if (outputUnit == "mi") unitSum = unitSum * 0.000621371192;
            else if (outputUnit == "in") unitSum = unitSum * 39.3700787;
            else if (outputUnit == "km") unitSum = unitSum * 0.001;
            else if (outputUnit == "ft") unitSum = unitSum * 3.2808399;
            else if (outputUnit == "yd") unitSum = unitSum * 1.0936133;

            Console.WriteLine(unitSum);
        }
    }
}
