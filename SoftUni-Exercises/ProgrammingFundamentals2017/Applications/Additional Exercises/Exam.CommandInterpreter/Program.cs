using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam.CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> commands = Console.ReadLine().Split(' ').ToList();
            
            while (commands[0] != "end")
            {
                if (CheckNegative(commands))
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    if (commands[0] == "reverse")
                    {
                        if (int.Parse(commands[2]) >= numbers.Count || int.Parse(commands[commands.Count - 1]) >= numbers.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            numbers = Reverse(numbers, commands);
                        }
                    }
                    else if (commands[0] == "sort")
                    {
                        if (int.Parse(commands[2]) >= numbers.Count || int.Parse(commands[commands.Count - 1]) >= numbers.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            numbers = Sort(numbers, commands);
                        }
                    }
                    else if (commands[0] == "rollLeft")
                    {
                        numbers = rollLeft(numbers, commands);
                    }
                    else if (commands[0] == "rollRight")
                    {
                        numbers = rollRight(numbers, commands);
                    }
                }

                commands = Console.ReadLine().Split(' ').ToList();
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }

        static List<string> Reverse(List<string> numbers, List<string> commands)
        {
            int indexToStartReversing = int.Parse(commands[2]);
            int count = int.Parse(commands[commands.Count - 1]);
            List<string> reversed = new List<string>();

            for (int i = indexToStartReversing, j = 0; j < count; i++, j++)
            {
                if (i < numbers.Count)
                {
                    reversed.Add(numbers[i]);
                }
            }

            reversed.Reverse();

            for (int i = indexToStartReversing, j = 0; j < count; j++)
            {
                if (i < numbers.Count)
                {
                    numbers.RemoveAt(i);
                }
            }

            for (int i = indexToStartReversing, j = 0; j <= reversed.Count - 1; i++, j++)
            {
                numbers.Insert(i, reversed[j]);
            }

            return numbers;
        }

        static List<string> Sort(List<string> numbers, List<string> commands)
        {
            int indexToStartReversing = int.Parse(commands[2]);
            int count = int.Parse(commands[commands.Count - 1]);
            List<string> sorted = new List<string>();

            for (int i = indexToStartReversing, j = 0; j < count; i++, j++)
            {
                if (i < numbers.Count)
                {
                    sorted.Add(numbers[i]);
                }
            }

            sorted.Sort();

            List<string> copyOfNumbers = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                copyOfNumbers.Add(numbers[i]);
            }

            for (int i = indexToStartReversing, j = 0; j < count; j++)
            {
                if (i < numbers.Count)
                {
                    numbers.RemoveAt(i);
                }
            }
            for (int i = indexToStartReversing, j = 0; j <= sorted.Count - 1; i++, j++)
            {
                numbers.Insert(i, sorted[j]);
            }

            return numbers;
        }

        static List<string> rollLeft(List<string> numbers, List<string> commands)
        {
            int timesToRoll = int.Parse(commands[1]);
            List<string> container = new List<string>();
            List<string> copyOfNumbers = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                copyOfNumbers.Add(numbers[i]);
            }

            for (int i = 0; i < timesToRoll; i++)
            {
                while (timesToRoll > numbers.Count)
                {
                    timesToRoll -= numbers.Count;
                }

                container.Add(numbers[i]);
                copyOfNumbers.RemoveAt(0);

                if (i + 1 > numbers.Count)
                {
                    timesToRoll -= numbers.Count;
                    i = 0;
                    container = null;
                }
            }

            numbers = rollLeftResult(copyOfNumbers, numbers, container);

            return numbers;
        }

        static List<string> rollRight(List<string> numbers, List<string> commands)
        {
            int timesToRoll = int.Parse(commands[1]);
            List<string> container = new List<string>();
            List<string> copyOfNumbers = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                copyOfNumbers.Add(numbers[i]);
            }

            while (timesToRoll > numbers.Count)
            {
                timesToRoll -= numbers.Count;
            }

            for (int i = numbers.Count - 1; i > numbers.Count - 1 - timesToRoll; i--)
            {
                container.Add(numbers[i]);

                if (i - 1 < 0)
                {
                    timesToRoll -= numbers.Count;
                    i = 0;
                    container = null;
                }
            }

            for (int i = numbers.Count - timesToRoll - 1; i >= 0; i--)
            {
                numbers[i + timesToRoll] = numbers[i];
            }

            container.Reverse();

            for (int i = 0; i < container.Count; i++)
            {
                numbers.RemoveAt(i);
                numbers.Insert(i, container[i]);
            }

            return numbers;
        }

        static List<string> rollLeftResult(List<string> copyOfNumbers, List<string> numbers, List<string> container)
        {
            for (int i = 0; i < copyOfNumbers.Count + 1; i++)
            {
                if (i >= copyOfNumbers.Count)
                {
                    copyOfNumbers.AddRange(container);
                    numbers = copyOfNumbers;
                    break;
                }
            }

            return numbers;
        }

        static bool CheckNegative(List<string> commands)
        {
            bool negative = false;

            for (int i = 0; i < commands.Count; i++)
            {
                if (commands[i].Contains("-"))
                {
                    negative = true;
                    break;
                }
            }

            if (negative)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
