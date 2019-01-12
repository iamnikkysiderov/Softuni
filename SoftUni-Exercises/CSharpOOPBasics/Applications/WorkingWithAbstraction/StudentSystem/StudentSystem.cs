using System;
using System.Collections.Generic;

namespace StudentSystem
{
    class StudentSystem
    {
        static void Main(string[] args)
        {
            var inputParams = Console.ReadLine().Split(' ');
            var students = new Dictionary<string, Student>();

            while(inputParams[0] != "Exit")
            {
                switch (inputParams[0])
                {
                    case "Create":
                        Student student = new Student(inputParams[1], int.Parse(inputParams[2]), double.Parse(inputParams[3]));

                        students.Add(inputParams[1], student);
                        break;
                    case "Show":
                        if (students.ContainsKey(inputParams[1]))
                        {
                            Console.WriteLine(students[inputParams[1]].ToString());
                        }
                        break;
                }

                inputParams = Console.ReadLine().Split(' ');
            }
        }
    }
}
