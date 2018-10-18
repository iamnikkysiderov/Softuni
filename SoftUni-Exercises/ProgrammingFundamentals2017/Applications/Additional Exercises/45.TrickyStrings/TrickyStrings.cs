using System;
class TrickyStrings
{
    static void Main(string[] args)
    {
        string delimiter = Console.ReadLine();
        int numberOfNextInputTexts = int.Parse(Console.ReadLine());

        string[] words = new string[numberOfNextInputTexts];

        CollectWordsInArray(words, numberOfNextInputTexts);
        PrintOutputText(numberOfNextInputTexts, words, delimiter);
    }

    static string[] CollectWordsInArray(string[] words, int numberOfNextInputTexts)
    {
        for (int i = 0; i < numberOfNextInputTexts; i++)
        {
            string text = Console.ReadLine();
            words[i] = text;

        }

        return words;
    }

    static void PrintOutputText(int numberOfNextInputTexts, string[] words, string delimiter)
    {
        for (int i = 0; i < numberOfNextInputTexts; i++)
        {
            Console.Write(words[i]);

            if (i != numberOfNextInputTexts - 1)
            {
                Console.Write(delimiter);
            }
        }
        Console.WriteLine();
    }
}
