using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CottageScraper
{
    class CottageScraper
    {
        static void Main(string[] args)
        {
            List<string> inputTrees = Console.ReadLine().Split(' ').ToList();
            List<string> allTrees = new List<string>();

            while (inputTrees[0] != "chop")
            {
                string typeOfTree = inputTrees[0];
                string lengthOfTree = inputTrees[2];

                allTrees.Add((string.Join(" ", inputTrees).ToString()));

                inputTrees = Console.ReadLine().Split(' ').ToList();
            }

            string typeToUse = Console.ReadLine();

            List<string> treesWithRightTypes = new List<string>();

            for (int i = 0; i < allTrees.Count; i++)
            {
                if (allTrees[i].Contains(typeToUse))
                {
                    treesWithRightTypes.Add(allTrees[i]);
                }
            }

            int minLength = int.Parse(Console.ReadLine());

            List<string> treesToUse = new List<string>();

            for (int i = 0; i < treesWithRightTypes.Count; i++)
            {
                List<string> temp = treesWithRightTypes[i].Split(' ').ToList();
                int value = int.Parse(temp[2]);
                if (value >= minLength)
                {
                    treesToUse.Add(treesWithRightTypes[i]);
                }
            }

            decimal priceOfAllTreesPerMeter = 0m;

            for (int i = 0; i < allTrees.Count; i++)
            {
                List<string> lengthsOfAllTrees = allTrees[i].Split(' ').ToList();
                int lengthOfCurrentTree = int.Parse(lengthsOfAllTrees[2]);

                priceOfAllTreesPerMeter += lengthOfCurrentTree;
            }

            priceOfAllTreesPerMeter = Math.Round(priceOfAllTreesPerMeter / allTrees.Count, 2);

            decimal priceOfUsedTrees = 0m;

            for (int i = 0; i < treesToUse.Count; i++)
            {
                List<string> lengthsOfTreesToUse = treesToUse[i].Split(' ').ToList();
                int value = int.Parse(lengthsOfTreesToUse[2]);

                priceOfUsedTrees += value;
            }

            priceOfUsedTrees = Math.Round(priceOfUsedTrees * priceOfAllTreesPerMeter, 2);

            decimal priceOfUnusedTrees = 0m;

            List<string> copy = new List<string>();

            for (int i = 0; i < treesToUse.Count; i++)
            {
                allTrees = allTrees.Where(x => x != treesToUse[i]).ToList();
            }

            for (int i = 0; i < allTrees.Count; i++)
            {
                List<string> lengthsOfUnusedTrees = allTrees[i].Split(' ').ToList();
                int value = int.Parse(lengthsOfUnusedTrees[2]);

                priceOfUnusedTrees += value;
            }

            priceOfUnusedTrees = Math.Round(priceOfUnusedTrees * priceOfAllTreesPerMeter * 0.25m, 2);

            decimal totalPrice = priceOfUnusedTrees + priceOfUsedTrees;

            Console.WriteLine($"Price per meter: ${priceOfAllTreesPerMeter}");
            Console.WriteLine($"Used logs price: ${priceOfUsedTrees}");
            Console.WriteLine($"Unused logs price: ${priceOfUnusedTrees}");
            Console.WriteLine($"CottageScraper subtotal: ${totalPrice}");
        }
    }
}
