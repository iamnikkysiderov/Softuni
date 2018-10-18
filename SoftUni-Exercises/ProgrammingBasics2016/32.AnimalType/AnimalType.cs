using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.AnimalType
{
    class AnimalType
    {
        static void Main(string[] args)
        {
            string animalInput = Console.ReadLine();

            switch (animalInput)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                    Console.WriteLine("reptile");
                    break;
                case "tortoise":
                    Console.WriteLine("reptile");
                    break;
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                case "cat":
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
