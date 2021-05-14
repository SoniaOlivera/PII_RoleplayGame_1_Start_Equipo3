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
        public Bow Weapon {get; set;}
        private Shield armor;
        public Shield Armor {get; set;}
        private int baseAttackPower;
        private int baseDefensePower;
        private int baseHealingPower;
        public Elf (String name, int hP, Bow weapon, Shield armor, int baseAttackPower, int baseDefensePower, int baseHealingPower)
        {
            this.Name = name;
            this.HP = hP;
            this.Weapon = weapon;
            this.Armor = armor;
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
            if (hp >= 0)
            {
                this.HP = hp;
            }
            else
            {
                this.HP = 0;
            }
            
        }   
        public void RemoveBow()
        {
            this.Weapon = null;
        }  
        public void ChangeBow(Bow newbow)
        {
            this.RemoveBow();
            this.Weapon = newbow;
        }
        public void RemoveShield()
        {
            this.Armor = null;
        }
        public void ChangeShield(Shield newshield)
        {
            this.RemoveShield();
            this.Armor = newshield;
        }
        public void AttackDwarf(Dwarf target)
        {
            if ((target.GetDefense() - this.baseAttackPower -this.Armor.GetDamage() - this.Weapon.GetDamage()) < 0 && target.GetHP() > 0)
            {
                target.SetHP(target.GetHP() + target.GetDefense() - this.baseAttackPower -this.Armor.GetDamage() - this.Weapon.GetDamage());
            }
        }
        public void AttackElf(Elf target)
        {
           if ((target.GetDefense() - this.baseAttackPower -this.Armor.GetDamage() - this.Weapon.GetDamage()) < 0 && target.GetHP() > 0)
            {
                target.SetHP(target.GetHP() + target.GetDefense() - this.baseAttackPower -this.Armor.GetDamage() - this.Weapon.GetDamage());
            }
        }
        public void AttackWizard(Wizard target)
        {
           if ((target.GetDefense() - this.baseAttackPower -this.Armor.GetDamage() - this.Weapon.GetDamage()) < 0 && target.GetHP() > 0)
            {
                target.SetHP(target.GetHP() + target.GetDefense() - this.baseAttackPower -this.Armor.GetDamage() - this.Weapon.GetDamage());
            }
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
            return (this.baseDefensePower + this.Weapon.GetArmor() + this.Armor.GetArmor());
        }
    }
}