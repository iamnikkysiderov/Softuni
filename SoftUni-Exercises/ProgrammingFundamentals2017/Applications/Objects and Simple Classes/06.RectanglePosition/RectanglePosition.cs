using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RectanglePosition
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            List<int> firstCoordinatesParams = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondCoordinatesParams = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Coordinates firstRectangle = new Coordinates()
            {
                Y1 = firstCoordinatesParams[1],
                X1 = firstCoordinatesParams[0],
                Width = firstCoordinatesParams[2],
                Height = firstCoordinatesParams[3],
                Y2 = firstCoordinatesParams[1] + firstCoordinatesParams[3],
                X2 = firstCoordinatesParams[0] + firstCoordinatesParams[2]
            };

            Coordinates secondRectangle = new Coordinates()
            {
                Y1 = secondCoordinatesParams[1],
                X1 = secondCoordinatesParams[0],
                Width = secondCoordinatesParams[2],
                Height = secondCoordinatesParams[3],
                Y2 = secondCoordinatesParams[1] + secondCoordinatesParams[3],
                X2 = secondCoordinatesParams[0] + secondCoordinatesParams[2]
            };

            bool inside = IsInside(firstRectangle, secondRectangle);

            if (inside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
        static bool IsInside(Coordinates firstRectangle, Coordinates secondRectangle)
        {
            if (firstRectangle.X1 >= secondRectangle.X1 && firstRectangle.X2 <= secondRectangle.X2 && firstRectangle.Y1 <= secondRectangle.Y1
                && firstRectangle.Y2 <= secondRectangle.Y2)
            {
                return true;
            }

            return false;
        }
    }
}
