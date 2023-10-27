// Created by Venujan Malaiyandi
// BSCP|CS|61|101
// For Task 7.1P

using System;
using BankTransfer;

namespace bankOrg
{

    enum MenuOption
    {
        Withdraw,
        Deposit,
        Transfer,
        Print,
        AddNewAccount,
        PrintTranscationHistory,
        Rollback,
        Quit
    }

    class BankSystem
    {

        static MenuOption ReadUserOption()
        {
            int userChoiceInt;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("0. Withdraw");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Bank Transfer");
                Console.WriteLine("3. Print");
                Console.WriteLine("4. Add new account");
                Console.WriteLine("5. Print Transaction History");
                Console.WriteLine("6. Rollback");
                Console.WriteLine("7. Quit");

                userChoiceInt = Convert.ToInt32(Console.ReadLine());

                if (0 <= userChoiceInt && userChoiceInt <= 7)
                {
                    break;
                }

                Console.WriteLine("Invalid option. Please choose a valid option (0-6).");
            } while (true);

            MenuOption userChoice = (MenuOption)userChoiceInt;

            return userChoice;
        }

        private static Account FindAccount(Bank bank)
        {
            Console.Write("Enter the name of the account: ");
            string name = Console.ReadLine();

            Account account = bank.GetAccount(name);

            if (account == null)
            {
                Console.WriteLine($"Account '{name}' not found.");
            }

            return account;
        }

        static void AddNewAccount(Bank bank)
        {
            Console.Write("Enter the name for the new account: ");
            string name = Console.ReadLine();

            Console.Write("Enter the initial balance for the new account: ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());

            Account newAccount = new Account(balance, name);
            bank.AddAccount(newAccount);

            Console.WriteLine($"Account '{name}' with an initial balance of {balance} has been added to the bank.");
        }

        static void DoWithdraw(Bank bank, Account account)
        {
            Console.Write("Enter the amount to withdraw: ");
            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());

            WithdrawTransaction withdrawTransaction = new WithdrawTransaction(account, withdrawAmount);
            
            //withdrawTransaction.Execute();
            bank.ExecuteTransaction(withdrawTransaction); 
            withdrawTransaction.Print();
            Console.WriteLine("Withdraw finished");
            
        }

        static void DoDeposit(Bank bank, Account account)
        {
            Console.Write("Enter the amount to deposit: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

            DepositTransaction depositTransaction = new DepositTransaction(account, depositAmount);

            
            
           
            bank.ExecuteTransaction(depositTransaction);
            depositTransaction.Print();
                       
        }

        static void DoTransfer(Bank bank, Account fromAccount, Account toAccount)
        {
            Console.Write($"Enter the amount to transfer from {fromAccount.Name}'s account to {toAccount.Name}'s account: ");
            decimal transferAmount = Convert.ToDecimal(Console.ReadLine());

            TransferTransaction transferTransaction = new TransferTransaction(fromAccount, toAccount, transferAmount);

            try
            {
                
                bank.ExecuteTransaction(transferTransaction);
                transferTransaction.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void DoPrint(Account account)
        {
            account.Print();
        }

        static void DoPrintTranscationHistory(Bank bank)
        {
            bank.PrintTransactionHistory();
        }

        static void DoRollback(Bank bank)
        {
            Console.Write("Enter the transaction number to rollback: ");
            int transactionNumber = Convert.ToInt32(Console.ReadLine());

            try
            {
                bank.RollbackTransaction(transactionNumber);
                Console.WriteLine("Transaction rolled back successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }



        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Console.Write("Enter the name for the first account: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter the initial balance for the first account: ");
            decimal balance1 = Convert.ToDecimal(Console.ReadLine());

            Account account1 = new Account(balance1, name1);

            bank.AddAccount(account1);

            Console.WriteLine("\nInitial Account Details:");
            account1.Print();

            MenuOption userChoice;
            do
            {
                
                userChoice = ReadUserOption();

                switch (userChoice)
                {
                    case MenuOption.Withdraw:
                        Account withdrawAccount = FindAccount(bank);
                        if (withdrawAccount != null)
                        {
                            DoWithdraw(bank, withdrawAccount);
                        }
                        break;
                    case MenuOption.Deposit:
                        Account depositAccount = FindAccount(bank);
                        if (depositAccount != null)
                        {
                            DoDeposit(bank, depositAccount);
                        }
                        break;
                    case MenuOption.Print:
                        Account printAccount = FindAccount(bank);
                        if (printAccount != null)
                        {
                            DoPrint(printAccount);
                        }
                        break;
                    case MenuOption.Transfer:
                        Account fromAccount = FindAccount(bank);
                        if (fromAccount != null)
                        {
                            Account toAccount = FindAccount(bank);
                            if (toAccount != null)
                            {
                                DoTransfer(bank, fromAccount, toAccount);
                            }
                        }
                        break;
                    case MenuOption.AddNewAccount:
                        AddNewAccount(bank);
                        break;
                    case MenuOption.PrintTranscationHistory:
                        DoPrintTranscationHistory(bank);
                        break;
                    case MenuOption.Rollback:
                        DoRollback(bank);
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option (0-7).");
                        break;
                }
            } while (userChoice != MenuOption.Quit);

            
        }
    }
}
