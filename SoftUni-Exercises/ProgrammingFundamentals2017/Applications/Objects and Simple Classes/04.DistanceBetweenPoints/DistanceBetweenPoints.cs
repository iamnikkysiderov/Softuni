using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point firstPoint = new Point();
            Point secondPoint = new Point();

            firstPoint.X = coordinates[0];
            firstPoint.Y = coordinates[1];
            secondPoint.X = secondCoordinates[0];
            secondPoint.Y = secondCoordinates[1];

            Console.WriteLine("{0:f3}", CalculateDistance(firstPoint, secondPoint));
        }
        static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            // we are building a right-angled triangle
            // we find a and b
            // and using pythagorean theorem we find c which is equal to the distance we are searching for
            // pythagorean theorem: c^2 = a^2 + b^2

            double c;

            double a = Math.Abs(firstPoint.X - secondPoint.X);
            double b = Math.Abs(firstPoint.Y - secondPoint.Y);

            c = Math.Sqrt(a * a + b * b);

            return c;
        }
    }
}
