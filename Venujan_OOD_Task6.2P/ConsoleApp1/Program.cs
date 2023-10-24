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
                Console.WriteLine("5. Quit");



                userChoiceInt = Convert.ToInt32(Console.ReadLine());

                if (0 <= userChoiceInt && userChoiceInt<= 5)
                {
                    break;
                }
                               
                Console.WriteLine("Invalid option. Please choose a valid option (0-4).");
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

        static void DoWithdraw(Account account)
        {
            Console.Write("Enter the amount to withdraw: ");
            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());

            WithdrawTransaction withdrawTransaction = new WithdrawTransaction(account, withdrawAmount);

            try
            {
                withdrawTransaction.Execute();
                withdrawTransaction.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        /*
        static void DoWithdraw(Account account)
        {
            Console.Write("Enter the amount to withdraw: ");
            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());

            // Create a new WithdrawTransaction object
            WithdrawTransaction withdrawTransaction = new WithdrawTransaction(account, withdrawAmount);

            // Execute the transaction
            withdrawTransaction.Execute();

            // Print the transaction details
            withdrawTransaction.Print();
        }
        */



        /*
        static void DoDeposit(Account account)
        {
            Console.Write("Enter the amount to deposit: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

            // Create a new DepositTransaction object
            DepositTransaction depositTransaction = new DepositTransaction(account, depositAmount);

            // Execute the transaction
            depositTransaction.Execute();

            // Print the transaction details
            depositTransaction.Print();
        }
        */

        static void DoDeposit(Account account)
        {
            Console.Write("Enter the amount to deposit: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

            DepositTransaction depositTransaction = new DepositTransaction(account, depositAmount);

            try
            {
                depositTransaction.Execute();
                depositTransaction.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }





        /*
        static void DoTransfer(Account fromAccount, Account toAccount)
        {
            Console.Write($"Enter the amount to transfer from {fromAccount.Name}'s account to {toAccount.Name}'s account: ");
            decimal transferAmount = Convert.ToDecimal(Console.ReadLine());

            TransferTransaction transferTransaction = new TransferTransaction(fromAccount, toAccount, transferAmount);

            try
            {
                transferTransaction.Execute();
                transferTransaction.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        */

        static void DoTransfer(Account fromAccount, Account toAccount)
        {
            Console.Write($"Enter the amount to transfer from {fromAccount.Name}'s account to {toAccount.Name}'s account: ");
            decimal transferAmount = Convert.ToDecimal(Console.ReadLine());

            TransferTransaction transferTransaction = new TransferTransaction(fromAccount, toAccount, transferAmount);

            try
            {
                transferTransaction.Execute();
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

            /*
            Console.Write("Enter the name for the second account: ");
            string name2 = Console.ReadLine();

            Console.Write("Enter the initial balance for the second account: ");
            decimal balance2 = Convert.ToDecimal(Console.ReadLine());

            
            Account account2 = new Account(balance2, name2);

            
            account2.Print();
            Console.WriteLine();
            */


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
                            DoWithdraw(withdrawAccount);
                        }
                        break;
                    case MenuOption.Deposit:
                        Account depositAccount = FindAccount(bank);
                        if (depositAccount != null)
                        {
                            DoDeposit(depositAccount);
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
                                DoTransfer(fromAccount, toAccount);
                            }
                        }
                        break;
                    case MenuOption.AddNewAccount:
                        AddNewAccount(bank);
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option (0-5).");
                        break;
                }
            } while (userChoice != MenuOption.Quit);
        }



    }
}

