using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int steps = 0;
            int index = 0;

            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] == 0)
                {
                    steps++;
                    continue;
                }
                else
                {
                    index = integers[i];
                    integers[i] = 0;
                    i = index;
                    steps++;
                }
            }

            Console.WriteLine(steps);
        }
    }
}
