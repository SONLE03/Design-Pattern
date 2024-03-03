using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public abstract class CreditCardFactory
    {
        public abstract ICreditCard createCreditCard();

        public string SomeOperation()
        {
            var creditCard = createCreditCard();
            var result = $"Credit card type: { creditCard.Operation() }";
            return result;
        }

    }
}
