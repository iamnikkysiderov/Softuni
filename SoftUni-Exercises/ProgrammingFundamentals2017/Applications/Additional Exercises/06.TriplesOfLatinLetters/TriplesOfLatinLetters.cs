using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                int num = i-1;

                char letter = (char)('a' + num);

                for (int j = 1; j <= n; j++)
                {
                    int num1 = j - 1;
                    char secondLetter = (char)('a' + num1);

                    for (int k = 1; k <= n; k++)
                    {
                        int num2 = k - 1;
                        char thirdLetter = (char)('a' + num2);
                        Console.WriteLine("{0}{1}{2}",letter,secondLetter,thirdLetter);
                    }
                }
            }
        }
    }
}
