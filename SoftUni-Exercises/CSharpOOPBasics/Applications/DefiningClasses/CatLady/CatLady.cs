using System;
using System.Collections.Generic;

namespace CatLady
{
    class CatLady
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var cats = new Dictionary<string, Cat>();

            while (input[0] != "End")
            {
                Cat cat = new Cat();
                cat.Name = input[1];
                cat.Breed = input[0];
                cat.SpecificCharacteristic = decimal.Parse(input[2]);

                if (cat.SpecificCharacteristic < 0 || cats.ContainsKey(cat.Name))
                {
                    continue;
                }
                else
                {
                    cats.Add(cat.Name, cat);
                }

                input = Console.ReadLine().Split(' ');
            }

            string nameInput = Console.ReadLine();

            if (cats.ContainsKey(nameInput))
            {
                if (cats[nameInput].Breed == "Cymric")
                {
                    Console.WriteLine($"{cats[nameInput].Breed} {cats[nameInput].Name} {cats[nameInput].SpecificCharacteristic:f2}");
                }
                else
                {
                    Console.WriteLine(cats[nameInput].ToString());
                }
            }
            else
            {
                Console.WriteLine("Cat name not found");
            }
        }
    }
}
