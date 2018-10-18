using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _36.FromTerabytesToBits
{
    class FromTerabytesToBits
    {
        static void Main(string[] args)
        { // nereshena 
            decimal tb = decimal.Parse(Console.ReadLine());
            decimal oneTbToBits = 1024m * 1024 * 1024 * 1024 * 8;
            decimal result = tb * oneTbToBits;

            Console.WriteLine("{0:f0}",result);
        }
    }
}
