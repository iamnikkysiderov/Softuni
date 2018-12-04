using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountUppercaseWords
{
    class CountUppercaseWords
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            foreach (var word in input)
            {
                if (word[0] >= 65 && word[0] <= 90)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
