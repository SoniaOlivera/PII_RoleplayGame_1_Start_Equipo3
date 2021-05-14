using System;
/*La clase Bow es la que debe conocer su nombre, poder de ataque y defensa por lo tanto cumple expert. Por otro lado cumple SRP ya que su unico motivo de cambio seria que cambie la forma en que se compone un Bow*/

namespace Library
{
    public class Bow
    {
        private string name;
        public string Name;
        private int damage;
        public int Damage;
        private int armor;       
        public int Armor;
        public Bow (string name, int damage, int armor)
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