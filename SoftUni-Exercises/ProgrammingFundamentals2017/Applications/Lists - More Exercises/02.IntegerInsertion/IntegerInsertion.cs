using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string numbers = Console.ReadLine();
            List<string> numbersToInsert = new List<string>();

            while (numbers != "end")
            {
                numbersToInsert.Add(numbers);

                numbers = Console.ReadLine();
            }

            for (int i = 0; i < numbersToInsert.Count; i++)
            {
                string number = numbersToInsert[i];
                int firstDigit = int.Parse(number[0].ToString());

                listOfNumbers.Insert(firstDigit, int.Parse(number));
            }

            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}
