using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Header(n);
            for (int i = 1; i <= n - 2; i++)
            {
                MiddleRow(n);
            }
            Last(n);
        }
        static void Header(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
        static void MiddleRow(int n)
        {
            Console.Write('-');
            for (int j = 1; j <= n - 1; j++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
        static void Last(int n)
        {
            Console.WriteLine(new string('-', n * 2));
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
