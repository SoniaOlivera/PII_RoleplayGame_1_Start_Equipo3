using System;

namespace Library
{
    public class Dwarf
    {
        private string name;
        public string Name;
        private int hP;
        public int HP;
        private Axe weapon;
        public Axe Weapon {get; set;}
        private Chestplate armor;
        public Chestplate Armor {get; set;}
        private int baseAttackPower;
        private int baseDefensePower;
        private int baseHealingPower;
        public Dwarf (String name, int hP, Axe weapon, Chestplate armor, int baseAttackPower, int baseDefensePower, int baseHealingPower)
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
            this.HP = hp;
        }   
        public void RemoveAxe()
        {
            this.Weapon = null;
        }  
        public void ChangeAxe(Axe newaxe)
        {
            this.RemoveAxe();
            this.Weapon = newaxe;
        }
        public void RemoveChestplate()
        {
            this.Armor = null;
        }
        public void ChangeChestplate(Chestplate newchestplate)
        {
            this.RemoveChestplate();
            this.Armor = newchestplate;
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




    
