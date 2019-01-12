using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem
{
    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public double Grade { get; set; }

        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }

        public override string ToString()
        {
            string marks = string.Empty;

            if (Grade < 3.50)
            {
                marks = "Poor";
            }
            else if (Grade >= 3.50 && Grade < 4.50)
            {
                marks = "Average";
            }
            else if (Grade >= 4.50 && Grade < 5.50)
            {
                marks = "Good";
            }
            else if (Grade >= 5.50)
            {
                marks = "Excellent";
            }

            return $"{Name} is {Age} years old. {marks} student.";
        }
    }
}
