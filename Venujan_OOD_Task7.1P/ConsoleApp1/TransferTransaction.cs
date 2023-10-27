// Created by Venujan Malaiyandi
// BSCP|CS|61|101
// For Task 7.1P

using bankOrg;

namespace BankTransfer
{
    class TransferTransaction : Transaction
    {
        private Account _fromAccount;
        private Account _toAccount;
        private DepositTransaction _deposit;
        private WithdrawTransaction _withdraw;
        //private bool _executed;
        //private bool _success;
        //private bool _reversed;

        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount) : base(amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _withdraw = new WithdrawTransaction(fromAccount, amount);
            _deposit = new DepositTransaction(toAccount, amount);
        }

        public override bool Success
        {
            get { return _withdraw.Success && _deposit.Success; }
        }

        public override void Print()
        {
            Console.WriteLine($"Transferred ${_amount} from {_fromAccount.Name}'s account to {_toAccount.Name}'s account.");
            _deposit.Print();
            _withdraw.Print();
        }


        public override void Execute()
        {
            

            if (!Executed)
            {
                base.Execute();
                 

                try
                {
                    _withdraw.Execute();
                    _deposit.Execute();
                }
                catch (Exception)
                {
                    // If deposit fails, roll back withdraw
                    _withdraw.Rollback();
                    throw;
                }
            }
        }

        public override void Rollback()
        {
            
            if (!base.Reversed)
            {
                _withdraw.Rollback();
                _deposit.Rollback();
                base.Rollback();
            }
            else
            {
                throw new InvalidOperationException("Transaction has already been reversed.");
            }
        }
    }
}
