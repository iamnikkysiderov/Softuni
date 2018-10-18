using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _133.PopulationByCountryByTown
{
    class PopulationByCountryByTown
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> populationByCountryByTown = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                List<string> locate = Console.ReadLine().Split(' ').ToList();

                string country = locate[0];
                string town = locate[1];
                int population = int.Parse(locate[2]);

                if (!populationByCountryByTown.ContainsKey(country))
                {
                    populationByCountryByTown[country] = new Dictionary<string, int>();
                }
                if (!populationByCountryByTown[country].ContainsKey(town))
                {
                    populationByCountryByTown[country][town] = population;
                }
            }

            foreach (var kvp in populationByCountryByTown)
            {
                string country = kvp.Key;
                Console.WriteLine($"{country}:");

                foreach (var towns in kvp.Value)
                {
                    string town = towns.Key;

                    Console.WriteLine($"  {town} -> {string.Join(", ",towns.Value)}");
                }
            }
        }
    }
}
