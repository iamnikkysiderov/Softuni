using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasicsDecember2016CombinationOfChars
{
    class Program
    {
        static void Main(string[] args)
        { //Sam ya reshih i ya razbrah!
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char exclusion = char.Parse(Console.ReadLine());

            for (char firstCharLoop = firstLetter; firstCharLoop <= secondLetter; firstCharLoop++)
            {
                for (char secondCharLoop = firstLetter; secondCharLoop <= secondLetter; secondCharLoop++)
                {
                    for (char thirdCharLoop = firstLetter; thirdCharLoop <= secondLetter; thirdCharLoop++)
                    {
                        if (firstCharLoop == exclusion || secondCharLoop == exclusion || thirdCharLoop == exclusion)
                        {
                            continue;
                        }
                        
                        Console.Write("{0}{1}{2} ",firstCharLoop,secondCharLoop,thirdCharLoop);
                    }
                }
            }
        } 

        public static string magicString(string text, int repeatCount)
        {
            string outputText = "";

            for (int i = 0; i < repeatCount; i++)
            {
                outputText += text;
            }

            return outputText;
        }
    }
}
