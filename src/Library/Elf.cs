using System;

namespace Library
{
    public class Elf
    {
        private string name;
        public string Name;
        private int hP;
        public int HP;
        private Bow weapon;
        private Shield armor;
        private int baseAttackPower;
        private int baseDefensePower;
        private int baseHealingPower;
        public Elf (String name, int hP, Bow weapon, Shield armor, int baseAttackPower, int baseDefensePower, int baseHealingPower)
        {
            this.Name = name;
            this.HP = hP;
            this.weapon = weapon;
            this.armor = armor;
            this.baseAttackPower = baseAttackPower;
            this.baseDefensePower = baseDefensePower;
            this.baseHealingPower = baseHealingPower;
        }
        public int GetHP()
            {
                return this.HP;
            }
        public void SetHP(int hp)
        {
            this.HP = hp;
        }   
        public void RemoveBow()
        {
            this.weapon = null;
        }  
        public void ChangeBow(Bow newbow)
        {
            this.RemoveBow();
            this.weapon = newbow;
        }
        public void RemoveShield()
        {
            this.armor = null;
        }
        public void ChangeShield(Shield newshield)
        {
            this.RemoveShield();
            this.weapon = newshield;
        }
        public void AttackDwarf(Dwarf target)
        {
            target.SetHP(target.GetHP() + target.GetDefense() - this.baseAttackPower - this.weapon.GetDamage());
        }
        public void AttackElf(Elf target)
        {
            target.SetHP(target.GetHP() + target.GetDefense() - this.baseAttackPower - this.weapon.GetDamage());
        }
        public void AttackWizard(Wizard target)
        {
            target.SetHP(target.GetHP() + target.GetDefense() - this.baseAttackPower -this.armor.GetDamage() - this.weapon.GetDamage());
        }
        public void HealDwarf(Dwarf target)
        {
            target.SetHP(target.GetHP() + this.baseHealingPower);
        }
        public void HealElf(Elf target)
        {
            target.SetHP(target.GetHP() + this.baseHealingPower);
        }
        public void HealWizard(Wizard target)
        {
            target.SetHP(target.GetHP() + this.baseHealingPower);
        }
        public int GetDefense()
        {
            return (this.baseDefensePower + this.weapon.GetArmor() + this.armor.GetArmor());
        }
    }
}