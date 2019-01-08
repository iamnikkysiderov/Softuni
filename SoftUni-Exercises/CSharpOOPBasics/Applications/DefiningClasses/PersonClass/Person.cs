using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PersonClass
{
    class Person
    {
        string name;
        int age;
        List<BankAccount> accounts;

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }

        public decimal GetBalance()
        {
            return accounts.Sum(x => x.Balance);
        }
    }
}
