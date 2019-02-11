using System;
using System.Threading;

namespace ThreadTest
{
    class ThreadTest
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"thread: {i}");
                }
            });
            thread.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"first: {i}");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            thread.Join();
        }
    }
}
