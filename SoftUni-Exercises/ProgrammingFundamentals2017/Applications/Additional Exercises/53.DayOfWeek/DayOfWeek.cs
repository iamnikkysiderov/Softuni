using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());
            string[] day = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (dayNumber < 1 || dayNumber > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(day[dayNumber - 1]);
            }
        }
    }
}
