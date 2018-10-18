using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47.MinMethod
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            GetMinValue(a, b, c);
        }

        static void GetMinValue(int a, int b, int c)
        {
            int firstMin = Math.Min(a, b);
            int result = Math.Min(firstMin, c);

            Console.WriteLine(result);            
        }
    }
}
