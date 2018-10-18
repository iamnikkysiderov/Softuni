using System;
using System.Linq;
using System.Text;

namespace _03.RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            StringBuilder resultString = new StringBuilder();
            int n = 1;
            int mostUniqueSymbols = 0;
            string potentialNumber = string.Empty;
            StringBuilder currentString = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                while (!(input[i] >= 48 && input[i] <= 57))
                {
                    currentString.Append(input[i]);

                    if (i >= input.Length-1)
                    {
                        break;
                    }

                    i++;
                }

                while (input[i] >= 48 && input[i] <= 57)
                {
                    potentialNumber += input[i];

                    if (i >= input.Length - 1)
                    {
                        break;
                    }

                    i++;
                }

                n = int.Parse(potentialNumber.ToString());

                resultString.Append(MagicString(currentString, n));
                n = 1;

                if (i >= input.Length-1)
                {
                    continue;
                }

                currentString = new StringBuilder();
                potentialNumber = string.Empty;
                i--;
            }

            mostUniqueSymbols = resultString.ToString().Distinct().ToArray().Length;

            Console.WriteLine($"Unique symbols used: {mostUniqueSymbols}");
            Console.WriteLine(resultString.ToString());
        }
        static StringBuilder MagicString(StringBuilder inputText, int repeatCount)
        {
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < repeatCount; i++)
            {
                text.Append(inputText);
            }

            return text;
        }
    }
}
