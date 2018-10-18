using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningCoins_Broken
{
    class DebuggingExerciseMinningCoins
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string decrypted = string.Empty;
            float totalValue = 0f;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int firstDigit = number / 100;
                int middleDigit = (number % 100) / 10;
                int lastDigit = number % 10;
                
                int ASCIIcode = 0;

                if (i % 2 != 0)
                {
                    ASCIIcode = (int.Parse(firstDigit.ToString() + lastDigit.ToString())) - middleDigit;
                }
                else
                {
                    ASCIIcode = (int.Parse(firstDigit.ToString() + lastDigit.ToString())) + middleDigit;
                }

                if ((ASCIIcode >= 65 && ASCIIcode <= 90)
                    || (ASCIIcode >= 97 && ASCIIcode <= 122))
                {
                    decrypted += (char)ASCIIcode;
                }

                totalValue += (firstDigit + middleDigit + lastDigit) / (float)n;
            }
            
            Console.WriteLine("Message: {0}", decrypted);
            Console.WriteLine("Value: {0:F7}", totalValue);
        }
    }
}
