using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Altitude
{
    class Altitude
    {
        static void Main(string[] args)
        {
            string[] altitudeChanges = Console.ReadLine().Split(' ').ToArray();
            double currentAltitude = double.Parse(altitudeChanges[0]);

            for (int i = 1, j = 2; i < altitudeChanges.Length; i++, j++)
            {
                if (altitudeChanges[i].Contains("up"))
                {
                    currentAltitude += double.Parse(altitudeChanges[j]);
                }
                else if (altitudeChanges[i].Contains("down"))
                {
                    currentAltitude -= double.Parse(altitudeChanges[j]);

                    if (currentAltitude <= 0)
                    {
                        Console.WriteLine("crashed");
                        break;
                    }
                }
            }

            if (currentAltitude > 0)
            {
                Console.WriteLine("got through safely. current altitude: {0}m", currentAltitude);
            }
        }
    }
}
