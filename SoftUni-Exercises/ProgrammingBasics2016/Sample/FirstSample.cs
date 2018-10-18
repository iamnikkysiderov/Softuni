using System;

class FirstSample
{
    static void Main()
    { // nyamam si na predstawa koya e taya zadacha
        int n = int.Parse(Console.ReadLine());
        
        int width = n;
        int height = n;

        if (n == 2)
        {
            Console.WriteLine("**");
            Console.WriteLine("||");
        }
        else
        {
            string topHouseOdd = new string('_', n / 2) + "*" + new string('_', n / 2);
            string topHouseEven = new string('_', n / 2) + "**" + new string('_', n / 2);

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('_',))
            }
        }
    }
}