using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class DepositCommand : IBankCommand
    {
        private BankAccount _account;
        private decimal _amount;

        public DepositCommand(BankAccount account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }

        public void Execute()
        {
            _account.Deposit(_amount);
        }
    }

    public class WithdrawCommand : IBankCommand
    {
        private BankAccount _account;
        private decimal _amount;

        public WithdrawCommand(BankAccount account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }

        public void Execute()
        {
            _account.Withdraw(_amount);
        }
    }

    public class TransferCommand : IBankCommand
    {
        private BankAccount _fromAccount;
        private BankAccount _toAccount;
        private decimal _amount;

        public TransferCommand(BankAccount fromAccount, BankAccount toAccount, decimal amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;
        }

        public void Execute()
        {
            _fromAccount.Transfer(_toAccount, _amount);
        }
    }
}
