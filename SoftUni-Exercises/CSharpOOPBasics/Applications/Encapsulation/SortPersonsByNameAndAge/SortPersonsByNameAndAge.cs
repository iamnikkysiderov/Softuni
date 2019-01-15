using System;
using System.Collections.Generic;
using System.Linq;

namespace SortPersonsByNameAndAge
{
    class SortPersonsByNameAndAge
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var persons = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                Person person = new Person();
                person.FirstName = input[0];
                person.LastName = input[1];
                person.Age = int.Parse(input[2]);

                persons.Add(person);
            }

            foreach (var person in persons.OrderBy(x => x.FirstName).ThenBy(x => x.Age))
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
