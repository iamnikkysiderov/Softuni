using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RotateArrayOfStrings
{
    class RotateArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] textToRotate = Console.ReadLine().Split(' ').ToArray();
            string[] rotatedArr = new string[textToRotate.Length];
            rotatedArr[0] = textToRotate[textToRotate.Length - 1];

            for (int i = 1, j = 0; i < textToRotate.Length; i++, j++)
            {
                rotatedArr[i] = textToRotate[j];
            }

            string result = string.Join(" ", rotatedArr);

            Console.WriteLine(result);
        }
    }
}
