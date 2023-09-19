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
            Account bello = new Account(24000.99, "Venujan");
            bello.Print();

            
            MenuOption userChoice;
            do
            {
                userChoice = ReadUserOption();
                
                switch (userChoice)
                {
                    case MenuOption.Withdraw:
                        Console.Write("Enter the amount to withdraw: ");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        bool withdrawResult = bello.Withdraw(withdrawAmount);
                        string withdrawResultString = (withdrawResult) ? "successful." : "unsuccessful."; //if else shorthand
                        Console.WriteLine("The transaction is " + withdrawResultString);
                        break;
                    case MenuOption.Deposit:
                        Console.Write("Enter the amount to deposit: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        bool depositResult = bello.Deposit(depositAmount);
                        string depositResultString = (depositResult) ? "successful." : "unsuccessful.";//if else shorthand
                        Console.WriteLine("The transaction is " + depositResultString);
                        break;
                    case MenuOption.Print:
                        bello.Print();
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Goodbye!");
                        break;
                }
            } while (userChoice != MenuOption.Quit);
            

        }


    }
}

