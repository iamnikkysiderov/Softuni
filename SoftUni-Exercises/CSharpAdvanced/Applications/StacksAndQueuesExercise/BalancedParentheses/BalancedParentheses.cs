using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            bool validInput = true;

            var queue = new Queue<char>();
            var openingBrackets = new Stack<char>();


            for (int i = 0; i < input.Length; i++)
            {
                queue.Enqueue(input[i]);
            }


            foreach (char bracket in queue)
            {
                if (bracket == '(' || bracket == '{' || bracket == '[')
                {
                    openingBrackets.Push(bracket);
                }
                else
                {
                    if (bracket == ')' && openingBrackets.Pop() == '(')
                    {
                        continue;
                    }
                    else if (bracket == '}' && openingBrackets.Pop() == '{')
                    {
                        continue;
                    }
                    else if (bracket == ']' && openingBrackets.Pop() == '[')
                    {
                        continue;
                    }
                    else
                    {
                        validInput = false;
                        break;
                    }
                }
            }

            if (validInput)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
