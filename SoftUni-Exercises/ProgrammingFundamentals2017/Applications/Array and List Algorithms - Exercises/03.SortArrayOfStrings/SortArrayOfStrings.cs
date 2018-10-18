using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortArrayOfStrings
{
    class SortArrayOfStrings // nereshena
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = Console.ReadLine().Split(' ').ToList();

            for (int k = 0; k < listOfStrings.Count; k++)
            {
                for (int i = 1; i < listOfStrings.Count; i++)
                {
                    string current = listOfStrings[i];
                    string previous = listOfStrings[i - 1];

                    while (/*condition*/ true)
                    {
                        listOfStrings.Remove(listOfStrings[i]);
                        listOfStrings.Insert(i - 1, current);

                        current = listOfStrings[i];
                    }
                }
            }

            Console.WriteLine(string.Join(" ", listOfStrings));
        }
    }
}
