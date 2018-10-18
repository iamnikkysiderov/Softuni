using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasicsExam4
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double totalGrade = 0;
            double topStudent = 0;
            double goodStudent = 0;
            double averageStudent = 0;
            double fail = 0;

            for (int i = 1; i <= students; i++)
            {
                double gradeForStudent = double.Parse(Console.ReadLine());
                totalGrade += gradeForStudent;
                if (gradeForStudent < 3)
                {
                    fail++;
                }
                else if (gradeForStudent >= 3 && gradeForStudent< 4)
                {
                    averageStudent++;
                }
                else if (gradeForStudent >= 4 && gradeForStudent <5 )
                {
                    goodStudent++;
                }
                else if (gradeForStudent >= 5)
                {
                    topStudent++;
                }
            }
            Console.WriteLine("Top students: {0:f2}%",topStudent/students*100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%",goodStudent/students*100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%",averageStudent/students*100);
            Console.WriteLine("Fail: {0:f2}%",fail/students*100);
            Console.WriteLine("Average: {0:f2}",totalGrade/students);
        }
    }
}
