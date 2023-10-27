// Created by Venujan Malaiyandi
// BSCP|CS|61|101
// For Task 7.1P

using bankOrg;

namespace BankTransfer
{
    class WithdrawTransaction : Transaction
    {
        private Account _account;
        //private bool _executed;
        //private bool _success;
        //private bool _reversed;

        public override bool Success
        {
            get { return _success; }
        }

        public WithdrawTransaction(Account account, decimal amount) : base(amount)
        {
            _account = account;
        }

        public override void Print()
        {
            Console.WriteLine($"Withdrawal of {_amount} from account {_account.Name}");
            if (_success)
            {
                Console.WriteLine($"Withdrawal successful.");
            }
            else
            {
                Console.WriteLine($"Withdrawal failed.");
            }
        }

        /*
        public override void Execute()
        {
            //base.Execute();

            if (!_executed)
            {
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
        }*/

        public override void Execute()
        {
            try
            {
                if (!Executed)
                {
                    base.Execute();
                    if (_account.Withdraw(_amount))
                    {
                        _success = true;


                    }
                    else
                    {
                        _success = false;


                        throw new InvalidOperationException("Insufficient funds.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex; 
            }
            
        }

        public override void Rollback()
        {
            

            if (Executed && Success && !Reversed)
            {
                _account.Deposit(_amount);
                base.Rollback();

            }
            else
            {
                throw new InvalidOperationException("Cannot reverse transaction that was not successful.");
            }
        }
    }
}
