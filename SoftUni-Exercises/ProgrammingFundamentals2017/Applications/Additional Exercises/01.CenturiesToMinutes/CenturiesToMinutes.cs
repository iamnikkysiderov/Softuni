using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int centuriesToYears = centuries * 100;
            int centuriesToDays = (int)(365.2422 * centuriesToYears);
            int centuriesToHours = 24 * centuriesToDays;
            int centuriesToMinutes = 60 * centuriesToHours;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, centuriesToYears, centuriesToDays, centuriesToHours, centuriesToMinutes);
        }
    }
}
