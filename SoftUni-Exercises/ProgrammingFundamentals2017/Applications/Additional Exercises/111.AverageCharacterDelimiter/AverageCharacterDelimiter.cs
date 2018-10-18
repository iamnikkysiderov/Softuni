using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111.AverageCharacterDelimiter
{
    class AverageCharacterDelimiter
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = Console.ReadLine().Split(' ').ToList();
            double sum = 0;
            double counter = 0;

            for (int i = 0; i < listOfStrings.Count; i++)
            {
                string currentString = listOfStrings[i];

                for (int j = 0; j < currentString.Length; j++)
                {
                    sum += currentString[j];
                    counter++;
                }
            }

            double average = sum / counter;
            average = Math.Floor(average);

            char delimiter = (Char.ToUpperInvariant((char)average));

            Console.WriteLine(string.Join(delimiter.ToString(),listOfStrings));
        }
    }
}
