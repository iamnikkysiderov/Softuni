using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _129.UserLogins
{
    class UserLogins
    {
        static void Main(string[] args)
        {
            List<string> listUsernamePassword = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, string> usernameAndPasswordPairs = new Dictionary<string, string>();
            bool login = false;
            int countOfUnsuccessfullLogins = 0;

            while (listUsernamePassword[0] != "end")
            {
                while (listUsernamePassword[0] != "login" && login == false)
                {
                    string usernameToStore = listUsernamePassword[0];
                    string passwordToStore = listUsernamePassword[listUsernamePassword.Count - 1];

                    usernameAndPasswordPairs[usernameToStore] = passwordToStore;

                    listUsernamePassword = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }

                login = true;

                if (listUsernamePassword[0] != "login")
                {
                    string username = listUsernamePassword[0];
                    string password = listUsernamePassword[listUsernamePassword.Count - 1];

                    if (usernameAndPasswordPairs.ContainsKey(username))
                    {
                        if (usernameAndPasswordPairs[username] == password)
                        {
                            Console.WriteLine($"{username}: logged in successfully");
                        }
                        else
                        {
                            Console.WriteLine($"{username}: login failed");
                            countOfUnsuccessfullLogins++;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{username}: login failed");
                        countOfUnsuccessfullLogins++;
                    }
                }

                listUsernamePassword = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            Console.WriteLine($"unsuccessful login attempts: {countOfUnsuccessfullLogins}");
        }
    }
}
