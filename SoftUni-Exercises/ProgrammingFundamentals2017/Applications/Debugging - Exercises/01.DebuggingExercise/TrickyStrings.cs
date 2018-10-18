using System;

class DebuggingExerciseTrickyStrings
{
    static void Main(string[] args)
    {
        string delimiter = Console.ReadLine();
        int numberOfStrings = int.Parse(Console.ReadLine());

        string result = string.Empty;

        for (int i = 1; i <= numberOfStrings; i++)
        {
            string currentString = Console.ReadLine();
            if (i == numberOfStrings)
            {
                delimiter = string.Empty;
            }

            result += currentString + delimiter;
        }

        Console.WriteLine(result);
    }
}
