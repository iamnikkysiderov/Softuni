using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.WinningTicket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {
            string pattern = @"([#$^@])\1{5,}";

            Regex regex = new Regex(pattern);

            List<string> tickets = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string leftSide = ticket.Substring(0, ticket.Length / 2);
                string rightSide = ticket.Substring(ticket.Length / 2);

                Match leftMatch = regex.Match(leftSide);
                Match rightMatch = regex.Match(rightSide);

                if (leftMatch.Success && rightMatch.Success)
                {
                    char winningSymbol = leftMatch.Value[0];
                    int shorterMatchLength = Math.Min(leftMatch.Length, rightMatch.Length);

                    string jackpot = string.Empty;

                    if (shorterMatchLength == 10)
                    {
                        jackpot = " Jackpot!";
                    }

                    Console.WriteLine($"ticket \"{ticket}\" - {shorterMatchLength}{winningSymbol}{jackpot}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
