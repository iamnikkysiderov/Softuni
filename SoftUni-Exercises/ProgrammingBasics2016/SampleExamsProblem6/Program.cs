using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamsProblem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if(n <= 99 && n >= 1000)
            {

            }
            else
            {
                while (n % 5 == 0)
                {
                    // I have to select the first digit on n and subtract it from n
                    // problem --> how to select a digit from a number?!
                }
            }
        }
    }
}
