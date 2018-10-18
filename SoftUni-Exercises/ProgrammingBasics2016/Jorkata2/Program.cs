using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jorkata2
{
    class Program
    {
        static void Main(string[] args)
        {
            string upper = magicString("* ", 49) + "*";
            Console.WriteLine(upper);

            for (int i = 0; i < 20; i++)
            {
                string body = "*" + new string(' ', 98) + "*";
                Console.WriteLine(body);
            }
            Console.WriteLine(upper);

            
        }

        public static string magicString(string text,int repeatCount)
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
