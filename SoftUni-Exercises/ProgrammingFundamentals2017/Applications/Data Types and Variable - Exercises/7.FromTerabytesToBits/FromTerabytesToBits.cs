using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.FromTerabytesToBits
{
    class FromTerabytesToBits
    {
        static void Main(string[] args)
        { // I need a bigger data type than decimal or ulong
            decimal tb = decimal.Parse(Console.ReadLine());
            decimal oneTbToBits = 1024m * 1024 * 1024 * 1024 * 8;
            decimal result = tb * oneTbToBits;

            Console.WriteLine("{0:f0}", result);
        }
    }
}
