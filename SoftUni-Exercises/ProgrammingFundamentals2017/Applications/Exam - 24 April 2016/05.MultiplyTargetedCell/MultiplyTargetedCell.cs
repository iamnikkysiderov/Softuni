using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MultiplyTargetedCell
{
    class MultiplyTargetedCell
    {
        static void Main(string[] args)
        {
            List<int> rowsAndCols = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int[]> listOfArrays = new List<int[]>();

            for (int i = 0; i < rowsAndCols[0]; i++)
            {
                int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                listOfArrays.Add(array);
            }

            List<int> targetedCell = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            PrintUpdatedMatrix(listOfArrays, targetedCell);
        }
        static void PrintUpdatedMatrix(List<int[]> listOfArrays, List<int> targetedCell)
        {
            int sum = 0;

            int y = targetedCell[0];
            int x = targetedCell[1];

            int cell = 0;

            for (int i = 0; i < listOfArrays.Count; i++)
            {
                if (i == y)
                {
                    int[] currentArray = listOfArrays[i];

                    for (int j = 0; j < currentArray.Length; j++)
                    {
                        if (j == x)
                        {
                            cell = currentArray[j];
                        }
                    }
                }
            }

            for (int i = 0; i < listOfArrays.Count; i++)
            {
                if (i == y - 1)
                {
                    int[] currentArray = listOfArrays[i];

                    for (int j = 0; j < currentArray.Length; j++)
                    {
                        if (j == x - 1)
                        {
                            try
                            {
                                sum += currentArray[j];
                                sum += currentArray[j + 1];
                                sum += currentArray[j + 2];
                            }
                            catch (IndexOutOfRangeException)
                            {

                                throw;
                            }
                        }
                    }
                }
                else if (i == y)
                {
                    int[] currentArray = listOfArrays[i];

                    for (int j = 0; j < currentArray.Length; j++)
                    {
                        if (j == x - 1)
                        {
                            try
                            {
                                sum += currentArray[j];
                                sum += currentArray[j + 2];
                            }
                            catch (IndexOutOfRangeException)
                            {

                                throw;
                            }
                        }
                    }
                }
                else if (i == y + 1)
                {
                    int[] currentArray = listOfArrays[i];

                    for (int j = 0; j < currentArray.Length; j++)
                    {
                        if (j == x - 1)
                        {
                            try
                            {
                                sum += currentArray[j];
                                sum += currentArray[j + 1];
                                sum += currentArray[j + 2];
                            }
                            catch (IndexOutOfRangeException)
                            {

                                throw;
                            }
                        }
                    }
                }
            }

            int valueOfTargetedCell = 0;

            for (int i = 0; i < listOfArrays.Count; i++)
            {
                if (i == y)
                {
                    for (int j = 0; j < listOfArrays[i].Length; j++)
                    {
                        if (j == x)
                        {
                            valueOfTargetedCell = listOfArrays[i][j];
                            listOfArrays[i][j] *= sum;
                        }
                    }
                }
            }

            for (int i = 0; i < listOfArrays.Count; i++)
            {
                if (i == y - 1)
                {
                    int[] currentArray = listOfArrays[i];

                    for (int j = 0; j < currentArray.Length; j++)
                    {
                        if (j == x - 1)
                        {
                            try
                            {
                                currentArray[j] *= valueOfTargetedCell;
                                currentArray[j + 1] *= valueOfTargetedCell;
                                currentArray[j + 2] *= valueOfTargetedCell;
                            }
                            catch (IndexOutOfRangeException)
                            {

                                throw;
                            }
                        }
                    }
                }
                else if (i == y)
                {
                    int[] currentArray = listOfArrays[i];

                    for (int j = 0; j < currentArray.Length; j++)
                    {
                        if (j == x - 1)
                        {
                            try
                            {
                                currentArray[j] *= valueOfTargetedCell;
                                currentArray[j + 2] *= valueOfTargetedCell;
                            }
                            catch (IndexOutOfRangeException)
                            {

                                throw;
                            }
                        }
                    }
                }
                else if (i == y+1)
                {
                    int[] currentArray = listOfArrays[i];

                    for (int j = 0; j < currentArray.Length; j++)
                    {
                        if (j == x - 1)
                        {
                            try
                            {
                                currentArray[j] *= valueOfTargetedCell;
                                currentArray[j + 1] *= valueOfTargetedCell;
                                currentArray[j + 2] *= valueOfTargetedCell;
                            }
                            catch (IndexOutOfRangeException)
                            {

                                throw;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < listOfArrays.Count; i++)
            {
                int[] currentArray = listOfArrays[i];

                Console.WriteLine(string.Join(" ", currentArray));
            }
        }
    }
}
