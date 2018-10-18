using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamsProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int deadlineInDays = int.Parse(Console.ReadLine());
            int crazyWorkers = int.Parse(Console.ReadLine());

            double totalWorkDays = 0.1 * deadlineInDays;
            double regularWorkHours = totalWorkDays * 8;
            double crazyWorkersHours = crazyWorkers * (2 * deadlineInDays);
            double totalWorkingHours = Math.Floor(regularWorkHours + crazyWorkersHours);

            if (totalWorkingHours > neededHours)
            {
                Console.WriteLine("Yes! {0} hours left.",totalWorkingHours-neededHours);
            }
            else
            {
                Console.WriteLine("Not enough time! {0} hours needed.",neededHours - totalWorkingHours);
            }
        }
    }
}
