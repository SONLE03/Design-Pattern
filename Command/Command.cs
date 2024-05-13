using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface IBankCommand
    {
        void Execute();
    }
    //Receiver - Bank Account
    public class BankAccount
    {
        public decimal Balance { get; private set; }
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
        }
        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
        public void Transfer(BankAccount toAccount, decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                toAccount.Deposit(amount);
                Console.WriteLine($"Transferred ${amount} to another account. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds for transfer.");
            }
        }
    }
}
