using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCIIString
{
    class ASCIIString
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] chars = new char[n];

            for (int i = 0; i < n; i++)
            {
                int asciiCode = int.Parse(Console.ReadLine());
                chars[i] = (char)asciiCode;

            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(chars[i]);
            }
            Console.WriteLine();
        }
    }
}
