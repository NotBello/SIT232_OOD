using System;

namespace bank
{

    class Account
    {
        private double balance;
        private string name;
        private bool check;

        public string Name
        { 
            get { return name; } 
        }



        public Account(double balance, string name)
        {
            this.balance = balance;
            this.name = name;
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Withdraw(double amount)
        {
            this.balance -= amount;            
        }

        public void Print()
        {
            Console.WriteLine($"Hey {this.name}, your balance is {this.balance}");
        }


        public bool ValidateWithdraw(double checkvalue)
        {

            if (this.balance < checkvalue)
            {
                check = false;
            }
            else
            {
                check = true;
            }

            return check;
        }
    }

    class TestAccount
    {
        static void Main(string[] args)
        {
            string option;
            string inputcash;
            bool validate;
            double cash;

            Account bello = new Account(24000.99, "Venujan");
            bello.Print();
            Console.WriteLine("Withdrawing 10,000");
            bello.Withdraw(10000);
            bello.Print();
            Console.WriteLine("Deposit 10,000");
            bello.Deposit(10000);
            bello.Print();

        }
    }
            

}

