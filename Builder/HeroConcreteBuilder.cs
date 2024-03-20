using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HeroConcreteBuilder : HeroBuilder
    {
        private Profession profession;
        private string name;
        private HairType hairType;
        private HairColor hairColor;
        private Armor armor;
        private Weapon weapon;

        public HeroBuilder SetProfessionName(Profession profession, string name)
        {
            if (profession == null || name == null)
            {
                throw new Exception("profession and name can not be null");
            }
            this.profession = profession;
            this.name = name;
            return this;
        }
        public HeroBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }
        public HeroBuilder SetHairType(HairType hairType)
        {
            this.hairType = hairType;
            return this;
        }
        public HeroBuilder SetHairColor(HairColor hairColor)
        {
            this.hairColor = hairColor;
            return this;
        }
        public HeroBuilder SetArmor(Armor armor)
        {
            this.armor = armor;
            return this;
        }
        public HeroBuilder SetWeapon(Weapon weapon)
        {
            this.weapon = weapon;
            return this;
        }
        public Hero Build()
        {
            return new Hero(profession, name, hairType, hairColor, armor, weapon);
        }
    }
}
