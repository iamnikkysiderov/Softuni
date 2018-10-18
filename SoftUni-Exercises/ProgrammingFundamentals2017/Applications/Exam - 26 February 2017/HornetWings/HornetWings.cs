using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            int totalWingFlaps = int.Parse(Console.ReadLine());
            double distanceFor1000Flaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distance = (totalWingFlaps / 1000) * distanceFor1000Flaps;
            double totalFlapsInSecondsWithoutRest = totalWingFlaps / 100;
            double totalTimeTaken = ((totalWingFlaps / endurance) * 5) + totalFlapsInSecondsWithoutRest;

            Console.WriteLine("{0:f2} m.", distance);
            Console.WriteLine("{0} s.", totalTimeTaken);
        }
    }
}
