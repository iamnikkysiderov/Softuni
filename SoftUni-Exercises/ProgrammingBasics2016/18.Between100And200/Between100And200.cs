using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Between100And200
{
    class Between100And200
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (inputNumber >= 100 && inputNumber <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
