using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceWithQueue
{
    class SequenceWithQueue
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var previousNum = n;

            int counter = 1;

            Console.Write(n + " ");

            while (counter <= 50)
            {
                if (counter <= 50)
                {
                    Console.Write(previousNum + 1 + " ");
                    counter++;
                }

                if (counter <= 50)
                {
                    Console.Write(2 * previousNum + 1 + " ");
                    counter++;
                }

                if (counter <= 50)
                {
                    Console.Write(previousNum + 2 + " ");
                    counter++;
                }

                previousNum += 1;
            }

            Console.WriteLine();
        }
    }
}
