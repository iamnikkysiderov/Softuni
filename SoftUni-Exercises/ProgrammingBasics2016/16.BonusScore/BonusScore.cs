using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());

            int totalPoints = points;
            int under100 = 5;
            int even = 1;
            double over100 = points * 0.2;
            double over1000 = points * 0.1;
            int endsWith5 = 2;
            bool lastDigit = (points % 10 == 5);

            if (points <= 100 && points % 2 == 0)
            {
                Console.WriteLine(under100 + even);
                Console.WriteLine(totalPoints + under100 + even);
            }
            if (points <= 100 && points % 2 != 0 && !lastDigit)
            {
                Console.WriteLine(under100);
                Console.WriteLine(totalPoints + under100);
            }
            if (points <= 100 && points % 2 != 0 && lastDigit)
            {
                Console.WriteLine(under100 + endsWith5);
                Console.WriteLine(totalPoints + under100 + endsWith5);
            }
            if (points > 100 && points < 1000 && points % 2 == 0)
            {
                Console.WriteLine(over100 + even);
                Console.WriteLine(totalPoints + over100 + even);
            }
            if (points > 100 && points < 1000 && points % 2 != 0 && !lastDigit)
            {
                Console.WriteLine(over100);
                Console.WriteLine(totalPoints + over100);
            }
            if (points > 100 && points < 1000 && points % 2 != 0 && lastDigit)
            {
                Console.WriteLine(over100 + endsWith5);
                Console.WriteLine(totalPoints + over100 + endsWith5);
            }
            if (points >= 1000 && points % 2 == 0)
            {
                Console.WriteLine(over1000 + even);
                Console.WriteLine(totalPoints + over1000 + even);
            }
            if (points >= 1000 && points % 2 != 0 && !lastDigit)
            {
                Console.WriteLine(over1000);
                Console.WriteLine(totalPoints + over1000);
            }
            if (points >= 1000 && points % 2 != 0 && lastDigit)
            {
                Console.WriteLine(over1000 + endsWith5);
                Console.WriteLine(totalPoints + over1000 + endsWith5);
            }
        }
    }
}
