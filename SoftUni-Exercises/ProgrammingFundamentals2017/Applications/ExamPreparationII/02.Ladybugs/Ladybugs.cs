using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] ladybugIndexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] field = new int[size];

            foreach (var ladybugIndex in ladybugIndexes)
            {
                if (ladybugIndex >= 0 && ladybugIndex < size)
                {
                    field[ladybugIndex] = 1;
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] commandParts = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int currentLadybugIndex = int.Parse(commandParts[0]);
                string direction = commandParts[1];
                int flyLength = int.Parse(commandParts[2]);

                if (currentLadybugIndex < 0 || currentLadybugIndex >= size)
                {
                    continue;
                }

                if (field[currentLadybugIndex] == 0)
                {
                    continue;
                }

                field[currentLadybugIndex] = 0;
                int position = currentLadybugIndex;

                while (true)
                {
                    if (direction == "right")
                    {
                        position += flyLength;
                    }
                    else
                    {
                        position -= flyLength;
                    }

                    if (position < 0 || position >= size)
                    {
                        break;
                    }

                    if (field[position] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[position] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}