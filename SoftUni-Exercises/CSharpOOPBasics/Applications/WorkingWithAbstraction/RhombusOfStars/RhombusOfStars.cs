using System;

namespace RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            PrintRow(input);
        }

        static void PrintRow(int length)
        {
            PrintUpperRows(length);
            PrintLowerRows(length);
        }

        static void PrintUpperRows(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                Console.Write(new string(' ', length - i));
                Console.Write(MagicString("* ", i));
                Console.Write(new string(' ', length - i));

                Console.WriteLine();
            }
        }

        static void PrintLowerRows(int length)
        {
            for (int i = length - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', length - i));
                Console.Write(MagicString("* ", i));
                Console.Write(new string(' ', length - i));

                Console.WriteLine();
            }
        }

        static string MagicString(string text, int length)
        {
            string result = string.Empty;

            for (int i = 0; i < length; i++)
            {
                result += text;
            }

            return result;
        }
    }
}
