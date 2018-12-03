using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayModification
{
    class JaggedArrayModification
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                var inputParams = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                jaggedArray[i] = new int[inputParams.Length];

                for (int col = 0; col < inputParams.Length; col++)
                {
                    jaggedArray[i][col] = inputParams[col];

                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                var commandParams = command.Split(' ').ToArray();
                string mainCommand = commandParams[0];
                int rowIndex = int.Parse(commandParams[1]);
                int colIndex = int.Parse(commandParams[2]);
                int value = int.Parse(commandParams[3]);

                if (rowIndex > rows - 1 || rowIndex < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (colIndex > jaggedArray[rowIndex].Length - 1 || colIndex < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        switch (mainCommand)
                        {
                            case "Add":
                                jaggedArray[rowIndex][colIndex] += value;
                                break;
                            case "Subtract":
                                jaggedArray[rowIndex][colIndex] -= value;
                                break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var subArray in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", subArray));
            }
        }
    }
}
