using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reversedInput = string.Empty;

            for (int i = input.Length-1; i >= 0; i--)
            {
                reversedInput += input[i];
            }

            Console.WriteLine(reversedInput);
        }
    }
}
