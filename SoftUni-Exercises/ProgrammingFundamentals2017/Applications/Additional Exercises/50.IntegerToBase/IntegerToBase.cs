using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.IntegerToBase // mnogo ne ya razbrah
{
    class IntegerToBase
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            string result = IntToBase(number, toBase);
            Console.WriteLine(result);
        }

        static string IntToBase(long number, int toBase)
        {
            string result = string.Empty;

            while (number > 0)
            {
                long remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }

            return result;
        }
    }
}
