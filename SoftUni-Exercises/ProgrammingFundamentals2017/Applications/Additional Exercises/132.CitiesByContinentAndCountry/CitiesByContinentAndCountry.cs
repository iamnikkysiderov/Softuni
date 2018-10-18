using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _132.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> world = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                List<string> locate = Console.ReadLine().Split(' ').ToList();
                string currentContinent = locate[0];
                string currentCountry = locate[1];
                string currentCity = locate[2];

                if (!world.ContainsKey(currentContinent))
                {
                    world[currentContinent] = new Dictionary<string, List<string>>();
                }
                if (!world[currentContinent].ContainsKey(currentCountry))
                {
                    world[currentContinent][currentCountry] = new List<string>();
                }
                world[currentContinent][currentCountry].Add(currentCity);
            }

            foreach (var kvp in world)
            {
                string continent = kvp.Key;
                Console.WriteLine($"{continent}:");

                foreach (var coutries in kvp.Value)
                {
                    string country = coutries.Key;
                    List<string> cities = coutries.Value;
                    Console.WriteLine($"  {country} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}