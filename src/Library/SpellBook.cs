using System;
using System.Collections;
using Library;

namespace Library
{
    public class SpellBook
    {
        private string name;
        private ArrayList spellList;
        public string Name;
        public ArrayList SpellList;

        public SpellBook (string name, ArrayList spellList)
        {
            this.Name = name;
            this.SpellList = spellList;
        }
        //Es Necesario chequear esta solución con el equipo
        public void AddSpell(Spell)
        {
            SpellList.Add(Spell);
        }
        public void RemoveSpell(Spell)
        {
            SpellList.Remove(Spell);
        }
        public int damagetotal;
        public int GetDamage()
        {
            foreach (Spell spell in this.SpellList)
            {
                damagetotal = 0;
                damagetotal = damagetotal + Spell.GetDamage(Spell);
                return damagetotal;
            }
        }
        public int armortotal;
        public int GetArmor()
        {
            foreach (Spell spell in this.SpellList)
            {
                armortotal = 0;
                armortotal = armortotal + Spell.GetArmor(Spell);
                return armortotal;
            }
        }
        public int healingPowertotal;
        public int GetHealingPower()
        {
            foreach (Spell spell in this.SpellList)
            {
                healingPowertotal = 0;
                healingPowertotal = healingPowertotal + Spell.GetHealingPower(Spell);
                return healingPowertotal;
            }
        }
    }
}