using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            double price = -1.0;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (product == "banana")
                {
                    price = 2.50;
                }
                else if (product == "apple")
                {
                    price = 1.2;
                }
                else if (product == "orange")
                {
                    price = 0.85;
                }
                else if (product == "grapefruit")
                {
                    price = 1.45;
                }
                else if (product == "kiwi")
                {
                    price = 2.7;
                }
                else if (product == "pineapple")
                {
                    price = 5.5;
                }
                else if (product == "grapes")
                {
                    price = 3.85;
                }
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (product == "banana")
                {
                    price = 2.7;
                }
                else if (product == "apple")
                {
                    price = 1.25;
                }
                else if (product == "orange")
                {
                    price = 0.9;
                }
                else if (product == "grapefruit")
                {
                    price = 1.6;
                }
                else if (product == "kiwi")
                {
                    price = 3;
                }
                else if (product == "pineapple")
                {
                    price = 5.6;
                }
                else if (product == "grapes")
                {
                    price = 4.2;
                }
            }
            if (price >= 0)
            {
                Console.WriteLine("{0:f2}", price * quantity);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
