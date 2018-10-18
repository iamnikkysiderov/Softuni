using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77.BallisticsTraining
{
    class BallisticsTraining
    {
        static void Main(string[] args)
        {
            double[] targetCoordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] coordinatesForWork = new double[2] { 0, 0 };
            double x = coordinatesForWork[0];
            double y = coordinatesForWork[1];
            string[] aim = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0, j = 1; i < aim.Length; i++, j++)
            {
                if (aim[i].Contains("up"))
                {
                    y += double.Parse(aim[j]);
                }
                else if (aim[i].Contains("down"))
                {
                    y -= double.Parse(aim[j]);
                }
                else if (aim[i].Contains("right"))
                {
                    x += double.Parse(aim[j]);
                }
                else if (aim[i].Contains("left"))
                {
                    x -= double.Parse(aim[j]);
                }
            }

            Console.WriteLine($"firing at [{x}, {y}]");

            double[] aimCoordinates = new double[2] { x, y };


            if (aimCoordinates[0] == targetCoordinates[0] && aimCoordinates[1] == targetCoordinates[1])
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
