using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var stack = new Stack<string>(input);

            for (int i = 0; i < input.Count(); i++)
            {
                Console.Write(stack.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}
