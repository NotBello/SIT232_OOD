// Created by Venujan Malaiyandi
// BSCP|CS|61|101
// For Task 6.2P


using bankOrg;
using System;

namespace BankTransfer
{
    class DepositTransaction
    {
        private Account _account;
        private decimal _amount;
        private bool _executed;
        private bool _success;
        private bool _reversed;

        public bool Executed
        {
            get { return _executed; }
        }

        public bool Success
        {
            get { return _success; }
        }

        public bool Reversed
        {
            get { return _reversed; }
        }

        public DepositTransaction(Account account, decimal amount)
        {
            this._account = account;
            this._amount = amount;
        }

        public void Print()
        {
            Console.WriteLine($"Deposit of {this._amount} to account {this._account.Name}");
            if (this.Success == true)
            {
                Console.WriteLine($"Deposit successful.");
            }
            else
            {
                Console.WriteLine($"Deposit failed.");
            }
        }

        public void Execute()
        {
            if (_executed)
            {
                throw new InvalidOperationException("Transaction has already been executed.");
            }

            if (_account.Deposit(_amount))
            {
                _success = true;
                _executed = true;
            }
            else
            {
                _success = false;
                _executed = true;
                throw new InvalidOperationException("Invalid deposit amount.");
            }
        }

        public void Rollback()
        {
            if (_reversed)
            {
                throw new InvalidOperationException("Transaction has already been reversed.");
            }

            if (_executed && _success)
            {
                _account.Withdraw(_amount);
                _reversed = true;
            }
            else
            {
                throw new InvalidOperationException("Cannot reverse transaction that was not successful.");
            }
        }
    }
}
