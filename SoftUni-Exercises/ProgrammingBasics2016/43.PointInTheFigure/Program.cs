using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43.PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int a = 0 * h;
            int a1 = 0 * h;
            int b = 1 * h;
            int b1 = 0 * h;
            int c = 2 * h;
            int c1 = 0 * h;
            int d = 3 * h;
            int d1 = 0 * h;
            int e = 3 * h;
            int e1 = 1 * h;
            int f = 2 * h;
            int f1 = 1 * h;
            int g = 2 * h;
            int g1 = 4 * h;
            int i = 1 * h;
            int i1 = 4 * h;
            int j = 1 * h;
            int j1 = 1 * h;
            int k = 0 * h;
            int k1 = 1 * h;

            if (x >= a && x <= d && y == a1 || x == d && y >= d1 && y <= e1 || y == f1 && x >= f && x <= e || x == f && y >= f1 && y <= g1 || y == g1 && x >= i && x <= g || x == j && y >= j1 && y <= i1 || y == j1 && x >= k && x <= j || x == a && y >= a1 && y <= k1)
            {
                Console.WriteLine("Border");
            }
            else if (x > k && x < e && y > a1 && y < k1)
            {
                Console.WriteLine("Inside");
            }
            else if (x > b && x < c && y > b1 && y < i1)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
