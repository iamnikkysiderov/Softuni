using System;
using System.Threading;

namespace EvenNumbersThread
{
    class EvenNumbersThread
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var startingNum = int.Parse(input[0]);
            var endingNum = int.Parse(input[1]);

            Thread evens = new Thread(() => PrintEvenNumbers(startingNum, endingNum));
            evens.Start();
            evens.Join();
            Console.WriteLine("Thread finished work");
        }

        private static void PrintEvenNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
