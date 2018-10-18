using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<Student, Dictionary<string, double>> storeStudentGrades = new Dictionary<Student, Dictionary<string, double>>();

            for (int i = 0; i < n; i++)
            {
                List<string> studentParams = Console.ReadLine().Split(' ').ToList();
                Student currentStudent = new Student();
                currentStudent.Name = studentParams[0];
                studentParams.RemoveAt(0);

                double averageGrade = studentParams.Select(double.Parse).Sum() / studentParams.Count;
                currentStudent.Average = averageGrade;

                if (averageGrade >= 5)
                {
                    if (!storeStudentGrades.ContainsKey(currentStudent))
                    {
                        storeStudentGrades[currentStudent] = new Dictionary<string, double>();
                    }

                    storeStudentGrades[currentStudent][currentStudent.Name] = averageGrade;
                }
            }

            foreach (var student in storeStudentGrades.OrderBy(x => x.Key.Name).ThenByDescending(x => x.Key.Average))
            {
                Console.WriteLine($"{student.Key.Name} -> {student.Key.Average:f2}");
            }
        }
    }
}