using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94.EqualSumAfterExtraction // 60/100 in judge - memory limit error
{
    class EqualSumAfterExtraction
    {
        static void Main(string[] args)
        {
            List<string> firstList = Console.ReadLine().Split(' ').ToList();
            List<string> secondList = Console.ReadLine().Split(' ').ToList();
            string secondListToString = string.Join("", secondList);

            int firstListSum = 0;
            int secondListSum = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                while (secondListToString.Contains(firstList[i]))
                {
                    secondList.Remove(firstList[i]);
                    secondListToString = string.Join("", secondList);
                }
            }

            foreach (var number in firstList)
            {
                firstListSum += int.Parse(number);
            }

            foreach (var number in secondList)
            {
                secondListSum += int.Parse(number);
            }

            if (firstListSum == secondListSum)
            {
                Console.WriteLine("Yes. Sum: {0}",firstListSum);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}",Math.Abs(firstListSum-secondListSum));
            }
        }
    }
}
