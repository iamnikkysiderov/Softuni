using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.VowelsSum
{
    class VowelsSum
    {
        static void Main(string[] args)
        {
            string textInput = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < textInput.Length; i++)
            {
                char letter = textInput[i];

                switch (letter)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
