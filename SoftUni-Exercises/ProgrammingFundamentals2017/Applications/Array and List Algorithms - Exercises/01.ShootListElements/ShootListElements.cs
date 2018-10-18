using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShootListElements
{
    class ShootListElements
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<int> numbers = new List<int>();
            int lastElementShooted = 0;
            int count = 0;

            while (command != "stop")
            {
                if (command == "bang" && numbers.Count == 0)
                {
                    Console.WriteLine("nobody left to shoot! last one was {0}", lastElementShooted);
                    count++;
                    break;
                }
                else
                {
                    try
                    {
                        numbers.Add(int.Parse(command));
                    }
                    catch (System.FormatException)
                    {
                        numbers.Reverse();

                        if (command == "bang")
                        {
                            int sum = 0;

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                sum += numbers[i];
                            }

                            double average = (double)sum / numbers.Count;

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < average || numbers.Count == 1)
                                {
                                    lastElementShooted = numbers[i];
                                    Console.WriteLine("shot {0}", numbers[i]);
                                    numbers.RemoveAt(i);
                                    break;
                                }
                            }

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                numbers[i] -= 1;
                            }

                        }

                        numbers.Reverse();
                    }
                }

                command = Console.ReadLine();
            }

            if (count == 0 && numbers.Count == 0)
            {
                Console.WriteLine("you shot them all. last one was {0}", lastElementShooted);
            }
            else if (count == 0 && numbers.Count > 0)
            {
                numbers.Reverse();
                Console.WriteLine("survivors: {0}", string.Join(" ", numbers));
            }
        }
    }
}
