namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mage = new HeroConcreteBuilder()
                 .SetProfessionName(Profession.MAGE, "Riobard")
                 .SetHairColor(HairColor.BLACK)
                 .SetWeapon(Weapon.DAGGER);
            Console.WriteLine(mage.Build().ToString());

            var warrior = new HeroConcreteBuilder()
                .SetProfessionName(Profession.WARRIOR, "Amberjill")
                .SetHairColor(HairColor.BLOND)
                .SetHairType(HairType.LONG_CURLY)
                .SetArmor(Armor.CHAIN_MAIL)
                .SetWeapon(Weapon.SWORD);
            Console.WriteLine(warrior.Build().ToString());

            var thief = new HeroConcreteBuilder()
                .SetProfessionName(Profession.THIEF, "Desmond")
                .SetHairType(HairType.BALD)
                .SetWeapon(Weapon.BOW);
            Console.WriteLine(thief.Build().ToString());
        }
    }
}