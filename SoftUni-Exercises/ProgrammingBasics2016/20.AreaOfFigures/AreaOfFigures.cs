using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            if (shape == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a);
            }
            else if (shape == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            else if (shape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI * r * r);
            }
            else if (shape == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(a * h / 2);
            }
        }
    }
}
