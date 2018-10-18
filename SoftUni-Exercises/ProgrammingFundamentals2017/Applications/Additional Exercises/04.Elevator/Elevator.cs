using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            if (people <= capacity)
            {
                Console.WriteLine(1);
            }
            else
            {
                int left = people;
                int go = 0;
                int count = 0;

                while (left > capacity)
                {
                    count++;

                    left = people - go;
                    go += capacity;
                }

                Console.WriteLine(count);
            }
        }
    }
}
