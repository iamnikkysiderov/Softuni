using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.SweetDessert // nereshena
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            ulong guests = ulong.Parse(Console.ReadLine());
            decimal pricePerBanana = decimal.Parse(Console.ReadLine());
            decimal pricePerEgg = decimal.Parse(Console.ReadLine());
            decimal pricePerKiloBerries = decimal.Parse(Console.ReadLine());

            decimal portions = guests / 2;
            portions = Math.Ceiling(portions);

            decimal totalPrice = portions * pricePerEgg * 4 + portions * pricePerBanana * 2 + portions * pricePerKiloBerries * 20/100;

            Console.WriteLine(totalPrice);
        }
    }
}
