using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62.SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toys = 0;
            double moneyGift = 0;
            double sumMoneyGift = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyGift += 10;
                    sumMoneyGift += moneyGift;
                    sumMoneyGift -= 1;
                }
                else
                {
                    toys++;
                }
            }

            double sumToys = toys * toyPrice;

            if ((sumMoneyGift + sumToys) >= price)
            {
                Console.WriteLine("Yes! {0:f2}", (sumToys + sumMoneyGift) - price);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", price - (sumMoneyGift + sumToys));
            }
        }
    }
}
