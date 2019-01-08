using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountMethods
{
    class BankAccount
    {
        int id;
        decimal balance;

        public int ID
        {
            get { return id; }
            set { this.id = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { this.balance = value; }
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {this.ID}, balance {this.Balance}";
        }
    }
}
