using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _128.ExamShopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> storageOfShop = new Dictionary<string, int>();
            List<string> actions = Console.ReadLine().Split(' ').ToList();
            bool shoppingTime = false;

            while (actions[0] != "exam" && actions[1] != "time")
            {
                while (actions[0] != "shopping" && actions[1] != "time" && shoppingTime == false)
                {
                    // stocking the shop
                    bool stocking = actions[0] == "stock" ? true : false;

                    if (stocking)
                    {
                        string productForStocking = actions[1];
                        int quantityOfProductToStock = int.Parse(actions[2]);

                        if (!storageOfShop.ContainsKey(productForStocking))
                        {
                            storageOfShop[productForStocking] = 0;
                        }

                        storageOfShop[productForStocking] += quantityOfProductToStock;
                    }

                    actions = Console.ReadLine().Split(' ').ToList();
                }

                shoppingTime = true;

                bool shopping = actions[0] == "buy" ? true : false;

                if (shopping)
                {
                    string productToBuy = actions[1];
                    int quantityToBuy = int.Parse(actions[2]);

                    if (!storageOfShop.ContainsKey(productToBuy))
                    {
                        Console.WriteLine($"{productToBuy} doesn't exist");
                    }
                    else
                    {
                        if (storageOfShop[productToBuy] == 0)
                        {
                            Console.WriteLine($"{productToBuy} out of stock");
                        }

                        if (quantityToBuy >= storageOfShop[productToBuy])
                        {
                            storageOfShop[productToBuy] = 0;
                        }
                        else if (quantityToBuy <= storageOfShop[productToBuy] && quantityToBuy >= 0)
                        {
                            storageOfShop[productToBuy] -= quantityToBuy;
                        }
                    }
                }

                actions = Console.ReadLine().Split(' ').ToList();
            }

            foreach (var kvp in storageOfShop)
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
