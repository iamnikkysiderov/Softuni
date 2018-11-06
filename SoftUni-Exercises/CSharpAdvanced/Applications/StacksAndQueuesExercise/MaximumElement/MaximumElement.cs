using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            var queries = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < queries; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                if (input.Count > 1)
                {
                    stack.Push(input[1]);
                }
                else
                {
                    switch (input[0])
                    {
                        case 2:
                            stack.Pop();
                            break;
                        case 3:
                            Console.WriteLine(stack.Max());
                            break;
                    }
                }
            }
        }
    }
}
