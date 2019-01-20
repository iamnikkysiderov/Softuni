using System;
using System.Collections.Generic;
using System.Text;

namespace DefineAnInterfaceIPerson
{
    class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string ID { get; set; }

        public string Birthdate { get; set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
            this.Birthdate = birthdate;
        }
    }
}
