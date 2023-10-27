// Created by Venujan Malaiyandi
// BSCP|CS|61|101
// For Task 7.1P

using System;
using System.Collections.Generic;
using bankOrg;
using BankTransfer;

namespace bankOrg
{
    class Bank
    {
        private List<Account> _accounts;
        private List<Transaction> _transactions;

        public Bank()
        {
            _accounts = new List<Account>();
            _transactions = new List<Transaction>();
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

        public void ExecuteTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
            transaction.Execute();
        }

        
        public void RollbackTransaction(int transactionNumber)
        {
            if (transactionNumber >= 0 && transactionNumber < _transactions.Count)
            {
                Transaction transaction = _transactions[transactionNumber];
                transaction.Rollback();
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid transaction number.");
            }
        }


        public void PrintTransactionHistory()
        {
            for (int i = 0; i < _transactions.Count; i++)
            {
                Console.WriteLine($"{i}. {(_transactions[i].Success ? "Success" : "Failed")} | Last Operation Time: {_transactions[i].DateStamp}");
            }
        }




        public Transaction GetTransactionByNumber(int number)
        {
            if (number >= 0 && number < _transactions.Count)
            {
                return _transactions[number];
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid transaction number.");
            }
        }

    }
}

