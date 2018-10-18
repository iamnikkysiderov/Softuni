using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            double lengthOfTrack = int.Parse(Console.ReadLine());
            double capacityOfTrack = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            double totalRunners = capacityOfTrack * days;

            if (totalRunners >= runners)
            {
                double totalMeters = runners * laps * lengthOfTrack;
                double totalKm = totalMeters / 1000.0;
                double totalMoney = totalKm * moneyPerKm;

                Console.WriteLine("Money raised: {0:f2}", totalMoney);
            }
            else
            {
                double totalMeters = totalRunners * laps * lengthOfTrack;
                double totalKm = totalMeters / 1000.0;
                double totalMoney = totalKm * moneyPerKm;

                Console.WriteLine("Money raised: {0:f2}", totalMoney);
            }
        }
    }
}
