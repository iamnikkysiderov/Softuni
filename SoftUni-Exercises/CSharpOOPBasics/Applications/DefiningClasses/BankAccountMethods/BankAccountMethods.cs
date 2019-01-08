using System;

namespace BankAccountMethods
{
    class BankAccountMethods
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            acc.ID = 1;
            acc.Balance = 15;

            acc.Deposit(3);
            acc.Withdraw(5);

            Console.WriteLine(acc.ToString());
        }
    }
}
