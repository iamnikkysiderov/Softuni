using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int sets = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 0;

            if (type == "Premiere")
            {
                price = 12.00;
                Console.WriteLine("{0:f2} leva", price * sets * columns);
            }
            else if (type == "Normal")
            {
                price = 7.5;
                Console.WriteLine("{0:f2} leva", price * sets * columns);
            }
            else if (type == "Discount")
            {
                price = 5.0;
                Console.WriteLine("{0:f2} leva", price * sets * columns);
            }
        }
    }
}
