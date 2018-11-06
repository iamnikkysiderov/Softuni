using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            var stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                var firstNum = int.Parse(stack.Pop());
                var oper = stack.Pop();
                var secondNum = int.Parse(stack.Pop());

                if (oper == "+")
                {
                    stack.Push((firstNum + secondNum).ToString());
                }
                else
                {
                    stack.Push((firstNum - secondNum).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
