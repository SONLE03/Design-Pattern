﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class GoldCreditCardFactory : CreditCardFactory
    {
        public override ICreditCard createCreditCard()
        {
           return new GoldCreditCard();
        }
    }
}
