using System;

using BankTransfer;

namespace bank
{

    enum MenuOption
    {
        Withdraw,
        Deposit,
        Transfer,
        Print,
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
                Console.WriteLine("2. Transfer from Account 1 to Account 2");
                Console.WriteLine("3. Print");
                Console.WriteLine("4. Quit");



                userChoiceInt = Convert.ToInt32(Console.ReadLine());

                if (0 <= userChoiceInt && userChoiceInt<= 4)
                {
                    break;
                }
                               
                Console.WriteLine("Invalid option. Please choose a valid option (0-4).");
            } while (true);

            MenuOption userChoice = (MenuOption)userChoiceInt;
            
            return userChoice;
            

           

        }

       
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
            Console.Write("Enter the name for the first account: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter the initial balance for the first account: ");
            decimal balance1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the name for the second account: ");
            string name2 = Console.ReadLine();

            Console.Write("Enter the initial balance for the second account: ");
            decimal balance2 = Convert.ToDecimal(Console.ReadLine());

            Account account1 = new Account(balance1, name1);
            Account account2 = new Account(balance2, name2);

            Console.WriteLine("\nInitial Account Details:");
            account1.Print();
            account2.Print();
            Console.WriteLine();

            MenuOption userChoice;
            do
            {
                userChoice = ReadUserOption();

                switch (userChoice)
                {
                    case MenuOption.Withdraw:
                        DoWithdraw(account1);
                        break;
                    case MenuOption.Deposit:
                        DoDeposit(account1);
                        break;
                    case MenuOption.Print:
                        DoPrint(account1);
                        break;
                    case MenuOption.Transfer:
                        DoTransfer(account1, account2);
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Goodbye!");
                        break;
                }
            } while (userChoice != MenuOption.Quit);
        }



    }
}

