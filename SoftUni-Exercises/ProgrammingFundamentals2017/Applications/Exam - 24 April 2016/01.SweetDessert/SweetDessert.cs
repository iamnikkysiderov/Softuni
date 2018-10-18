using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            decimal IvanchosCash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double bananaPricePerUnit = double.Parse(Console.ReadLine());
            double eggsPricePerUnit = double.Parse(Console.ReadLine());
            double berriesPricePerKilo = double.Parse(Console.ReadLine());

            double sets = Math.Ceiling(guests / 6.0);
            double totalPrice = sets * (2 * bananaPricePerUnit) + sets * (4 * eggsPricePerUnit) + sets * (0.2 * berriesPricePerKilo);

            if (IvanchosCash >= (decimal)totalPrice)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", totalPrice);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", Math.Abs((decimal)totalPrice - IvanchosCash));
            }
        }
    }
}
