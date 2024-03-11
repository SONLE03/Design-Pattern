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
            return new OrcCastle();
        }

        public IKing createKing()
        {
            return new OrcKing();
        }
        public IArmy createArmy()
        {
            return new OrcArmy();
        }
    }
}
