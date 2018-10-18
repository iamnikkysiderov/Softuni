using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamsProblem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioMayOrOctober = 50;
            double apartmentMayOrOctober = 65;
            double studioJuneOrSeptember = 75.2;
            double apartmentJuneOrSeptember = 68.7;
            double studioJulyOrAugust = 76;
            double apartmentJulyOrAugust = 77;

            switch (month)
            {
                case "May": if (nights > 7)
                    {
                        double offPrice = studioMayOrOctober * 0.05;
                        studioMayOrOctober = studioMayOrOctober - offPrice;
                    }
                else if (nights > 14)
                    {
                        double offPrice = studioMayOrOctober * 0.3;
                        studioMayOrOctober = studioMayOrOctober - offPrice;
                        double offPrice1 = apartmentMayOrOctober * 0.1;
                        apartmentMayOrOctober = apartmentMayOrOctober - offPrice;
                    }
                    Console.WriteLine("Apartment: {0} lv.", apartmentMayOrOctober);
                    Console.WriteLine("Studio: {0} lv.",studioMayOrOctober);
                    break;
                case "October":
                    if (nights > 7)
                    {
                        double offPrice = studioMayOrOctober * 0.05;
                        studioMayOrOctober = studioMayOrOctober - offPrice;
                    }
                    else if (nights > 14)
                    {
                        double offPrice = studioMayOrOctober * 0.3;
                        studioMayOrOctober = studioMayOrOctober - offPrice;
                        double offPrice1 = apartmentMayOrOctober * 0.1;
                        apartmentMayOrOctober = apartmentMayOrOctober - offPrice;
                    }
                    Console.WriteLine("Apartment: {0} lv.", apartmentMayOrOctober);
                    Console.WriteLine("Studio: {0} lv.", studioMayOrOctober);
                    break;
                case "June":
                    if (nights > 7)
                    {
                        double offPrice = studioJuneOrSeptember * 0.05;
                        studioJuneOrSeptember = studioJuneOrSeptember - offPrice;
                    }
                    else if (nights > 14)
                    {
                        double offPrice = studioJuneOrSeptember * 0.3;
                        studioJuneOrSeptember = studioJuneOrSeptember - offPrice;
                        double offPrice1 = apartmentJuneOrSeptember * 0.1;
                        apartmentJuneOrSeptember = apartmentJuneOrSeptember - offPrice;
                    }
                    Console.WriteLine("Apartment: {0} lv.", apartmentJuneOrSeptember);
                    Console.WriteLine("Studio: {0} lv.", studioJuneOrSeptember);
                    break;
                case "September":
                    if (nights > 7)
                    {
                        double offPrice = studioJuneOrSeptember * 0.05;
                        studioJuneOrSeptember = studioJuneOrSeptember - offPrice;
                    }
                    else if (nights > 14)
                    {
                        double offPrice = studioJuneOrSeptember * 0.3;
                        studioJuneOrSeptember = studioJuneOrSeptember - offPrice;
                        double offPrice1 = apartmentJuneOrSeptember * 0.1;
                        apartmentJuneOrSeptember = apartmentJuneOrSeptember - offPrice;
                    }
                    Console.WriteLine("Apartment: {0} lv.", apartmentJuneOrSeptember);
                    Console.WriteLine("Studio: {0} lv.", studioJuneOrSeptember);
                    break;
                case "July":
                    if (nights > 7)
                    {
                        double offPrice = studioJulyOrAugust * 0.05;
                        studioJulyOrAugust = studioJulyOrAugust - offPrice;
                    }
                    else if (nights > 14)
                    {
                        double offPrice = studioJulyOrAugust * 0.3;
                        studioJulyOrAugust = studioJulyOrAugust - offPrice;
                        double offPrice1 = apartmentJulyOrAugust * 0.1;
                        apartmentJulyOrAugust = apartmentJulyOrAugust - offPrice;
                    }
                    Console.WriteLine("Apartment: {0} lv.", apartmentJulyOrAugust);
                    Console.WriteLine("Studio: {0} lv.", studioJulyOrAugust);
                    break;
                case "August":
                    if (nights > 7)
                    {
                        double offPrice = studioJulyOrAugust * 0.05;
                        studioJulyOrAugust = studioJulyOrAugust - offPrice;
                    }
                    else if (nights > 14)
                    {
                        double offPrice = studioJulyOrAugust * 0.3;
                        studioJulyOrAugust = studioJulyOrAugust - offPrice;
                        double offPrice1 = apartmentJulyOrAugust * 0.1;
                        apartmentJulyOrAugust = apartmentJulyOrAugust - offPrice;
                    }
                    Console.WriteLine("Apartment: {0} lv.", apartmentJulyOrAugust);
                    Console.WriteLine("Studio: {0} lv.", studioJulyOrAugust);
                    break;
            }
        }
    }
}
