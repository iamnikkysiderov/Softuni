using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasicsExam1
{
    class ProgrammingBasicsExam1
    {
        static void Main(string[] args)
        { // nereshena
            double firstVelocity = double.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());

            double firstTimeReal = firstTime / 60;
            double secondTimeReal = secondTime / 60;
            double thirdTimeReal = thirdTime / 60;

            double firstDistance = firstVelocity * firstTimeReal;
            double increase = firstVelocity * 0.1;
            double secondVelocity = firstVelocity + increase;
            double secondDistance = secondVelocity * secondTimeReal;
            double decrease = secondVelocity * 0.05;
            double thirdVelocity = secondVelocity - decrease;
            double thirdDistance = thirdVelocity * thirdTimeReal;

            double totalDistance = firstDistance + secondDistance + thirdDistance;

            Console.WriteLine("{0:f2}", totalDistance);
        }
    }
}
