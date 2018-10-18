using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IntersectionOfCircles
{
    class IntesectionOfCircles
    {
        static void Main(string[] args)
        {
            int[] inputParamsOfFirstCircle = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Circle first = new Circle();
            first.X = inputParamsOfFirstCircle[0];
            first.Y = inputParamsOfFirstCircle[1];
            first.Radious = inputParamsOfFirstCircle[2];
            int[] inputParamsOfSecondCircle = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Circle second = new Circle();
            second.X = inputParamsOfSecondCircle[0];
            second.Y = inputParamsOfSecondCircle[1];
            second.Radious = inputParamsOfSecondCircle[2];

            bool intersection = IntersectCircles(first, second);

            if (intersection)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
        static bool IntersectCircles(Circle first, Circle second)
        {
            // I have to find the distance between the two points
            // the distance is calculated by the pythagorean theorem
            // and then if distance is > than the sum of the radiouses
            // the circles do not intersect
            // else
            // they do

            double a = Math.Abs(first.X - second.X);
            double b = Math.Abs(first.Y - second.Y);
            double distance = Math.Sqrt((a * a) + (b * b));
            if (distance > first.Radious + second.Radious)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
