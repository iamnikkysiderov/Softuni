using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            if (inputCurrency == "USD") sum = sum * 1.79549;
            else if (inputCurrency == "EUR") sum = sum * 1.95583;
            else if (inputCurrency == "GBP") sum = sum * 2.53405;

            if (outputCurrency == "USD") sum = sum / 1.79549;
            else if (outputCurrency == "EUR") sum = sum / 1.95583;
            else if (outputCurrency == "GBP") sum = sum / 2.53405;

            Console.WriteLine(Math.Round(sum, 2));
        }
    }
}
