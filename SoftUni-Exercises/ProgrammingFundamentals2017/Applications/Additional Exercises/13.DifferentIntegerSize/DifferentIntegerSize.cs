using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DifferentIntegerSize
{
    class DifferentIntegerSize
    {
        static void Main(string[] args)
        {
            long n;
            try
            {
                n = long.Parse(Console.ReadLine());
                Console.WriteLine("{0} can fit in:",n);

                if (n >= -128 && n <= 127)
                {
                    Console.WriteLine("* short");
                }
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("{n} can't fit in any type");
            }     
        }
    }
}
