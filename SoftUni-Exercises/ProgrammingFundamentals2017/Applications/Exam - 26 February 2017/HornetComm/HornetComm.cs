using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetComm
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> messages = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> broadcasts = new Dictionary<string, List<string>>();

            while (input != "Hornet is Green")
            {
                List<string> inputParams = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string firstQuery = inputParams[0];
                string secondQuery = inputParams[2];

                bool firstQueryIsDigits = false;

                for (int i = 0; i < firstQuery.Length; i++)
                {
                    if (firstQuery[i] >= 48 && firstQuery[i] <= 57)
                    {
                        firstQueryIsDigits = true;
                    }
                    else
                    {
                        firstQueryIsDigits = false;
                        break;
                    }
                }

                if (firstQueryIsDigits) // message
                {
                    if (!messages.ContainsKey(firstQuery))
                    {
                        messages[firstQuery] = new List<string>();
                    }

                    messages[firstQuery].Add(secondQuery);
                }
                else // broadcast
                {
                    if (!broadcasts.ContainsKey(secondQuery))
                    {
                        broadcasts[secondQuery] = new List<string>();
                    }

                    broadcasts[secondQuery].Add(firstQuery);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");

            foreach (var broadcast in broadcasts)
            {
                for (int i = 0; i < broadcast.Value.Count; i++)
                {
                    Console.WriteLine($"{broadcast.Key} -> {broadcast.Value[i]}");
                }
            }

            Console.WriteLine("Messages:");

            foreach (var message in messages)
            {
                string reversedKey = string.Empty;

                for (int i = message.Key.Length-1; i >= 0; i--)
                {
                    reversedKey += message.Key[i];
                }

                for (int i = 0; i < message.Value.Count; i++)
                {
                    Console.WriteLine($"{reversedKey} -> {message.Value[i]}");
                }
            }
        }
    }
}
