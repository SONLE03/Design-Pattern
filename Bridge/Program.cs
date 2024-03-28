namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The knight receives an enchanted sword.");
            var enchantedSword = new Sword(new SoulEatingEnchantment());
            enchantedSword.wield();
            enchantedSword.swing();
            enchantedSword.unwield();

            Console.WriteLine("\n**************************************\n");

            Console.WriteLine("The valkyrie receives an enchanted hammer.");
            var hammer = new Hammer(new FlyingEnchantment());
            hammer.wield();
            hammer.swing();
            hammer.unwield();
        }
    }
}