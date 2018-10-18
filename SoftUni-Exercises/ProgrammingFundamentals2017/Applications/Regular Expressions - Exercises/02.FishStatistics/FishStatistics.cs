using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.FishStatistics
{
    class FishStatistics
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(>*)<(\(+)(x|'|-)>");

            string input = Console.ReadLine();

            var matchedFish = regex.Matches(input);

            int counter = 1;

            if (matchedFish.Count <= 0)
            {
                Console.WriteLine("No fish found.");
            }
            else if (matchedFish.Count > 0)
            {
                foreach (Match fish in matchedFish)
                {
                    Console.WriteLine($"Fish {counter}: {fish}");

                    if (fish.Groups[1].Length == 0)
                    {
                        Console.WriteLine($"  Tail type: None");
                    }
                    else if (fish.Groups[1].Length == 1)
                    {
                        Console.WriteLine($"  Tail type: Short (2 cm)");
                    }
                    else if (fish.Groups[1].Length > 1 && fish.Groups[1].Length <= 5)
                    {
                        Console.WriteLine($"  Tail type: Medium ({fish.Groups[1].Length * 2} cm)");
                    }
                    else if (fish.Groups[1].Length > 5)
                    {
                        Console.WriteLine($"  Tail type: Long ({fish.Groups[1].Length * 2} cm)");
                    }

                    if (fish.Groups[2].Length > 0 && fish.Groups[2].Length <= 5)
                    {
                        Console.WriteLine($"  Body type: Short ({fish.Groups[2].Length * 2} cm)");
                    }
                    else if (fish.Groups[2].Length > 5 && fish.Groups[2].Length <= 10)
                    {
                        Console.WriteLine($"  Body type: Medium ({fish.Groups[2].Length * 2} cm)");
                    }
                    else if (fish.Groups[2].Length > 10)
                    {
                        Console.WriteLine($"  Body type: Long ({fish.Groups[2].Length * 2} cm)");
                    }

                    if (fish.Groups[3].ToString() == "\'")
                    {
                        Console.WriteLine($"  Status: Awake");
                    }
                    else if (fish.Groups[3].ToString() == "-")
                    {
                        Console.WriteLine($"  Status: Asleep");
                    }
                    if (fish.Groups[3].ToString() == "x")
                    {
                        Console.WriteLine($"  Status: Dead");
                    }

                    counter++;
                }
            }
        }
    }
}
