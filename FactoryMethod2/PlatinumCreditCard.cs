using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class PlatinumCreditCard : ICreditCard
    {
        public string GetCardType()
        {
            return "PlatinumCreditCard Credit Card";
        }
        public int GetCreditLimit()
        {
            return 30000;
        }
    }
}
