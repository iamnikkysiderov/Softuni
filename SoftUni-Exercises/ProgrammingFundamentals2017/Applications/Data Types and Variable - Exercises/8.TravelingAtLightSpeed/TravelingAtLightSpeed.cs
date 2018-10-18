using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TravelingAtLightSpeed
{
    class TravelingAtLightSpeed
    {
        static void Main(string[] args)
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());
            decimal kilometers = lightYears * 9450000000000;
            decimal speedOfLightInSecond = 300000;
            decimal seconds = kilometers / speedOfLightInSecond;
            decimal minutes = seconds / 60;
            seconds %= 60;
            decimal hours = minutes / 60;
            minutes %= 60;
            decimal days = hours / 24;
            hours %= 24;
            decimal weeks = days / 7;
            days %= 7;

            Console.WriteLine("{0} weeks", (int)weeks);
            Console.WriteLine("{0} days", (int)days);
            Console.WriteLine("{0} hours", (int)hours);
            Console.WriteLine("{0} minutes", (int)minutes);
            Console.WriteLine("{0} seconds", (int)seconds);

        }
    }
}
