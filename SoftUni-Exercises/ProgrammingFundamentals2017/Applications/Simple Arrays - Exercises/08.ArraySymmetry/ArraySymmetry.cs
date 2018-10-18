using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ArraySymmetry
{
    class ArraySymmetry
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ').ToArray();
            string[] secondArr = new string[firstArr.Length];
            int count = 0;

            for (int i = 0, j = 1; i < firstArr.Length; i++, j++)
            {
                secondArr[i] = firstArr[firstArr.Length - j];
            }

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (secondArr[i] != firstArr[i])
                {
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
