using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Hero
    {
        private Profession profession;
        private string name;
        private HairType hairType;
        private HairColor hairColor;
        private Armor armor;
        private Weapon weapon;

        public Hero(Profession profession, string name, HairType hairType, HairColor hairColor, Armor armor, Weapon weapon)
        {
            this.profession = profession;
            this.name = name;
            this.hairType = hairType;
            this.hairColor = hairColor;
            this.armor = armor;
            this.weapon = weapon;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("This is a ")
                .Append(profession)
                .Append(" named ")
                .Append(name);

            if (hairColor != null || hairType != null)
            {
                sb.Append(" with ");
                if (hairColor != null)
                {
                    sb.Append(hairColor).Append(' ');
                }
                if (hairType != null)
                {
                    sb.Append(hairType).Append(' ');
                }
                sb.Append(hairType != HairType.BALD ? "hair" : "head");
            }

            if (armor != null)
            {
                sb.Append(" wearing ").Append(armor);
            }

            if (weapon != null)
            {
                sb.Append(" and wielding a ").Append(weapon);
            }

            sb.Append('.');
            return sb.ToString();
        }
    }
}
