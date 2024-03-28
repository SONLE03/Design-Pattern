using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Sword : Weapon
    {
        private Enchantment enchantment;
        public Sword(Enchantment enchantment)
        {
            this.enchantment = enchantment;
        }
        public void wield()
        {
            Console.WriteLine("The sword is wielded.");
            enchantment.onActivate();
        }
        public void swing()
        {
            Console.WriteLine("The sword is swung.");
            enchantment.apply();
        }
        public void unwield()
        {
            Console.WriteLine("The sword is unwielded.");
            enchantment.onDeactivate();
        }
        public Enchantment getEnchantment()
        {
            return enchantment;
        }
    }
}
