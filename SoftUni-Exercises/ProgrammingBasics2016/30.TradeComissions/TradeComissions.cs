using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double volumeOfSales = double.Parse(Console.ReadLine());

            double price = -1.0;

            if (city == "Sofia")
            {
                if (volumeOfSales >= 0 && volumeOfSales <= 500)
                {
                    price = volumeOfSales * 5 / 100;
                }
                else if (volumeOfSales > 500 && volumeOfSales <= 1000)
                {
                    price = volumeOfSales * 7 / 100;
                }
                else if (volumeOfSales > 1000 && volumeOfSales <= 10000)
                {
                    price = volumeOfSales * 8 / 100;
                }
                else
                {
                    price = volumeOfSales * 12 / 100;
                }
            }
            else if (city == "Varna")
            {
                if (volumeOfSales >= 0 && volumeOfSales <= 500)
                {
                    price = volumeOfSales * 4.5 / 100;
                }
                else if (volumeOfSales > 500 && volumeOfSales <= 1000)
                {
                    price = volumeOfSales * 7.5 / 100;
                }
                else if (volumeOfSales > 1000 && volumeOfSales <= 10000)
                {
                    price = volumeOfSales * 10 / 100;
                }
                else
                {
                    price = volumeOfSales * 13 / 100;
                }
            }
            else if (city == "Plovdiv")
            {
                if (volumeOfSales >= 0 && volumeOfSales <= 500)
                {
                    price = volumeOfSales * 5.5 / 100;
                }
                else if (volumeOfSales > 500 && volumeOfSales <= 1000)
                {
                    price = volumeOfSales * 8 / 100;
                }
                else if (volumeOfSales > 1000 && volumeOfSales <= 10000)
                {
                    price = volumeOfSales * 12 / 100;
                }
                else
                {
                    price = volumeOfSales * 14.5 / 100;
                }
            }
            if (price >= 0)
            {
                Console.WriteLine("{0}", price);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
