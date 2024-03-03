using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ElfKing : IKing
    {
        public String getDescription()
        {
            return "This is the elven king!";
        }
    }
}
