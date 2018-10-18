using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.NumbersInReversedOrder
{
    class NumbersInReversedOrder
    { // 50/100 Judge
        static int counter = 0;

        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double result = GetReversed(n);
            Console.WriteLine(result);
        }

        static double GetReversed(double number)
        {
            if (number.ToString().Contains("."))
            {
                int numberInInt = GetToInt(number);
                double reversedInInt = 0;

                while (numberInInt > 0)
                {
                    double remainder = numberInInt % 10;
                    reversedInInt = (reversedInInt * 10) + remainder;
                    numberInInt = (int)(numberInInt / 10);
                }

                return BackToDouble((int)reversedInInt);
            }
            else
            {
                double reversed = 0;

                while (number > 0)
                {
                    double remainder = number % 10;
                    reversed = (reversed * 10) + remainder;
                    number = (int)(number / 10);
                }

                return reversed;
            }
        }

        static int GetToInt(double number)
        {
            while (number.ToString().Contains("."))
            {
                ++counter;
                number *= 10;
            }

            return (int)number;
        }

        static double BackToDouble(int number)
        {
            double numberInDouble = number;

            while (counter > 0)
            {
                --counter;
                numberInDouble /= 10;
            }

            return numberInDouble;
        }
    }
}
