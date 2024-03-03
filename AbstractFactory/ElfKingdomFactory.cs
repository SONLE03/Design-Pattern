using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ElfKingdomFactory : IKingdomFactory
    {
        public ICastle createCastle()
        {
            return new ElfCastle();
        }

        public IKing createKing()
        {
            return new ElfKing();
        }
        public IArmy createArmy()
        {
            return new ElfArmy();
        }
    }
}
