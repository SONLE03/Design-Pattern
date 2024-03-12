using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodv2
{
    public class GoldCard : ICard
    {
        CardType CardType { get;}

        public string ToString()
        {
            return "an elven" + CardType.GetType();
        }
    }
}
