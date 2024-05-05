using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CryptoPayment : IPaymentStrategy
    {
        private string _cryptoWalletAddress;
        public CryptoPayment(string walletAddress)
        {
            _cryptoWalletAddress = walletAddress;
        }
        public bool ProcessPayment(double amount)
        {
            // Logic to process cryptocurrency payment
            Console.WriteLine($"Processed payment of {amount} using Cryptocurrency");
            return true;
        }
    }

}
