using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ArrayModifier
{
    class ArrayModifier
    {
        static void Main(string[] args)
        {
            List<long> array = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<string> commands = Console.ReadLine().Split(' ').ToList();

            while (commands[0] != "end")
            {
                switch (commands[0])
                {
                    case "swap":
                        long firstElement = array[int.Parse(commands[1])];
                        long secondElement = array[int.Parse(commands[2])];

                        array[int.Parse(commands[1])] = secondElement;
                        array[int.Parse(commands[2])] = firstElement;
                        break;
                    case "multiply":
                        long first = array[int.Parse(commands[1])];
                        long second = array[int.Parse(commands[2])];

                        array.RemoveAt(int.Parse(commands[1]));
                        array.Insert(int.Parse(commands[1]), first * second);
                        break;
                    case "decrease":
                        for (int i = 0; i < array.Count; i++)
                        {
                            array[i] -= 1;
                        }
                        break;
                }

                commands = Console.ReadLine().Split(' ').ToList();
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
