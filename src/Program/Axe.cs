using System;

namespace Library
{
    public class Axe
    {
        private string name;
        public string Name;
        private int damage;
        public int Damage;
        private int armor;       
        public int Armor;
        public Axe (string name, int damage, int armor)
        {
            this.Name = name;
            this.Damage = damage;
            this.Armor = armor;
        }

        public int GetDamage()
        {
            return this.Damage;
        }
        public int GetArmor()
        {
            return this.Armor;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
}