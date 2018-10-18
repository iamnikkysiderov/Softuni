using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemFromMitaka1
{
    class Program
    {
        static void Main()
        {
            int j = 1;

            for (int i = 1; i <= 3; i++)
            {
                Console.Write(magicString("->", 4));
                Console.WriteLine();

                if (i == 3)
                {
                    break;
                }

                for (; j == i; j++)
                {
                    Console.Write(magicString("<-", 4));
                    Console.WriteLine();
                }
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
