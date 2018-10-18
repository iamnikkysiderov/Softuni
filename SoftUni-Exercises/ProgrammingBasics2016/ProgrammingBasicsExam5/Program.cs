using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasicsExam5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string top = new string('.', n * 2 - 1) + "/|\\" + new string('.', n * 2 - 1);
            Console.WriteLine(top);
            string top2 = new string('.', n * 2 - 1) + "\\|/" + new string('.', n * 2 - 1);
            Console.WriteLine(top2);

            for (int i = 1, j = n*2-1, k = 0; i <= n*2; i++, j--, k++)
            {
                if (k <= n * 2 - 1)
                {
                    string body = new string('.', j) + "*" + new string('-', k) + "*" + new string('-', k) + "*" + new string('.', j);
                    Console.WriteLine(body);
                }
            }

            string lower = new string('*', 4 * n + 1);
            Console.WriteLine(lower);
            string lower2 = "*" + magicString(".*", n * 2);
            Console.WriteLine(lower2);
            Console.WriteLine(lower);
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
