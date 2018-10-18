using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.EqualWords
{
    class EqualWords
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            firstInput = firstInput.ToLower();
            secondInput = secondInput.ToLower();
            if (firstInput == secondInput)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
