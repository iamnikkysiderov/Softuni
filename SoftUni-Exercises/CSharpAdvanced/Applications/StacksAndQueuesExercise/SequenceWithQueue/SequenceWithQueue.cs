using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceWithQueue
{
    class SequenceWithQueue
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var queue = new Queue<int>();
            var secondQueue = new Queue<int>();
            var count = 1;

            Console.Write(n + " ");

            secondQueue.Enqueue(n);

            while (count <= 49)
            {

                queue.Enqueue(secondQueue.Peek() + 1);
                secondQueue.Enqueue(secondQueue.Peek() + 1);

                queue.Enqueue(2 * secondQueue.Peek() + 1);
                secondQueue.Enqueue(2 * secondQueue.Peek() + 1);

                queue.Enqueue(secondQueue.Peek() + 2);
                secondQueue.Enqueue(secondQueue.Peek() + 2);

                secondQueue.Dequeue();

                if (count >= 48)
                {
                    Console.Write(queue.Dequeue() + " ");
                    count++;
                }
                else
                {
                    Console.Write(queue.Dequeue() + " ");
                    count++;

                    Console.Write(queue.Dequeue() + " ");
                    count++;

                    Console.Write(queue.Dequeue() + " ");
                    count++;
                }
            }

            Console.WriteLine();
        }
    }
}
