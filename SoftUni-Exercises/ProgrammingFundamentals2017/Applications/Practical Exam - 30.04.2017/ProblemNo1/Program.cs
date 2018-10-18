using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double converted = length * 100.0;
            double check = converted % width;
            double result = (length / width) * 10000;

            if (width != 0)
            {
                if (check == 0)
                {
                    Console.WriteLine("{0:f2}", converted * width);
                }
                else
                {
                    Console.WriteLine("{0:f2}%", result);
                }
            }
            else
            {
                Console.WriteLine("{0:f2}", converted * width);
            }

        }
    }
}
