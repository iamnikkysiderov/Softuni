using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UnunionLists
{
    class UnunionLists
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int> lists = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                List<int> newPrimal = new List<int>();

                foreach (int number in lists)
                {
                    if (primalList.Contains(number))
                    {
                        primalList.Remove(number);
                    }
                    else
                    {
                        primalList.Add(number);
                    }
                }
            }

            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
