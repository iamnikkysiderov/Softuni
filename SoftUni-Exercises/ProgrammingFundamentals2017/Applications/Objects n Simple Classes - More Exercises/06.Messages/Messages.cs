using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Messages // not done
{
    class Messages
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<User> users = new List<User>();

            while (input != "exit")
            {
                List<string> inputParams = Console.ReadLine().Split(' ').ToList();

                if (inputParams[0] == "register")
                {
                    User user = new User();
                    user.Name = inputParams[1];
                    user.ReceivedMessages = new List<string>();

                    users.Add(user);
                }
                else
                {
                    bool firstUserIsContained = false;
                    bool secondUserIsContained = false;

                    for (int i = 0; i < users.Count; i++)
                    {
                        if (users[i].Name == inputParams[0])
                        {
                            firstUserIsContained = true;
                        }
                    }

                    for (int i = 0; i < users.Count; i++)
                    {
                        if (users[i].Name == inputParams[2])
                        {
                            secondUserIsContained = true;
                        }
                    }

                    if (firstUserIsContained && secondUserIsContained)
                    {
                        Message message = new Message();
                        message.Sender = inputParams[0];
                        message.Content = inputParams[3];

                        for (int i = 0; i < users.Count; i++)
                        {
                            if (users[i].Name == inputParams[2])
                            {
                                users[i].ReceivedMessages.Add(message.Content);
                            }
                        }
                    }
                }
            }

            List<string> usersToChat = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Name.Contains(usersToChat[0]))
                {
                    for (int j = 0; j < users.Count; j++)
                    {
                        if (users[j].Name.Contains(usersToChat[1]))
                        {
                            User firstUser = new User();
                            firstUser = users[i];
                            User secondUser = new User();
                            secondUser = users[j];

                            if (firstUser.ReceivedMessages.Count >= secondUser.ReceivedMessages.Count)
                            {
                                for (int k = 0; k < firstUser.ReceivedMessages.Count; k++)
                                {
                                    if (secondUser.ReceivedMessages.Count == k)
                                    {
                                        for (int o = k; o < firstUser.ReceivedMessages.Count; o++)
                                        {
                                            Console.WriteLine($"{firstUser.Name}: {secondUser.ReceivedMessages[o]}");
                                            Console.WriteLine();
                                        }
                                    }

                                    Console.WriteLine($"{firstUser.Name}: {secondUser.ReceivedMessages[k]}");
                                    Console.WriteLine($"{firstUser.ReceivedMessages[k]} :{secondUser.Name}");
                                }
                            }
                            else
                            {

                            }
                        }
                    }
                }
            }
        }
    }
}
