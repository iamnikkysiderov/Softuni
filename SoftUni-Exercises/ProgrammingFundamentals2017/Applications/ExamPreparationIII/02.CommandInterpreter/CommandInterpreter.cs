using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(x => x.Trim()).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> commandParams = command.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string mainCommand = commandParams[0];

                switch (mainCommand)
                {
                    case "reverse":
                        int startingIndex = int.Parse(commandParams[2]);
                        int count = int.Parse(commandParams[4]);

                        if (IsValidReverse(array, startingIndex, count))
                        {
                            array = ReverseArray(startingIndex, count, array);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "sort":
                        int index = int.Parse(commandParams[2]);
                        int times = int.Parse(commandParams[4]);
                        
                        if (IsValidSort(array, index, times))
                        {
                            array = SortArray(index, times, array);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "rollLeft":
                        int leftCount = int.Parse(commandParams[1]);
                        leftCount %= array.Count;

                        if (leftCount >= 0)
                        {
                            array = RollLeft(leftCount, array);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "rollRight":
                        int rightCount = int.Parse(commandParams[1]);
                        rightCount %= array.Count;

                        if (rightCount >= 0)
                        {
                            array = RollRight(rightCount, array);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
        static List<string> ReverseArray(int startingIndex, int count, List<string> array)
        {
            string[] subArray = new string[count];

            for (int i = startingIndex, j = 0; j < count; j++)
            {
                subArray[j] = array[startingIndex];
                array.RemoveAt(i);
            }

            for (int i = startingIndex, j = 0; j < count; j++)
            {
                array.Insert(i, subArray[j]);
            }

            return array;
        }
        static List<string> SortArray(int index, int times, List<string> array)
        {
            string[] miniArray = new string[times];

            for (int i = index, j = 0; j < times; j++)
            {
                miniArray[j] = array[index];
                array.RemoveAt(i);
            }

            miniArray = miniArray.OrderByDescending(x => x).ToArray();

            for (int i = index, j = 0; j < times; j++)
            {
                array.Insert(i, miniArray[j]);
            }

            return array;
        }
        static List<string> RollLeft(int leftCount, List<string> array)
        {
            for (int i = 0; i < leftCount; i++)
            {
                string firstElement = array[0];

                for (int j = 0; j < array.Count - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Count - 1] = firstElement;
            }

            return array;
        }
        static List<string> RollRight(int rightCount, List<string> array)
        {
            for (int i = 0; i < rightCount; i++)
            {
                string lastElement = array[array.Count - 1];

                for (int j = array.Count - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }

                array[0] = lastElement;
            }
            return array;
        }
        static bool IsValidReverse(List<string> array, int startingIndex, int count)
        {
            return startingIndex >= 0 && startingIndex < array.Count && count >= 0 && startingIndex + count <= array.Count;
        }
        static bool IsValidSort(List<string> array, int index, int times)
        {
            return index >= 0 && index < array.Count && times >= 0 && index + times <= array.Count;
        }
    }
}
