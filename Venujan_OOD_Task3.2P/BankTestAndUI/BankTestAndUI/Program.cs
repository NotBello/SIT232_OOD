using System;

namespace bank
{
    

    class BankSystem
    {
        static void Main(string[] args)
        {
            
            // 1st question
            Account bello = new Account(24000.99, "Venujan");
            bello.Print();
            Console.WriteLine("Withdrawing 10,000");
            Console.WriteLine("The transaction is " + bello.Withdraw(10000));
            bello.Print();
            Console.WriteLine("Deposit 10,000");
            Console.WriteLine("The transaction is " + bello.Deposit(10000));
            bello.Print();
            

            // 2nd question


        }
    }
}
