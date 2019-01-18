using System;

namespace Mankind
{
    class Mankind
    {
        static void Main(string[] args)
        {
            var studentInputInfo = Console.ReadLine().Split(' ');
            var workerInputInfo = Console.ReadLine().Split(' ');

            try
            {
                Student student = new Student(studentInputInfo[0], studentInputInfo[1], studentInputInfo[2]);
                Worker worker = new Worker(workerInputInfo[0], workerInputInfo[1], decimal.Parse(workerInputInfo[2]), int.Parse(workerInputInfo[3]));

                Console.WriteLine(student.ToString());
                Console.WriteLine(worker.ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
