using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            var inputParameters = Console.ReadLine().Split(' ');
            var count = int.Parse(inputParameters[0]);
            var countToPop = int.Parse(inputParameters[1]);
            var searchNumber = int.Parse(inputParameters[2]);
            
            var stack = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            for (int i = 1; i <= countToPop; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
                else
                {
                    break;
                }
            }

            if (stack.Count > 0)
            {
                if (stack.Contains(searchNumber))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
