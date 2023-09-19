using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Account
    {
        private double balance;
        private string name;
        private bool validateWithdraw = false;
        private bool validateDeposit = false;



        public string Name
        {
            get { return name; }
        }



        public Account(double balance, string name)
        {
            this.balance = balance;
            this.name = name;
        }

        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                validateDeposit = true;
                this.balance += amount;
            }
            else
            {
                validateDeposit = false;
            }
            return validateDeposit;

        }

        public bool Withdraw(double amount)
        {
            if (this.balance > amount)
            {
                this.validateWithdraw = true;
                this.balance -= amount;

            }
            else
            {
                validateWithdraw = false;
            }
            return validateWithdraw;

        }

        public void Print()
        {
            Console.WriteLine($"Hey {this.name}, your balance is {this.balance}");
        }


    }
}
