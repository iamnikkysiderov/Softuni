using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boxes
{
    class Boxes
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                List<string> inputParams = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                List<string> upperLeftCoordinates = inputParams[0].Split(':').ToList();
                List<string> upperRightCoordinates = inputParams[1].Split(':').ToList();
                List<string> bottomLeftCoordinates = inputParams[2].Split(':').ToList();
                List<string> bottomRightCoordinates = inputParams[3].Split(':').ToList();

                Box box = new Box();
                box.UpperLeftX = int.Parse(upperLeftCoordinates[0]);
                box.UpperLeftY = int.Parse(upperLeftCoordinates[1]);
                box.UpperRightX = int.Parse(upperRightCoordinates[0]);
                box.UpperRightY = int.Parse(upperRightCoordinates[1]);
                box.BottomLeftX = int.Parse(bottomLeftCoordinates[0]);
                box.BottomLeftY = int.Parse(bottomLeftCoordinates[1]);
                box.BottomRightX = int.Parse(bottomRightCoordinates[0]);
                box.BottomRightY = int.Parse(bottomRightCoordinates[1]);

                boxes.Add(box);

                input = Console.ReadLine();
            }

            for (int i = 0; i < boxes.Count; i++)
            {
                Box box = new Box();
                box = boxes[i];

                Console.WriteLine($"Box: {box.Width()}, {box.Height()}");
                Console.WriteLine($"Perimeter: {2*box.Width() + 2*box.Height()}");
                Console.WriteLine($"Area: {box.Width()*box.Height()}");
            }
        }
    }
}
