using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            var inputParams = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var count = inputParams[0];
            var countToDequeue = inputParams[1];
            var searchNumber = inputParams[2];

            var queue = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            for (int i = 1; i <= countToDequeue; i++)
            {
                if (queue.Count > 0)
                {
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queue.Count > 0)
            {
                if (queue.Contains(searchNumber))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
