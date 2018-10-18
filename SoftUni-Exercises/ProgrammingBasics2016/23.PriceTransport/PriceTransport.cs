using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.PriceTransport
{
    class PriceTransport
    {
        static void Main(string[] args)
        {
            double kmDistance = double.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double taxiDay = 0.70 + (kmDistance * 0.79);
            double taxiNight = 0.70 + (kmDistance * 0.90);
            double bus = kmDistance * 0.09;
            double train = kmDistance * 0.06;

            if (kmDistance < 20 && dayOrNight == "day")
            {
                Console.WriteLine(taxiDay);
            }
            else if (kmDistance < 20 && dayOrNight == "night")
            {
                Console.WriteLine(taxiNight);
            }
            else if (kmDistance >= 20 && kmDistance < 100)
            {
                Console.WriteLine(bus);
            }
            else
            {
                Console.WriteLine(train);
            }
        }
    }
}
