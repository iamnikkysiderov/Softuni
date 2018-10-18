using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.JSONStringify
{
    class JSONStringify
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "stringify")
            {
                List<string> inputParams = input.Split(new[] { ' ', ',', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                Student student = new Student();
                student.Name = inputParams[0];
                student.Age = int.Parse(inputParams[1]);
                student.Grades = new List<int>();

                for (int i = 2; i < inputParams.Count; i++)
                {
                    student.Grades.Add(int.Parse(inputParams[i]));
                }

                students.Add(student);

                input = Console.ReadLine();
            }

            Console.Write("[");

            for (int i = 0; i < students.Count; i++)
            {
                if (i < students.Count - 1)
                {
                    Console.Write("{{name:\"{0}\",age:{1},grades:[{2}]}},", students[i].Name, students[i].Age, string.Join(", ", students[i].Grades));
                }
                else
                {
                    Console.Write("{{name:\"{0}\",age:{1},grades:[{2}]}}]", students[i].Name, students[i].Age, string.Join(", ", students[i].Grades));
                }
            }

            Console.WriteLine();
        }
    }
}
