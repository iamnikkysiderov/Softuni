using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (char i = 'a'; i <= 'a' + input; i++)
            {
                Console.Write((char)i);

                for (int j = 'a'; j <= 'a' + input; j++)
                {
                    Console.Write((char)j);

                    for (int k = 'a'; k <= 'a' + input; k++)
                    {
                        Console.Write((char)k);

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
