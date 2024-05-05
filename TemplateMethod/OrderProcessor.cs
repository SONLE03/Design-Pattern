using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class OrderProcessor
    {
        // The template method
        public void ProcessOrder()
        {
            ValidatePayment();
            DeductPayment();
            CheckStock();
            PackageProduct();
            Ship();
        }
        public void ValidatePayment()
        {
            Console.WriteLine("Validating payment details.");
        }
        public void DeductPayment()
        {
            Console.WriteLine("Deducting payment.");
        }
        public void CheckStock()
        {
            Console.WriteLine("Checking stock availability.");
        }
        // Abstract methods for steps that might vary across subclasses
        protected abstract void PackageProduct();
        protected abstract void Ship();
    }
}
