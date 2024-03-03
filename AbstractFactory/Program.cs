using System.Net.NetworkInformation;

namespace AbstractFactory
{
    public class Program
    {
        private static readonly Kingdom kingdom = new Kingdom();
        static void Main(string[] args)
        {
            Console.WriteLine("elf kingdom");
            CreateKingdom(Kingdom.FactoryMaker.KingdomType.ELF);
            Console.WriteLine(kingdom.king.getDescription());
            Console.WriteLine(kingdom.castle.getDescription());
            Console.WriteLine(kingdom.army.getDescription());

            Console.WriteLine("orc kingdom");
            CreateKingdom(Kingdom.FactoryMaker.KingdomType.ORC);
            Console.WriteLine(kingdom.king.getDescription());
            Console.WriteLine(kingdom.castle.getDescription());
            Console.WriteLine(kingdom.army.getDescription());
        }
        public static void CreateKingdom(Kingdom.FactoryMaker.KingdomType kingdomType)
        {
            var kingdomFactory = Kingdom.FactoryMaker.makeFactory(kingdomType);
            kingdom.king = kingdomFactory.createKing();
            kingdom.castle = kingdomFactory.createCastle();
            kingdom.army = kingdomFactory.createArmy();
        }
    }
}