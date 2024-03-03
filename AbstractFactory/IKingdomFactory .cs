using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IKingdomFactory
    {
        ICastle createCastle();
        IKing createKing();
        IArmy createArmy();
    }
}
