// Created by Venujan Malaiyandi
// BSCP|CS|61|101
// For Task 7.1P

using System;
using bankOrg;

namespace BankTransfer
{
    class DepositTransaction : Transaction
    {
        private Account _account;
        //private bool _executed;
        //private bool _success;
        //private bool _reversed;

        public override bool Success
        {
            get { return _success; }
        }

        public DepositTransaction(Account account, decimal amount) : base(amount)
        {
            _account = account;
        }

        public override void Print()
        {
            Console.WriteLine($"Deposit of {_amount} to account {_account.Name}");
            if (_success)
            {
                Console.WriteLine($"Deposit successful.");
            }
            else
            {
                Console.WriteLine($"Deposit failed.");
            }
        }

       
        public override void Execute()
        {
            

            if (!Executed)
            {
                base.Execute();
                if (_account.Deposit(_amount))
                {
                    _success = true;
                    
                }
                else
                {
                    _success = false;
                    
                    throw new InvalidOperationException("Invalid deposit amount.");
                }
            }
        }

        public override void Rollback()
        {
            base.Rollback();
            if (Executed && _success)
            {
                _account.Withdraw(_amount);
                
            }
            else
            {
                throw new InvalidOperationException("Cannot reverse transaction that was not successful.");
            }
        }
    }
}
