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
        public void SetHP(int HP)
        {
            this.HP = HP;
        }    
        private void RemoveStaff()
        {
            this.weapon = null;
        }
        public void ChangeStaff(Staff newstaff)
        {
            this.RemoveStaff();
            this.weapon = newstaff;
        }
        public void RemoveRobe()
        {
            this.armor = null;
        }
        public void ChangeRobe(Robe newrobe)
        {
            this.RemoveRobe();
            this.armor = newrobe;
        }
         public int GetDefense()
        {
            return (this.baseDefensePower + this.weapon.GetArmor() + this.armor.GetArmor());
        }
        public void HealWizard(Wizard target)
        {
            target.SetHP(target.GetHP() + this.baseHealingPower);
        }
        public void HealElf(Elf target)
        {
            target.SetHP(target.GetHP() + this.baseHealingPower);
        }
        public void HealDwarf(Dwarf target)
        {
            target.SetHP(target.GetHP() + this.baseHealingPower);
        }
        public void AttackElf(Elf target)
        {
            target.SetHP(target.GetHP() + target.GetDefense() - this.baseAttackPower - this.weapon.GetDamage());
        }
        public void AttackDwarf(Dwarf target)
        {
            target.SetHP(target.GetHP() + target.GetDefense() - this.baseAttackPower - this.weapon.GetDamage());
        }
        public void AttackWizard(Wizard target)
        {
            target.SetHP(target.GetHP() + target.GetDefense() - this.baseAttackPower -this.armor.GetDamage() - this.weapon.GetDamage());
        }
    }
}