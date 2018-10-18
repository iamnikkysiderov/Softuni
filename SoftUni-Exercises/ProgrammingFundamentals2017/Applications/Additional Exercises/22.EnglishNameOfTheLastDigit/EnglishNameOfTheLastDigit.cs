using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.EnglishNameOfTheLastDigit
{
    class EnglishNameOfTheLastDigit
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            long lastDigit = Math.Abs(n % 10);

            string result = GetLastDigitInEnglish(lastDigit);

            Console.WriteLine(result);
        }

        static string GetLastDigitInEnglish(long number)
        {
            if (number == 1)
            {
                return "one";
            }
            else if (number == 2)
            {
                return "two";
            }
            else if (number == 3)
            {
                return "three";
            }
            else if (number == 4)
            {
                return "four";
            }
            else if (number == 5)
            {
                return "five";
            }
            else if (number == 6)
            {
                return "six";
            }
            else if (number == 7)
            {
                return "seven";
            }
            else if (number == 8)
            {
                return "eight";
            }
            else if (number == 9)
            {
                return "nine";
            }
            else
            {
                return "zero";
            }
        }
    }
}
