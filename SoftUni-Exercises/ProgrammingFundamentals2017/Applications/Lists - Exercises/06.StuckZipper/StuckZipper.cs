using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StuckZipper // nereshena
{
    class StuckZipper
    {
        static void Main(string[] args)
        {
            List<string> firstList = Console.ReadLine().Split(' ').ToList();
            List<string> secondList = Console.ReadLine().Split(' ').ToList();
            List<string> result = new List<string>();

            int maxLengthInFirstList = int.MaxValue;
            int maxLengthInSecondList = int.MaxValue;
            int totalMaxLength = 0;

            maxLengthInFirstList = GetMaxLengthInFirstList(firstList, maxLengthInFirstList);
            maxLengthInSecondList = GetMaxLengthInSecondList(secondList, maxLengthInSecondList);
            totalMaxLength = GetTotalMaxLength(maxLengthInFirstList, maxLengthInSecondList, totalMaxLength);

            firstList = RemoveUnnecesaryElementsInFirstList(firstList, totalMaxLength);
            secondList = RemoveUnnecesaryElementsInSecondList(secondList, totalMaxLength);

            result = GetResult(firstList, secondList, result);

            Console.WriteLine(string.Join(" ", result));
        }

        static int GetMaxLengthInFirstList(List<string> firstList, int maxLengthInFirstList)
        {
            foreach (string number in firstList)
            {
                if (number.Length < maxLengthInFirstList)
                {
                    maxLengthInFirstList = number.Length;
                }
            }

            return maxLengthInFirstList;
        }

        static int GetMaxLengthInSecondList(List<string> secondList, int maxLengthInSecondList)
        {
            foreach (string number in secondList)
            {
                if (number.Length < maxLengthInSecondList)
                {
                    maxLengthInSecondList = number.Length;
                }
            }

            return maxLengthInSecondList;
        }

        static int GetTotalMaxLength(int maxLengthInFirstList, int maxLengthInSecondList, int totalMaxLength)
        {
            if (maxLengthInFirstList >= maxLengthInSecondList)
            {
                totalMaxLength = maxLengthInSecondList;
            }
            else
            {
                totalMaxLength = maxLengthInFirstList;
            }

            return totalMaxLength;
        }

        static List<string> RemoveUnnecesaryElementsInFirstList(List<string> firstList, int totalMaxLength)
        {
            for (int i = 0; i < firstList.Count; i++)
            {
                string number = firstList[i];
                string temporaryNumber = number;

                if (number.Contains("-"))
                {
                    temporaryNumber = (int.Parse(number) * (-1)).ToString();
                }

                if (number.Length > totalMaxLength)
                {
                    firstList.Remove(number);
                    i = -1;
                }
            }

            return firstList;
        }

        static List<string> RemoveUnnecesaryElementsInSecondList(List<string> secondList, int totalMaxLength)
        {
            for (int i = 0; i < secondList.Count; i++)
            {
                string number = secondList[i];
                string temporaryNumber = number;

                if (number.Contains("-"))
                {
                    temporaryNumber = (int.Parse(number) * (-1)).ToString();
                }

                if (temporaryNumber.Length > totalMaxLength)
                {
                    secondList.Remove(number);
                    i = -1;
                }
            }

            return secondList;
        }

        static List<string> GetResult(List<string> firstList, List<string> secondList, List<string> result)
        {
            int insertionIndex = 1;

            for (int i = 0; i < firstList.Count; i++)
            {
                string elementToInsert = firstList[i];
                secondList.Insert(Math.Min(insertionIndex, secondList.Count), elementToInsert);
                insertionIndex += 2;
            }

            return secondList;
        }
    }
}
