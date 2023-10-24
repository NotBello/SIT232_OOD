// Created by Venujan Malaiyandi
// BSCP|CS|61|101
// For Task 6.2P


using System;
using System.Collections.Generic;
using bankOrg;
using BankTransfer;

namespace bankOrg
{
    class Bank
    {
        private List<Account> _accounts;

        public Bank()
        {
            _accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        public Account GetAccount(string name)
        {
            foreach (Account account in _accounts)
            {
                if (account.Name == name)
                {
                    return account;
                }
            }
            return null;
        }

        public void ExecuteTransaction(DepositTransaction transaction)
        {
            transaction.Execute();
        }

        public void ExecuteTransaction(WithdrawTransaction transaction)
        {
            transaction.Execute();
        }

        public void ExecuteTransaction(TransferTransaction transaction)
        {
            transaction.Execute();
        }
    }
}
