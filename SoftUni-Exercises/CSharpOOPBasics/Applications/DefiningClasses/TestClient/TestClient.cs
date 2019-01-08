using System;
using System.Collections.Generic;

namespace TestClient
{
    class TestClient
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var accounts = new Dictionary<string, BankAccount>();

            while (input[0] != "End")
            {
                switch (input[0])
                {
                    case "Create":
                        if (accounts.ContainsKey(input[1]))
                        {
                            Console.WriteLine("Account already exists");
                        }
                        else
                        {
                            accounts[input[1]] = new BankAccount();
                            accounts[input[1]].ID = "ID" + input[1];
                        }
                        break;
                    case "Deposit":
                        if (accounts.ContainsKey(input[1]))
                        {
                            accounts[input[1]].Deposit(int.Parse(input[2]));
                        }
                        else
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        break;
                    case "Withdraw":
                        if (accounts.ContainsKey(input[1]))
                        {
                            accounts[input[1]].Withdraw(int.Parse(input[2]));

                            if (accounts[input[1]].Balance < 0)
                            {
                                Console.WriteLine("Insufficient balance");
                                accounts[input[1]].Deposit(int.Parse(input[2]));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        break;
                    case "Print":
                        if (accounts.ContainsKey(input[1]))
                        {
                            Console.WriteLine(accounts[input[1]].ToString());
                        }
                        else
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        break;
                }

                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
