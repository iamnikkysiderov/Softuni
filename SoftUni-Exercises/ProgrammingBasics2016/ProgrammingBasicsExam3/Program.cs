using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasicsExam3
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiHarizantemi = int.Parse(Console.ReadLine());
            int broiRozi = int.Parse(Console.ReadLine());
            int broiLaleta = int.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            char yesNo = char.Parse(Console.ReadLine());

            double sumBuket = 0;

            double harizantemiProletLyato = 2.00;
            double harizantemiEsenZima = 3.75;
            double roziProletLyato = 4.10;
            double roziEsenZima = 4.50;
            double laletaProletLyato = 2.50;
            double laletaEsenZima = 4.15;

            if (sezon == "Spring")
            {
                double totalSum = harizantemiProletLyato * broiHarizantemi + roziProletLyato * broiRozi + laletaProletLyato * broiLaleta;

                if (yesNo == 'Y')
                {
                    totalSum = totalSum + (totalSum * 0.15);
                }
                if (broiLaleta > 7)
                {
                    totalSum = totalSum - (totalSum * 0.05);
                }
                if (broiLaleta + broiRozi + broiHarizantemi > 20)
                {
                    totalSum = totalSum - (totalSum * 0.2);
                }
                sumBuket = totalSum + 2;

                Console.WriteLine("{0:f2}",sumBuket);
            }
            if (sezon == "Summer")
            {
                double totalSum = harizantemiProletLyato * broiHarizantemi + roziProletLyato * broiRozi + laletaProletLyato * broiLaleta;

                if (yesNo == 'Y')
                {
                    totalSum = totalSum + (totalSum * 0.15);
                }
                if (broiLaleta + broiRozi + broiHarizantemi > 20)
                {
                    totalSum = totalSum - (totalSum * 0.2);
                }
                sumBuket = totalSum + 2;

                Console.WriteLine("{0:f2}", sumBuket);
            }
            if (sezon == "Autumn")
            {
                double totalSum = harizantemiEsenZima * broiHarizantemi + roziEsenZima * broiRozi + laletaEsenZima * broiLaleta;

                if (yesNo == 'Y')
                {
                    totalSum = totalSum + (totalSum * 0.15);
                }
                if (broiLaleta + broiRozi + broiHarizantemi > 20)
                {
                    totalSum = totalSum - (totalSum * 0.2);
                }
                sumBuket = totalSum + 2;

                Console.WriteLine("{0:f2}", sumBuket);
            }
            if (sezon == "Winter")
            {
                double totalSum = harizantemiEsenZima * broiHarizantemi + roziEsenZima * broiRozi + laletaEsenZima * broiLaleta;

                if (yesNo == 'Y')
                {
                    totalSum = totalSum + (totalSum * 0.15);
                }
                if (broiRozi >= 10)
                {
                    totalSum = totalSum - (totalSum * 0.1);
                }
                if (broiLaleta + broiRozi + broiHarizantemi > 20)
                {
                    totalSum = totalSum - (totalSum * 0.2);
                }
                sumBuket = totalSum + 2;

                Console.WriteLine("{0:f2}", sumBuket);
            }
        }
    }
}
