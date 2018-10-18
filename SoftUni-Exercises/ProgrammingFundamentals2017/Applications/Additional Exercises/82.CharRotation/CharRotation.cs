using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82.CharRotation
{
    class CharRotation
    {
        static void Main(string[] args)
        {
            char[] charValues = Console.ReadLine().ToCharArray();
            int[] intValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[] result = new char[intValues.Length];
            
            for (int i = 0; i < intValues.Length; i++)
            {
                if (intValues[i] % 2 == 0)
                {
                    result[i] = (char)(charValues[i] - intValues[i]);
                }
                else
                {
                    result[i] = (char)(charValues[i] + intValues[i]);
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
