using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _119.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> distinctNumbers = new List<double>();
            SortedDictionary<double, int> numbersOccurencesPairs = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                distinctNumbers.Add(numbers[i]);
            }

            distinctNumbers = distinctNumbers.Distinct().ToList();

            for (int i = 0; i < distinctNumbers.Count; i++)
            {
                double currentNumber = distinctNumbers[i];
                int occurences = 0;

                for (int j = 0; j < numbers.Count; j++)
                {
                    if (currentNumber == numbers[j])
                    {
                        occurences++;
                    }
                }

                numbersOccurencesPairs.Add(currentNumber, occurences);
            }

            foreach (double key in numbersOccurencesPairs.Keys)
            {
                Console.WriteLine($"{key} -> {numbersOccurencesPairs[key]}");
            }
        }
    }
}
