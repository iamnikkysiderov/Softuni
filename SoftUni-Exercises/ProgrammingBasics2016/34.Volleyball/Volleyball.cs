using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsNaSelo = double.Parse(Console.ReadLine());

            double totalWeekends = 48;
            double weekendsInSofia = totalWeekends - weekendsNaSelo;
            double gamesInSofia = weekendsInSofia * (3.0 / 4);
            double gamesNaSelo = weekendsNaSelo * 1;
            double gamesOnHolidays = holidays * (2.0 / 3);
            double totalGames = gamesInSofia + gamesNaSelo + gamesOnHolidays;

            if (year == "leap")
            {
                totalGames = totalGames + (15.0 / 100 * totalGames);
                Console.WriteLine(Math.Truncate(totalGames));
            }
            else if (year == "normal")
            {
                Console.WriteLine(Math.Truncate(totalGames));
            }
        }
    }
}
