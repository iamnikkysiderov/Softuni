using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.JSONParse
{
    class JSONParse
    {
        static void Main(string[] args)
        {
            char[] delimiters = new char[]
            {
                ' ', ',', '[', ']', '{', '}', ':', '"'
            };

            List<string> inputParams = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<Student> students = new List<Student>();

            int i = 0;

            while (i < inputParams.Count-1)
            {
                Student student = new Student();

                if (inputParams[i] == "name")
                {
                    student.Name = inputParams[i + 1];

                    i += 2;
                }
                if (inputParams[i] == "age")
                {
                    student.Age = int.Parse(inputParams[i + 1]);

                    i += 2;
                }
                if (inputParams[i] == "grades")
                {
                    student.Grades = new List<int>();

                    for (int j = i + 1; j < inputParams.Count; j++)
                    {
                        if (inputParams[j] == "name")
                        {
                            i = j;
                            break;
                        }
                        else
                        {
                            student.Grades.Add(int.Parse(inputParams[j]));
                        }

                        i = j;
                    }
                }

                students.Add(student);
            }

            for (i = 0; i < students.Count; i++)
            {
                if (students[i].Grades.Count == 0)
                {
                    Console.WriteLine($"{students[i].Name} : {students[i].Age} -> None");
                }
                else
                {
                    Console.WriteLine($"{students[i].Name} : {students[i].Age} -> {string.Join(", ", students[i].Grades)}");

                }
            }
        }
    }
}
