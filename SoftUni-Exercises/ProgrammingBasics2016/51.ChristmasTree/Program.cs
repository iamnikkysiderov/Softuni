using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int rows = n + 1;

        for (int i = 0; i < rows; i++)
        {
            var row = new string(' ', n - i) + new string('*', i) + " | " + new string('*', i) + new string(' ', n - i);

            Console.WriteLine(row);
        }
    }
}