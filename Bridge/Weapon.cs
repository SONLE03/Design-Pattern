using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface Weapon
    {
        void wield();
        void swing();
        void unwield();
        Enchantment getEnchantment();
    }
}
