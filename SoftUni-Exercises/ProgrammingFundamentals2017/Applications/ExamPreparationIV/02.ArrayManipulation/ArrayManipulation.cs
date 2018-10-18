using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayManipulation
{
    class ArrayManipulation
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                List<string> inputParams = input.Split(' ').ToList();
                string command = inputParams[0];

                switch (command)
                {
                    case "exchange":
                        numbers = Exchange(numbers, inputParams, input);
                        break;
                    case "max":
                        numbers = Max(numbers, inputParams);
                        break;
                    case "min":
                        numbers = Min(numbers, inputParams);
                        break;
                    case "first":
                        numbers = First(numbers, inputParams, input);
                        break;
                    case "last":
                        numbers = Last(numbers, inputParams, input);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }
        static List<int> Exchange(List<int> numbers, List<string> inputParams, string input)
        {
            int index = int.Parse(inputParams[1]);

            if (index > numbers.Count - 1 || index < 0)
            {
                Console.WriteLine("Invalid index");
                return numbers;
            }

            List<int> firstSubString = new List<int>();
            List<int> secondSubString = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i > index)
                {
                    secondSubString.Add(numbers[i]);
                    continue;
                }

                firstSubString.Add(numbers[i]);
            }

            numbers = secondSubString.ToList();
            numbers.AddRange(firstSubString);

            return numbers;
        }
        static List<int> Max(List<int> numbers, List<string> inputParams)
        {
            if (inputParams[1] == "odd")
            {
                int maxValue = int.MinValue;
                int indexOfMaxOdd = -1;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        if (numbers[i] >= maxValue)
                        {
                            maxValue = numbers[i];
                            indexOfMaxOdd = i;
                        }
                    }
                }

                if (indexOfMaxOdd >= 0)
                {
                    Console.WriteLine(indexOfMaxOdd);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else if (inputParams[1] == "even")
            {
                int maxValue = int.MinValue;
                int indexOfMaxEven = -1;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        if (numbers[i] >= maxValue)
                        {
                            maxValue = numbers[i];
                            indexOfMaxEven = i;
                        }
                    }
                }

                if (indexOfMaxEven >= 0)
                {
                    Console.WriteLine(indexOfMaxEven);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }

            return numbers;
        }
        static List<int> Min(List<int> numbers, List<string> inputParams)
        {
            if (inputParams[1] == "odd")
            {
                int minValue = int.MaxValue;
                int indexOfMinOdd = -1;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        if (numbers[i] <= minValue)
                        {
                            minValue = numbers[i];
                            indexOfMinOdd = i;
                        }
                    }
                }

                if (indexOfMinOdd >= 0)
                {
                    Console.WriteLine(indexOfMinOdd);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else if (inputParams[1] == "even")
            {
                int minValue = int.MaxValue;
                int indexOfMinEven = -1;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        if (numbers[i] <= minValue)
                        {
                            minValue = numbers[i];
                            indexOfMinEven = i;
                        }
                    }
                }

                if (indexOfMinEven >= 0)
                {
                    Console.WriteLine(indexOfMinEven);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }

            return numbers;
        }
        static List<int> First(List<int> numbers, List<string> inputParams, string input)
        {
            int count = int.Parse(inputParams[1]);

            if (count > numbers.Count || count < 0)
            {
                Console.WriteLine("Invalid count");
                return numbers;
            }

            if (inputParams[2] == "odd")
            {
                int oddCount = 0;
                List<int> odds = new List<int>();

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        oddCount++;
                        odds.Add(numbers[i]);
                    }

                    if (oddCount >= count)
                    {
                        break;
                    }
                }

                Console.WriteLine("[{0}]", string.Join(", ", odds));
            }
            else if (inputParams[2] == "even")
            {
                int evenCount = 0;
                List<int> evens = new List<int>();

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        evenCount++;
                        evens.Add(numbers[i]);
                    }

                    if (evenCount >= count)
                    {
                        break;
                    }
                }

                Console.WriteLine("[{0}]", string.Join(", ", evens));
            }

            return numbers;
        }
        static List<int> Last(List<int> numbers, List<string> inputParams, string input)
        {
            int countLast = int.Parse(inputParams[1]);

            if (countLast > numbers.Count || countLast < 0)
            {
                Console.WriteLine("Invalid count");
                return numbers;
            }

            if (inputParams[2] == "odd")
            {
                int oddCount = 0;
                List<int> odds = new List<int>();

                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        oddCount++;
                        odds.Add(numbers[i]);
                    }

                    if (oddCount >= countLast)
                    {
                        break;
                    }
                }

                odds.Reverse();

                Console.WriteLine("[{0}]", string.Join(", ", odds));
            }
            else if (inputParams[2] == "even")
            {
                int evenCount = 0;
                List<int> evens = new List<int>();

                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        evenCount++;
                        evens.Add(numbers[i]);
                    }

                    if (evenCount >= countLast)
                    {
                        break;
                    }
                }

                Console.WriteLine("[{0}]", string.Join(", ", evens));
            }

            return numbers;
        }
    }
}
