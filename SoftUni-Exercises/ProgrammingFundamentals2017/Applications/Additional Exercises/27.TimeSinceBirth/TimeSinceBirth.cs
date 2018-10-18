using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.TimeSinceBirth
{
    class TimeSinceBirth
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());

            int days = 365 * years;
            int hours = 24 * days;
            int minutes = 60 * hours;

            Console.WriteLine("{0} years = {1} days {2} hours = {3} minutes.",years,days,hours,minutes);
        }
    }
}
