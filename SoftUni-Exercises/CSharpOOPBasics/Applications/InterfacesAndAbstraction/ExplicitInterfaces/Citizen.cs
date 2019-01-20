using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    class Citizen : IPerson, IResident
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }

        string IPerson.GetName()
        {
            return Name;
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {Name}";
        }

        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }
    }
}
