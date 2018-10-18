using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Extremums
{
    class Extremums
    {
        static void Main(string[] args)
        {
            List<int> startingSequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            int currentSum = startingSequence.Sum();
            int maxSum = int.MinValue;
            int minSum = int.MaxValue;

            switch (command)
            {
                case "Max":
                    maxSum = currentSum;

                    for (int i = 0; i < startingSequence.Count; i++)
                    {
                        int currentNumber = startingSequence[i];

                        if (currentNumber.ToString().Length == 1)
                        {
                            continue;
                        }

                        while (true)
                        {
                            char firstDigit = currentNumber.ToString()[0];
                            currentNumber = int.Parse(currentNumber.ToString().Remove(0, 1));
                            currentNumber = int.Parse(currentNumber.ToString() + firstDigit);

                            if (startingSequence[i] < currentNumber)
                            {
                                startingSequence[i] = currentNumber;
                            }
                            else if (startingSequence[i] == currentNumber)
                            {
                                break;
                            }
                        }
                    }

                    maxSum = startingSequence.Sum();
                    break;
                case "Min":
                    break;
            }

            Console.WriteLine(maxSum);
        }
    }
}
