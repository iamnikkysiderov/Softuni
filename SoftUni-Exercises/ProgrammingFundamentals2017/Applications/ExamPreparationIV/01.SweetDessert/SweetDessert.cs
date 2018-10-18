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
            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double pricePerBanana = double.Parse(Console.ReadLine());
            double pricePerEgg = double.Parse(Console.ReadLine());
            double priceOfBerriesPerKilo = double.Parse(Console.ReadLine());

            double sets = Math.Ceiling((double)guests / 6);

            double totalPrice = sets * (2 * pricePerBanana) + sets * (4 * pricePerEgg) + sets * (0.2 * priceOfBerriesPerKilo);

            if (cash >= (decimal)totalPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(decimal)totalPrice - cash:f2}lv more.");
            }
        }
    }
}
