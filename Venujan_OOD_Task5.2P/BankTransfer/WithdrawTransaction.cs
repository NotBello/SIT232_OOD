using bank;

namespace BankTransfer
{
       
    class WithdrawTransaction
    {
        // Declare variables
        private Account _account;
        private decimal _amount;
        private bool _executed;
        private bool _success;
        private bool _reversed;

        // Properties
        public bool Executed
        {
            get { return _executed; }
        }

        public bool Success
        {
            get { return _success; }
        }

        public bool Reversed
        {
            get { return _reversed; }
        }

        // Constructor
        public WithdrawTransaction(Account account, decimal amount)
        {
            this._account = account;
            this._amount = amount;
        }

        // Methods
        public void Print()
        {
            Console.WriteLine($"Withdrawal of {this._amount} from account {this._account.Name}");
            if (this.Success == true)
            {
                Console.WriteLine($"Withdrawal successful.");
            }
            else
            {
                Console.WriteLine($"Withdrawal failed.");
            }
        }

        public void Execute()
        {
            if (_executed)
            {
                throw new InvalidOperationException("Transaction has already been executed.");
            }

            if (_account.Withdraw(_amount))
            {
                _success = true;
                _executed = true;
            }
            else
            {
                _success = false;
                _executed = true;
                throw new InvalidOperationException("Insufficient funds.");
            }
        }

        public void Rollback()
        {
            if (_reversed)
            {
                throw new InvalidOperationException("Transaction has already been reversed.");
            }

            if (_executed && _success)
            {
                _account.Deposit(_amount);
                _reversed = true;
            }
            else
            {
                throw new InvalidOperationException("Cannot reverse transaction that was not successful.");
            }
        }
    }

}