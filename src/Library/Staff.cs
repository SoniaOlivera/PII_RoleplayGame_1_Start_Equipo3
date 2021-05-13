using System;

namespace Library
{
    public class Staff
    {
        private string name;
        private int damage;
        private int armor;
        private int healingPower;
        public string Name;
        public int Damage;
        public int Armor;
        public int HealingPower;


        public Staff (string name, int damage, int armor, int healingPower)
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