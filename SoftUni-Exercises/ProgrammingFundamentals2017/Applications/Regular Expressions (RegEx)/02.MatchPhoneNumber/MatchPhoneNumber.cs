using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string phoneNumber = Console.ReadLine();

            string pattern = @"\+(\d{3})(\s|-)(\d{1})\2\d{3}\2\d{4}";

            Regex regex = new Regex(pattern);

            Console.WriteLine(regex.IsMatch(phoneNumber));
        }
    }
}
