using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Checkout
    {
        private IPaymentStrategy _paymentMethod;
        public Checkout(IPaymentStrategy paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }
        public bool CompletePurchase(double amount)
        {
            return _paymentMethod.ProcessPayment(amount);
        }
    }
}
