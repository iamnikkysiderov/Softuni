using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Batteries
    {
        static void Main(string[] args)
        {
            List<double> batteriesCapacities = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int hours = int.Parse(Console.ReadLine());
            List<double> result = new List<double>();

            for (int i = 0; i < batteriesCapacities.Count; i++)
            {
                double currentBattery = batteriesCapacities[i];
                bool batteryDead = false;
                int hoursTillDead = 0;

                for (int h = hours; h > 0; h--)
                {
                    currentBattery -= usagePerHour[i];
                    hoursTillDead++;

                    if (currentBattery <= 0)
                    {
                        Console.WriteLine("Battery {0}: dead (lasted {1} hours)", i + 1, hoursTillDead);
                        batteryDead = true;
                        break;
                    }
                }

                if (batteryDead == false)
                {
                    Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%", i + 1, currentBattery, currentBattery / batteriesCapacities[i] * 100);
                }
            }
        }
    }
}
