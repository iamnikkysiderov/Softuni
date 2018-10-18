using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RegisteredUsers
{
    class RegisteredUsers
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, DateTime> registeredUsers = new Dictionary<string, DateTime>();

            while (input[0] != "end")
            {
                string username = input[0];
                string dateStr = input[2];
                DateTime date = DateTime.ParseExact(dateStr, "dd/MM/yyyy", null);
                
                registeredUsers[username] = date;

                input = Console.ReadLine().Split(' ').ToList();
            }

            registeredUsers = registeredUsers.Reverse().OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            int counter = 0;

            Dictionary<string, DateTime> result = new Dictionary<string, DateTime>();

            foreach (var kvp in registeredUsers)
            {
                counter++;
                string username = kvp.Key;
                DateTime date = kvp.Value;

                if (counter > 5)
                {
                    break;
                }
                else
                {
                    result.Add(username, date);
                }
            }

            foreach (var kvp in result.OrderByDescending(x => x.Value))
            {
                string username = kvp.Key;

                Console.WriteLine("{0}", username);
            }
        }
    }
}