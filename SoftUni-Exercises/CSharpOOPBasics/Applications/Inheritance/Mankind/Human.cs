using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mankind
{
    class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (!(value[0] >= 65 && value[0] <= 90))
                {
                    throw new ArgumentException("First name should start with a capital letter!");
                }
                else if (value.Length < 3)
                {
                    throw new ArgumentException("First name should start with at least 4 characters!");
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (!(value[0] >= 65 && value[0] <= 90))
                {
                    throw new ArgumentException("Last name should start with a capital letter!");
                }
                else if (value.Length < 2)
                {
                    throw new ArgumentException("Last name should start with at least 4 characters!");
                }

                lastName = value;
            }
        }

    }
}
