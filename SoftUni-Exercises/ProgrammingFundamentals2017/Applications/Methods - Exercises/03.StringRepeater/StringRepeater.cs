using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringRepeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());

            PrintResult(inputText, counter);

        }

        static void PrintResult(string text, int count)
        {
            string temporaryText = text;

            for (int i = 0; i < count - 1; i++)
            {
                text = text + temporaryText;
            }

            Console.WriteLine(text);
        }
    }
}
