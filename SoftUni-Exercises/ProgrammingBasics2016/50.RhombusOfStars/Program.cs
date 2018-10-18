using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            int height = n * 2 - 1;
            int width = n * 2 - 1;

            //upper part
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            //lower part
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(' ', i));

                for (int j = n - i; j > 0; j--)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
