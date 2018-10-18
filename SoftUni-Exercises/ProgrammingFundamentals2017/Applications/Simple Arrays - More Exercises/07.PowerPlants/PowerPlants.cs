using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PowerPlants
{
    class PowerPlants
    {
        static void Main(string[] args)
        {
            List<int> plants = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int days = plants.Count;
            int seasons = 0;
            int totalDays = 0;
            int maxValuePlant = int.MinValue;
            int indexOfMaxValuePlant = -1;
            int dayz = 0;

            for (int i = 0; i < plants.Count; i++)
            {
                if (plants[i] >= maxValuePlant)
                {
                    maxValuePlant = plants[i];
                    indexOfMaxValuePlant = i;
                }
            }

            for (int i = maxValuePlant; i >= 0; i--)
            {
                if (dayz == plants.Count)
                {
                    dayz = 0;
                    seasons++;
                }
                else
                {
                    dayz++;
                }


                if (dayz == indexOfMaxValuePlant)
                {
                    dayz += 2;
                }
            }

            string result = seasons == 1 ? "season" : "seasons";

            Console.WriteLine($"survived {totalDays} days ({seasons} {result})");
        }
    }
}
