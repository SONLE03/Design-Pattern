﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ElfKing : IKing
    {
        public string getDescription()
        {
            return "This is the elf king!";
        }
    }
}
