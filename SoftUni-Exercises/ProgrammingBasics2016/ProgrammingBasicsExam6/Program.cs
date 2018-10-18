using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasicsExam6
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char excludeLetter = char.Parse(Console.ReadLine());

            char second = char.MinValue;
            int num = 0;

            for (char first = firstLetter; first <= (int)secondLetter; first++)
            {
                if (first == excludeLetter)
                {
                    continue;
                }

                for (second = firstLetter; second <= (int)secondLetter; second++)
                {
                    if (second == excludeLetter)
                    {
                        continue;
                    }
                    for (char third = firstLetter; third <= (int)secondLetter; third++)
                    {
                        if (third == excludeLetter)
                        {
                            continue;
                        }
                        num++;
                        Console.Write(first.ToString() + second + third + " ");
                    }
                }
            }
            Console.Write(num + " ");
            Console.WriteLine();
        }
    }
}
