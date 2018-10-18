using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamsProblem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            string firstLine = new string('-', 3 * n) + "**" + new string('-',2*n-2);
            Console.WriteLine(firstLine);

            for (int i = 1; i <= n-1; i++)
            {
                string upperPart = new string('-', 3 * n) + "*" + new string('-', i) + "*" + new string('-', (2 * n - 2) - i);
                Console.WriteLine(upperPart);
            }
            for (int i = 0; i < n/2; i++)
            {
                string mainBody = new string('*', 3 * n) + "*" + new string('-', n - 1) + "*" + new string('-', (2 * n - 2) - (n - 1));
                Console.WriteLine(mainBody);
            }
            string nextLine = new string('-', 3 * n) + "*" + new string('-', n - 1) + "*" + new string('-', (2 * n - 2) - (n - 1));
            Console.WriteLine(nextLine);
            for (int i = 1; i <= n/2 -1; i++)
            {
                string lowerPart = new string('-', 3*n -i) + "*" + new string('-', n - 1 + 2 * i) + "*" + new string('-', (2 * n - 2) - (n - 1) - i);
                Console.WriteLine(lowerPart);
            }
            string final = new string('-', 3*n - n / 2) + "*" + new string('*', n - 1 + 2 * n / 2) + "*" + new string('-', (2 * n - 2) - (n - 1) - n / 2);
            Console.WriteLine(final);

            
        }
    }
}
