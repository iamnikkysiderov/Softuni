using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131.AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                List<string> inputStudentGrades = Console.ReadLine().Split(' ').ToList();
                string nameOfStudent = inputStudentGrades[0];
                double gradeOfStudent = double.Parse(inputStudentGrades[1]);

                if (!studentGrades.ContainsKey(nameOfStudent))
                {
                    studentGrades[nameOfStudent] = new List<double>();
                }
                studentGrades[nameOfStudent].Add(gradeOfStudent);
            }

            foreach (var kvp in studentGrades)
            {
                string name = kvp.Key;
                List<double> grades = kvp.Value;

                Console.Write($"{name} -> ");

                foreach (double grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }

                double average = 0;

                for (int i = 0; i < grades.Count; i++)
                {
                    average += grades[i];
                }

                average /= grades.Count;

                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
