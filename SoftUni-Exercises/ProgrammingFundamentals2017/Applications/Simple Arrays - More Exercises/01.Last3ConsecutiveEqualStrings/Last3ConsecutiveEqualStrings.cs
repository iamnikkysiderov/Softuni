using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Last3ConsecutiveEqualStrings
{
    class Last3ConsecutiveEqualStrings
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            string[] storedResult = new string[3];

            for (int index = arr.Length - 1; index >= 0; index--)
            {
                if (arr[index] == arr[index - 1] && arr[index] == arr[index - 2])
                {
                    storedResult[0] = arr[index];
                    storedResult[1] = arr[index - 1];
                    storedResult[2] = arr[index - 2];

                    break;
                }
            }

            Console.WriteLine(string.Join(" ", storedResult));
        }
    }
}
