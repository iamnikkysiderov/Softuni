using System;

namespace ExplicitInterfaces
{
    class ExplicitInterfaces
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            while (input[0] != "End")
            {
                Citizen citizen = new Citizen(input[0], input[1], int.Parse(input[2]));
                IPerson person = citizen;
                IResident resident = citizen;

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());

                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
