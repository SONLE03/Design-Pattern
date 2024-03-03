using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class OrcKingdomFactory : IKingdomFactory
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
