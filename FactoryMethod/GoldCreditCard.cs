using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class GoldCreditCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Gold Credit Card";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
    }
}
