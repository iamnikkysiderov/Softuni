using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.ReverseAnArrayOfIntegers
{
    class ReverseAnArrayOfIntegers
    {
        static void Main(string[] args) // Bi tryaalo da moje i po drug nachin
        {
            int numbers = int.Parse(Console.ReadLine());

            string[] containNumbers = new string[numbers];

            for (int i = 0; i < numbers; i++)
            {
                int numbersToReverseOrder = int.Parse(Console.ReadLine());
                string str = numbersToReverseOrder.ToString() + " ";
                containNumbers[i] = str;
            }

            for (int i = numbers-1; i >= 0; i--)
            {
                Console.Write(containNumbers[i]); 
            }

            Console.WriteLine();
        }
    }
}
