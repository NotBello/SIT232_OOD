// Created by Venujan Malaiyandi
// BSCP|CS|61|101
// For Task 6.2P


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankOrg
{
    class Account
    {
        private decimal balance;
        private string name;
        private bool validateWithdraw = false;
        private bool validateDeposit = false;



        public string Name
        {
            get { return name; }
        }



        public Account(decimal balance, string name)
        {
            this.balance = balance;
            this.name = name;
        }

        public bool Deposit(decimal amount)
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

        public bool Withdraw(decimal amount)
        {
            if (this.balance >= amount)
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
