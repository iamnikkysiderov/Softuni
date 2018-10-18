using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CableMerchant___Algorithms_Exam // 100/100
{
    class CableMerchant
    {
        static void Main(string[] args)
        {
            List<int> pricesForCables = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int pricePerConnector = int.Parse(Console.ReadLine());

            pricesForCables = TrySecondAlgorithm(pricesForCables, pricePerConnector);

            Console.WriteLine(string.Join(" ", pricesForCables));
        }
        static List<int> ApplyAlgorithm(List<int> pricesForCables, int pricePerConnector)
        {
            for (int i = 0; i < pricesForCables.Count; i++)
            {
                int lengthOfCurrentCable = i + 1;

                if (i == 0)
                {
                    continue;
                }
                if (i == 1)
                {
                    if (pricesForCables[0] + pricesForCables[0] - 2 * pricePerConnector > pricesForCables[1])
                    {
                        pricesForCables[1] = pricesForCables[0] + pricesForCables[0] - 2 * pricePerConnector;
                    }

                    continue;
                }
                if (lengthOfCurrentCable % 2 == 0)
                {
                    for (int j = 0, k = i - 1; j < i; j++, k--)
                    {
                        if (j == i / 2 || k == i / 2)
                        {
                            if (pricesForCables[i / 2] + pricesForCables[i / 2] - 2 * pricePerConnector > pricesForCables[i])
                            {
                                pricesForCables[i] = pricesForCables[i / 2] + pricesForCables[i / 2] - 2 * pricePerConnector;
                            }

                            continue;
                        }
                        else
                        {
                            if (pricesForCables[j] + pricesForCables[k] - 2 * pricePerConnector > pricesForCables[i])
                            {
                                pricesForCables[i] = pricesForCables[j] + pricesForCables[k] - 2 * pricePerConnector;
                            }
                        }
                    }
                }
                else
                {
                    for (int j = 0, k = i - 1; j < i; j++, k--)
                    {
                        if (pricesForCables[j] + pricesForCables[k] - 2 * pricePerConnector > pricesForCables[i])
                        {
                            pricesForCables[i] = pricesForCables[j] + pricesForCables[k] - 2 * pricePerConnector;
                        }
                    }
                }
            }

            return pricesForCables;
        }
        static List<int> TrySecondAlgorithm(List<int> pricesForCables, int pricePerConnector)
        {
            int currentCable = 0;
            
            while (currentCable < pricesForCables.Count)
            {
                for (int k = 0, j = pricesForCables.Count / 2 - 1; k < pricesForCables.Count / 2; k++, j--)
                {
                    if (pricesForCables[k] + pricesForCables[j] - 2 * pricePerConnector > pricesForCables[currentCable])
                    {
                        pricesForCables[currentCable] = pricesForCables[k] + pricesForCables[j] - 2 * pricePerConnector;
                    }
                }

                currentCable++;
            }
            
            return pricesForCables;
        }
    }
}
