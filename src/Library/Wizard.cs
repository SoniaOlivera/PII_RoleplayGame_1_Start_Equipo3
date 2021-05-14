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
        public Staff Weapon {get;set;}
        public Robe Armor {get;set;}
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
        public void RemoveStaff()
        {
            this.Weapon = null;
        }
        public void ChangeStaff(Staff newstaff)
        {
            this.RemoveStaff();
            this.Weapon = newstaff;
        }
        public void RemoveRobe()
        {
            this.Armor = null;
        }
        public void ChangeRobe(Robe newrobe)
        {
            this.RemoveRobe();
            this.Armor = newrobe;
        }
        public int GetDefense()
        {
            return (this.BaseDefensePower + this.Weapon.GetArmor() + this.Armor.GetArmor() + this.SpellBook.GetArmor());
        }
        public void LearnSpell(Spell spell)
        {
            SpellBook.AddSpell(spell);
        }
        public void ForgetSpell(Spell spell)
        {
            SpellBook.RemoveSpell(spell);
        }
        public void HealWizard(Wizard target)
        {
            target.SetHP(target.GetHP() + this.BaseHealingPower + this.SpellBook.GetHealingPower() + this.Weapon.GetHealingPower() + this.Armor.GetHealingPower());
        }
        public void HealElf(Elf target)
        {
            target.SetHP(target.GetHP() + this.BaseHealingPower + this.SpellBook.GetHealingPower() + this.Weapon.GetHealingPower() + this.Armor.GetHealingPower());
        }
        public void HealDwarf(Dwarf target)
        {
            target.SetHP(target.GetHP() + this.BaseHealingPower + this.SpellBook.GetHealingPower() + this.Weapon.GetHealingPower() + this.Armor.GetHealingPower());
        }
        public void AttackElf(Elf target)
        {
            target.SetHP(target.GetHP() + target.GetDefense() - this.BaseAttackPower - this.Weapon.GetDamage() - this.SpellBook.GetDamage());
        }
        public void AttackDwarf(Dwarf target)
        {
            target.SetHP(target.GetHP() + target.GetDefense() - this.BaseAttackPower - this.Weapon.GetDamage() - this.SpellBook.GetDamage());
        }
        public void AttackWizard(Wizard target)
        {
            target.SetHP(target.GetHP() + target.GetDefense() - this.BaseAttackPower -this.Armor.GetDamage() - this.Weapon.GetDamage() - this.SpellBook.GetDamage());
        }
    }
}