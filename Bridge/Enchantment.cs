using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface Enchantment
    {
        void onActivate();
        void apply();
        void onDeactivate();
    }

}
