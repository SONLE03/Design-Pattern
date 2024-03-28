using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Hammer : Weapon
    {
        private Enchantment enchantment;
        public Hammer(Enchantment enchantment)
        {
            this.enchantment = enchantment;
        }
        public void wield()
        {
            Console.WriteLine("The hammer is wielded.");
            enchantment.onActivate();
        }
        public void swing()
        {
            Console.WriteLine("The hammer is swung.");
            enchantment.apply();
        }
        public void unwield()
        {
            Console.WriteLine("The hammer is unwielded.");
            enchantment.onDeactivate();
        }
        public Enchantment getEnchantment()
        {
            return enchantment;
        }
    }
}
