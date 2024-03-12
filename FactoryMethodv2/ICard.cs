using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodv2
{
    public interface ICard
    {
        CardType CardType { get; }
    }
}
