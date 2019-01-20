using System;

namespace DefineAnInterfaceIPerson
{
    class DefineAnInterfaceIPerson
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();

            Citizen person = new Citizen(name, age, id, birthdate);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.ID);
            Console.WriteLine(person.Birthdate);
        }
    }
}
