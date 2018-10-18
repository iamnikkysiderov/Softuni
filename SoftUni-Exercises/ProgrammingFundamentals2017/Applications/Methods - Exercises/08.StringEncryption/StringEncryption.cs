using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.StringEncryption
{
    class StringEncryption
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] storedCharacters = new char[n];

            for (int i = 0; i < n; i++)
            {
                char character = char.Parse(Console.ReadLine());
                storedCharacters[i] = character;
            }

            string result = EncryptString(storedCharacters, n);
            Console.WriteLine(result);
        }

        static string EncryptString(char[] storedCharacters, int n)
        {
            string[] endResultString = new string[n];

            for (int i = 0; i < n; i++)
            {
                int valueOfIChar = (int)(storedCharacters[i]);
                int lastDigitOfCharValue = valueOfIChar % 10;
                int firstDigitOfCharValue = 0;
                int temporaryValueOfIChar = valueOfIChar;

                while (temporaryValueOfIChar > 0)
                {
                    int remainder = temporaryValueOfIChar % 10;
                    temporaryValueOfIChar /= 10;
                    firstDigitOfCharValue = remainder;
                }

                char charToStart = (char)(valueOfIChar + lastDigitOfCharValue);
                char charToEnd = (char)(valueOfIChar - firstDigitOfCharValue);

                string endResult = charToStart + firstDigitOfCharValue.ToString() + lastDigitOfCharValue.ToString() + charToEnd;
                endResultString[i] = endResult;
            }

            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string temporary = endResultString[i];
                result += temporary;
            }

            return result;
        }
    }
}
