using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _143.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> firstNumsToConcat = numbers.Take(numbers.Count / 4).ToList();
            numbers.Reverse();
            List<int> secondNumsToConcat = numbers.Take(numbers.Count / 4).ToList();
            numbers.Reverse();
            numbers.RemoveRange(0, firstNumsToConcat.Count);
            numbers.Reverse();
            numbers.RemoveRange(0, secondNumsToConcat.Count);
            numbers.Reverse();
            firstNumsToConcat.Reverse();
            List<int> concatNumbers = firstNumsToConcat.Concat(secondNumsToConcat).ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < concatNumbers.Count; i++)
            {
                result.Add(numbers[i] + concatNumbers[i]);
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
