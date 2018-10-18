using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60.SleepyTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesNorm = 30000;
            int gamesNormDay = 30000 / 365;
            int onWorkDay = 63;
            int offWorkDay = 127;

            int restDays = int.Parse(Console.ReadLine());

            int gamesRestYear = restDays * offWorkDay;
            int gamesOnWorkYear = (365 - restDays) * onWorkDay;
            int total = gamesOnWorkYear + gamesRestYear;

            if (gamesNorm > total)
            {
                TimeSpan leftMinutes = TimeSpan.FromMinutes(gamesNorm - total);
                int hours = (int)leftMinutes.TotalHours;
                int minutes = leftMinutes.Minutes;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
            else
            {
                TimeSpan moreThanEnough = TimeSpan.FromMinutes(total - gamesNorm);
                int hours = (int)moreThanEnough.TotalHours;
                int minutes = moreThanEnough.Minutes;

                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
        }
    }
}
