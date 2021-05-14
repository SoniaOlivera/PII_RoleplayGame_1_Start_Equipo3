using System;
/*La clase Spell es la que debe conocer su nombre, poder de ataque, defensa y cura por lo tanto cumple expert. Por otro lado cumple SRP ya que su unico motivo de cambio seria que cambie la forma en que se compone un Spell*/
namespace Library
{
    public class Spell
    {
        private string name;
        private int damage;
        private int armor;
        private int healingPower;
        public string Name;
        public int Damage;
        public int Armor;
        public int HealingPower;


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