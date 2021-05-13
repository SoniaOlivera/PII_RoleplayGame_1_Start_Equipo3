using System;

namespace Library
{
    public class Spell
    {
        private string name;
        private int damage;
        private int armor;
        private int healingPower;
        public string Name {get;}
        public int Damage {get;}
        public int Armor {get;}
        public int HealingPower {get;}


        public Spell (string name, int damage, int armor, int healingPower)
        {
            this.Name = name;
            this.Damage = damage;
            this.Armor = armor;
            this.HealingPower = healingPower;
        }

        public int GetDamage()
        {
            return Damage;
        }
        public int GetArmor()
        {
            return Armor;
        }
        public int GetHealingPower()
        {
            return HealingPower;
        }
        public string GetName()
        {
            return Name;
        }
    }
}