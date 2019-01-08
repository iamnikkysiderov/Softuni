using System;
using System.Collections.Generic;
using System.Text;

namespace TestClient
{
    class BankAccount
    {
        string id;
        decimal balance;

        public string ID
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
