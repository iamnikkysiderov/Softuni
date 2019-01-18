using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName) : base(firstName, lastName) { }

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                if (!(value.Length >= 5 && value.Length <= 10))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return $"First name: {FirstName}\nLast name: {LastName}\nFaculty number: {FacultyNumber}\n";
        }
    }
}
