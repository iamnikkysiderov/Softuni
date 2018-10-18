using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();
            DateTime result = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(result.DayOfWeek);
        }
    }
}
