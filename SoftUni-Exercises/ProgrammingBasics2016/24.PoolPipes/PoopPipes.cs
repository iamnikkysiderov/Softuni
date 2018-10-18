using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.PoolPipes
{
    class PoopPipes
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int tube1 = int.Parse(Console.ReadLine());
            int tube2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double outputTube1 = tube1 * hours;
            double outputTube2 = tube2 * hours;
            double totalTubes = outputTube1 + outputTube2;

            if (totalTubes <= volume)
            {
                double percentangePool = Math.Truncate(totalTubes / volume * 100);
                double tube1percent = Math.Truncate(outputTube1 / totalTubes * 100);
                double tube2percent = Math.Truncate(outputTube2 / totalTubes * 100);

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", percentangePool, tube1percent, tube2percent);
            }
            else
            {
                double overload = totalTubes - volume;

                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, overload);
            }
        }
    }
}
