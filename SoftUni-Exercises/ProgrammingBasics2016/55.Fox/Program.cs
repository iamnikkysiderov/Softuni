using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55.Fox
{
    class Program
    {
        static void Main(string[] args)
        { // Po uslovie ne e izcyalo wyarna ?!
            int n = int.Parse(Console.ReadLine());

            for (int i = 1, count = n; i <= n; i++, count--)
            {
                string upper = new string('*', i) + "\\" + new string('-', 2 * count - 1) + "/" + new string('*', i);
                Console.WriteLine(upper);
            }
            for (int i = 1, krisko = 0, ludak = n; i <= (n / 2) - 1; i++, krisko++, ludak -= 2)
            {
                if (ludak > 0)
                {
                    string kintiteWSak = "|" + new string('*', n / 2 + Math.Abs(krisko)) + "\\" + new string('*', Math.Abs(ludak)) + "/" + new string('*', n / 2 + Math.Abs(krisko)) + "|";
                    Console.WriteLine(kintiteWSak);
                }

            }
            for (int i = 1, oshte = 2 * n - 1; i <= n; i++, oshte -= 2)
            {
                string lower = new string('-', i) + "\\" + new string('*', oshte) + "/" + new string('-', i);
                Console.WriteLine(lower);
            }
        }
    }
}
