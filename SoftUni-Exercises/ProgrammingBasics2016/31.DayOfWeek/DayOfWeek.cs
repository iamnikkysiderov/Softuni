using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    day = 1;
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    day = 2;
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    day = 3;
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    day = 4;
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    day = 5;
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    day = 6;
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    day = 7;
                    Console.WriteLine("Sunday");
                    break;
                case 8:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
