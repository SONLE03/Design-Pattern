using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface HeroBuilder
    {
        HeroBuilder SetProfessionName(Profession profession, string name);
        HeroBuilder SetHairType(HairType hairType);
        HeroBuilder SetHairColor(HairColor hairColor);
        HeroBuilder SetArmor(Armor armor);
        HeroBuilder SetWeapon(Weapon weapon);
        Hero Build();
    }
}
