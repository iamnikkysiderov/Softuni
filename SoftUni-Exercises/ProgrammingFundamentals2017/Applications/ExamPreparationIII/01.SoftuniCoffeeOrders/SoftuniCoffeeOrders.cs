using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;

namespace _01.SoftuniCoffeeOrders
{
    class SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalPrice = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime dateOfOrder = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                uint capsulesCount = uint.Parse(Console.ReadLine());

                int daysInCurrentMonth = DateTime.DaysInMonth(dateOfOrder.Year, dateOfOrder.Month);

                decimal formula = (daysInCurrentMonth * capsulesCount) * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${formula:f2}");

                totalPrice += formula;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
