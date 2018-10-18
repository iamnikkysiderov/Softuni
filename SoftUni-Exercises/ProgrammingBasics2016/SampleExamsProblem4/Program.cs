using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamsProblem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int doctors = 7;
            int treated = 0;
            int untreated = 0;

            for (int i = 1; i <= days; i++)
            {
                // day 1; day 2

                if (i % 3 == 0) // 1 --> false; 2 --> false; true
                {
                    doctors++;
                }

                int sickPeople = int.Parse(Console.ReadLine()); // 7; 27; 9

                if (sickPeople > doctors) // 7 > 7 --> false; 27 > 7 --> true; 9 --> true
                {
                    treated = treated + doctors; // 7; 7
                    untreated = untreated + sickPeople - doctors; // 27 - 7; 9 - 7
                }
                else // true; false; false
                {
                    treated = treated + sickPeople; // 0 + 7
                }
            }
            Console.WriteLine("Treated patients: {0}.",treated);
            Console.WriteLine("Untreated patients: {0}.",untreated);

            // Comments above may be false!
        }
    }
}
