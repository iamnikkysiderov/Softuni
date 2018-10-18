using System;
using System.Text.RegularExpressions;

namespace _03.ReplaceTag
{
    class ReplaceTag
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string pattern = @"<a.+?href=(.+?)>(.*?)<\/a>";

                Regex regex = new Regex(pattern);

                string replacement = "[URL href=$1]$2[/URL]";

                string result = regex.Replace(input, replacement);

                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}
