using System;

namespace bank
{

    enum MenuOption
    {
        Withdraw,
        Deposit,
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
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Print");
                Console.WriteLine("4. Quit");



                userChoiceInt = Convert.ToInt32(Console.ReadLine());

                if (0 <= userChoiceInt && userChoiceInt<= 3)
                {
                    break;
                }

                /*
                // Try to parse the userChoice into an enum value of MenuOption.
                // Additionally check whether the value represented by userChoice is defined in the MenuOption enum.
                if (Enum.TryParse(Console.ReadLine(), out userChoice) && Enum.IsDefined(typeof(MenuOption), userChoice))
                {
                    break;
                }
                */
                Console.WriteLine("Invalid option. Please choose a valid option (0-3).");
            } while (true);

            MenuOption userChoice = (MenuOption)userChoiceInt;
            
            return userChoice;
            

           

        }

        static void DoWithdraw(Account account)
        {
            Console.Write("Enter the amount to withdraw: ");
            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
            bool withdrawResult = account.Withdraw(withdrawAmount);
            string withdrawResultString = (withdrawResult) ? "successful." : "unsuccessful."; //if else shorthand
            Console.WriteLine("The transaction is " + withdrawResultString);
        }

        static void DoDeposit(Account account)
        {
            Console.Write("Enter the amount to deposit: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            bool depositResult = account.Deposit(depositAmount);
            string depositResultString = (depositResult) ? "successful." : "unsuccessful.";//if else shorthand
            Console.WriteLine("The transaction is " + depositResultString);
        }

        static void DoPrint(Account account)
        {
            account.Print();
        }

        static void Main(string[] args)
        {
            /*
            // 1st question
            Account bello = new Account(24000.99, "Venujan");
            bello.Print();
            Console.WriteLine("Withdrawing 10,000");
            Console.WriteLine("The transaction is " + bello.Withdraw(10000));
            bello.Print();
            Console.WriteLine("Deposit 10,000");
            Console.WriteLine("The transaction is " + bello.Deposit(10000));
            bello.Print();
            */

            Console.WriteLine("");

            // 2nd question
            Account bello = new Account(24000.99m, "Venujan");
            bello.Print();

            
            MenuOption userChoice;
            do
            {
                userChoice = ReadUserOption();
                
                switch (userChoice)
                {
                    case MenuOption.Withdraw:
                        DoWithdraw(bello);
                        break;
                    case MenuOption.Deposit:
                        DoDeposit(bello);
                        break;
                    case MenuOption.Print:
                        DoPrint(bello);
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Goodbye!");
                        break;
                }
            } while (userChoice != MenuOption.Quit);
            

        }


    }
}

