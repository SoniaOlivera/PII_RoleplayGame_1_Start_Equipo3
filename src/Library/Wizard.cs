using System;

namespace Library
{
    public class Wizard
    {
        private string name;
        private int hP;
        private Staff weapon;
        private Robe armor;
        private SpellBook spellBook;
        private int baseAttackPower;
        private int baseDefensePower;
        private int baseHealingPower;
        public string Name;
        public int HP;
        public Staff Weapon;
        public Robe Armor;
        public SpellBook SpellBook;
        public int BaseAttackPower;
        public int BaseDefensePower;
        public int BaseHealingPower;
        public Wizard (String name, int hP, Staff weapon, Robe armor, SpellBook spellBook, int baseAttackPower, int baseDefensePower, int baseHealingPower)
        {
            this.Name = name;
            this.HP = hP;
            this.Weapon = weapon;
            this.Armor = armor;
            this.SpellBook = spellBook;
            this.BaseAttackPower = baseAttackPower;
            this.BaseDefensePower = baseDefensePower;
            this.BaseHealingPower = baseHealingPower;
        }
        public int GetHP()
            {
                return HP;
            }
        //Necesito chequear esto con el equipo
        public void SetHP(int HP)
        {
            this.HP = HP;
        }    
    }
}