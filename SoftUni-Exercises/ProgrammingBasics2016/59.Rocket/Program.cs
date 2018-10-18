using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 1;
            count++;

            for (int i = 1, j = 0; i <= n; i++, j += 2)
            {
                string head = magicString(".", n * 2 - count - i) + "/" + magicString(" ", j) + "\\" + magicString(".", n * 2 - count - i);
                Console.WriteLine(head);
            }
            string middle = magicString(".", n / 2) + magicString("*", n * 2) + magicString(".", n / 2);
            Console.WriteLine(middle);
            for (int i = 1; i <= n * 2; i++)
            {
                string body = magicString(".", n / 2) + "|" + magicString("\\", n * 2 - 2) + "|" + magicString(".", n / 2);
                Console.WriteLine(body);
            }
            for (int i = 1, k = n / 2, m = n * 2 - 2; i <= n / 2; i++, k--, m += 2)
            {
                string lower = magicString(".", k) + "/" + magicString("*", m) + "\\" + magicString(".", k);
                Console.WriteLine(lower);
            }
        }

        public static string magicString(string text, int repeatCount)
        {
            string outputText = "";

            for (int i = 0; i < repeatCount; i++)
            {
                outputText += text;
            }

            return outputText;
        }
    }
}
