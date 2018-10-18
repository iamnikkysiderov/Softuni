using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.SoftUniCoffeeOrders
{
    class SoftUniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            decimal totalPriceOfOrder = 0;

            for (int i = 0; i < orders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                List<int> dateOfOrder = Console.ReadLine().Split('/').Select(int.Parse).ToList();
                uint countOfCapsules = uint.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(dateOfOrder[2], dateOfOrder[1]);

                decimal priceOfOrder = ((daysInMonth * countOfCapsules) * pricePerCapsule);
                totalPriceOfOrder += priceOfOrder;

                Console.WriteLine("The price for the coffee is: ${0:f2}",priceOfOrder);
            }

            Console.WriteLine("Total: ${0:f2}",totalPriceOfOrder);
        }
    }
}
