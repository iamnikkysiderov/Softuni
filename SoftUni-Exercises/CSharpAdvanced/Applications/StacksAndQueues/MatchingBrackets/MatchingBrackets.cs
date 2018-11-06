using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingBrackets
{
    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var stack = new Stack<string>(input.Reverse());
            var outputStack = new Stack<string>();
            var currentBrackets = string.Empty;

            for (int i = 0; i < stack.Count; i++)
            {
                if (stack.ElementAt(i).Contains("("))
                {

                }
            }
        }
    }
}
