﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class PlatinumCreditCard : ICreditCard
    {
        public string Operation()
        {
            return "Platinum Credit Card";
        }
    }
}
