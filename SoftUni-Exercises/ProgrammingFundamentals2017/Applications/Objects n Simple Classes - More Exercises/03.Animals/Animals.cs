using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Animals
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            List<Cat> cats = new List<Cat>();
            List<Snake> snakes = new List<Snake>();

            string input = Console.ReadLine();

            while (input != "I'm your Huckleberry")
            {
                List<string> inputParams = input.Split(' ').ToList();

                if (inputParams[0] == "Dog")
                {
                    Dog dog = new Dog();
                    dog.Name = inputParams[1];
                    dog.Age = int.Parse(inputParams[2]);
                    dog.NumberOfLegs = int.Parse(inputParams[3]);

                    dogs.Add(dog);
                }
                else if (inputParams[0] == "Cat")
                {
                    Cat cat = new Cat();
                    cat.Name = inputParams[1];
                    cat.Age = int.Parse(inputParams[2]);
                    cat.IQ = int.Parse(inputParams[3]);

                    cats.Add(cat);
                }
                else if (inputParams[0] == "Snake")
                {
                    Snake snake = new Snake();
                    snake.Name = inputParams[1];
                    snake.Age = int.Parse(inputParams[2]);
                    snake.CrueltyCoeff = int.Parse(inputParams[3]);

                    snakes.Add(snake);
                }
                else if (inputParams[0] == "talk")
                {
                    for (int i = 0; i < dogs.Count; i++)
                    {
                        if (dogs[i].Name == inputParams[1])
                        {
                            dogs[i].ProduceSound();
                        }
                    }

                    for (int i = 0; i < cats.Count; i++)
                    {
                        if (cats[i].Name == inputParams[1])
                        {
                            cats[i].ProduceSound();
                        }
                    }

                    for (int i = 0; i < snakes.Count; i++)
                    {
                        if (snakes[i].Name == inputParams[1])
                        {
                            snakes[i].ProduceSound();
                        }
                    }
                }

                input = Console.ReadLine();
            }

            PrintDogs(dogs);
            PrintCats(cats);
            PrintSnakes(snakes);
        }
        static void PrintDogs(List<Dog> dogs)
        {
            for (int i = 0; i < dogs.Count; i++)
            {
                Console.WriteLine($"Dog: {dogs[i].Name}, Age: {dogs[i].Age}, Number Of Legs: {dogs[i].NumberOfLegs}");
            }
        }
        static void PrintCats(List<Cat> cats)
        {
            for (int i = 0; i < cats.Count; i++)
            {
                Console.WriteLine($"Cat: {cats[i].Name}, Age: {cats[i].Age}, IQ: {cats[i].IQ}");
            }
        }
        static void PrintSnakes(List<Snake> snakes)
        {
            for (int i = 0; i < snakes.Count; i++)
            {
                Console.WriteLine($"Snake: {snakes[i].Name}, Age: {snakes[i].Age}, Cruelty: {snakes[i].CrueltyCoeff}");
            }
        }
    }
}
