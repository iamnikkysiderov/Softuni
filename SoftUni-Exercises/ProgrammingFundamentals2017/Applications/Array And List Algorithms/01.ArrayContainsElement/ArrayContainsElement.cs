using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayContainsElement
{
    class ArrayContainsElement
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ').ToList();
            string numberToBeContained = Console.ReadLine();
            bool isContained = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numberToBeContained == numbers[i])
                {
                    isContained = true;
                    break;
                }
            }

            if (isContained == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
