using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Kingdom
    {
        public IKing king { get; set; }
        public ICastle castle { get; set; }
        public IArmy army { get; set; }

        public static class FactoryMaker
        {
            public enum KingdomType
            {
                ELF, ORC
            }
            public static IKingdomFactory makeFactory(KingdomType type) =>
                type switch
                {
                    KingdomType.ELF => new ElfKingdomFactory(),
                    KingdomType.ORC => new OrcKingdomFactory(),
                    _ => throw new ArgumentException("Invalid kingdom type"),
                };
        }
    }
}
