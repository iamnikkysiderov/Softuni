using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                List<int> currentPoint = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                Point point = new Point();
                point.X = currentPoint[0];
                point.Y = currentPoint[1];

                points.Add(point);
            }

            double closestDistance = double.MaxValue;
            Point firstPoint = new Point();
            Point secondPoint = new Point();
            List<double> distances = new List<double>();

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    distances.Add(CalculateDistance(points[i], points[j]));

                    if (CalculateDistance(points[i], points[j]) < closestDistance)
                    {
                        closestDistance = CalculateDistance(points[i], points[j]);

                        firstPoint.X = points[i].X;
                        firstPoint.Y = points[i].Y;
                        secondPoint.X = points[j].X;
                        secondPoint.Y = points[j].Y;
                    }
                }
            }

            Console.WriteLine("{0:f3}", closestDistance);
            Console.WriteLine($"({firstPoint.X}, {firstPoint.Y})");
            Console.WriteLine($"({secondPoint.X}, {secondPoint.Y})");

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
