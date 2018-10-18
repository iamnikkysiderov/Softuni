using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.Sunglasses
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int cols = (2 * n) + n + (2 * n);
            int rows = n;
            int innerPart = n - 2;

            string mainBorder = new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n);
            Console.WriteLine(mainBorder);

            for (int j = 1; j <= innerPart; j++)
            {
                string glass = "*" + new string('/', 2 * n - 2) + "*" + new string(' ', n) + "*" + new string('/', 2 * n - 2) + "*";
                string withBridge = "*" + new string('/', 2 * n - 2) + "*" + magicString("|", n) + "*" + new string('/', 2 * n - 2) + "*";

                if ((n - 1) / 2 == j) // solved by softuni
                {
                    Console.WriteLine(withBridge);
                }
                else
                {
                    Console.WriteLine(glass);
                }

            }
            Console.WriteLine(mainBorder);
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
