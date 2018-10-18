using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string pattern = @"[A-Z][a-z]+ [A-Z][a-z]+";

            Regex regex = new Regex(pattern);

            Console.WriteLine(regex.IsMatch(name));
        }
    }
}
