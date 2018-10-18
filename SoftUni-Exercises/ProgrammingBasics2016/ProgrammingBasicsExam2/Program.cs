using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasicsExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            double subraniPari = double.Parse(Console.ReadLine());
            double shirochinaNaPoda = double.Parse(Console.ReadLine());
            double duljinaNaPoda = double.Parse(Console.ReadLine());
            double stranataNaTriugulnik = double.Parse(Console.ReadLine());
            double visochinaNaTriugulnika = double.Parse(Console.ReadLine());
            double cenaNaEdnaPlochka = double.Parse(Console.ReadLine());
            double suma = double.Parse(Console.ReadLine());

            double ploshtNaPoda = shirochinaNaPoda * duljinaNaPoda;
            double ploshtaNaPlochka = (stranataNaTriugulnik * visochinaNaTriugulnika) / 2;
            double neobhodimiPlochki = Math.Ceiling(ploshtNaPoda / ploshtaNaPlochka);
            double zafira = neobhodimiPlochki + 5;
            double totalSum = zafira * cenaNaEdnaPlochka + suma;

            if (totalSum <= subraniPari)
            {
                Console.WriteLine("{0:f2} lv left.",subraniPari-totalSum);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.",totalSum-subraniPari);
            }
        }
    }
}
