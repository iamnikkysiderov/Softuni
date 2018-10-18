using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            switch (dataType)
            {
                case "string":
                    string firstText = Console.ReadLine();
                    string secondText = Console.ReadLine();

                    string stringMax = GetMax(firstText, secondText);

                    Console.WriteLine(stringMax);
                    break;

                case "int":
                    int firstNum = int.Parse(Console.ReadLine());
                    int secondNum = int.Parse(Console.ReadLine());

                    int intMax = GetMax(firstNum, secondNum);

                    Console.WriteLine(intMax);
                    break;

                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());

                    char charMax = GetMax(firstChar, secondChar);

                    Console.WriteLine(charMax);
                    break;

            }
        }

        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string GetMax(string a, string b)
        {
            if (a == "a" && b != "a")
            {
                return b;
            }
            else
            {
                return b;
            }
        }
    }
}
