using bank;
using System;

namespace BankTransfer
{
    class TransferTransaction
    {
        private Account _fromAccount;
        private Account _toAccount;
        private decimal _amount;
        private DepositTransaction _deposit;
        private WithdrawTransaction _withdraw;

        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;
            _withdraw = new WithdrawTransaction(fromAccount, amount);
            _deposit = new DepositTransaction(toAccount, amount);
        }

        public void Print()
        {
            Console.WriteLine($"Transferred ${_amount} from {_fromAccount.Name}'s account to {_toAccount.Name}'s account.");
            _deposit.Print();
            _withdraw.Print();
        }

        public void Execute()
        {
            if (_withdraw.Executed || _deposit.Executed)
            {
                throw new InvalidOperationException("Transaction has already been executed.");
            }

            _withdraw.Execute();

            try
            {
                _deposit.Execute();
            }
            catch (Exception)
            {
                // If deposit fails, roll back withdraw
                _withdraw.Rollback();
                throw;
            }
        }

        public void Rollback()
        {
            if (_withdraw.Reversed || _deposit.Reversed)
            {
                throw new InvalidOperationException("Transaction has already been reversed.");
            }

            try
            {
                _withdraw.Rollback();
                _deposit.Rollback();
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Rollback failed.");
            }
        }
    }
}
