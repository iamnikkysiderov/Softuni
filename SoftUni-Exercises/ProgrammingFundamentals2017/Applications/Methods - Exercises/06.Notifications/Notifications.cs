using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Notifications
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int indexOfQueries = 0;

        while (indexOfQueries < n)
        {
            string inputLine = Console.ReadLine();
            indexOfQueries++;
            if (inputLine != "warning")
            {
                string operation = Console.ReadLine();
                string message = Console.ReadLine();


                if (inputLine == "success")
                {
                    ShowSuccess(operation, message);
                }
                else
                {
                    ShowError(operation, int.Parse(message));
                }
            }
        }
    }

    static void ShowError(string operation, int code)
    {
        Console.WriteLine("Error: Failed to execute {0}.", operation);
        Console.WriteLine("==============================");
        Console.WriteLine("Error Code: {0}.", code);
        if (code < 0)
        {
            Console.WriteLine("Reason: Internal System Failure.");
        }
        else
        {
            Console.WriteLine("Reason: Invalid Client Data.");
        }
    }

    static void ShowSuccess(string operation, string message)
    {
        Console.WriteLine("Successfully executed {0}.", operation);
        Console.WriteLine("==============================");
        Console.WriteLine("Message: {0}.", message);
    }
}