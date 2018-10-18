using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double angleRad = Math.PI * rad / 180.0;
            double angleDeg = 180.0 * rad / Math.PI;
            Console.WriteLine(Math.Round(angleDeg, 0));
        }
    }
}
