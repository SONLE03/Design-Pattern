﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PayPalPayment : IPaymentStrategy
    {
        private string _email;
        public PayPalPayment(string email)
        {
            _email = email;
        }
        public bool ProcessPayment(double amount)
        {
            // Logic to process PayPal payment
            Console.WriteLine($"Processed payment of {amount} using PayPal");
            return true;
        }
    }

}
