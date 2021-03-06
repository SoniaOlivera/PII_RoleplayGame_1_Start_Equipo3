using System;
using System.Collections;
using Library;

/*La clase SpellBook es la que debe conocer su nombre y lista de hechizos por lo tanto cumple expert. Por otro lado cumple SRP ya que su unico motivo de cambio seria que cambie la forma en que se compone un Axe*/

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
        public void AddSpell(Spell Spell)
        {
            SpellList.Add(Spell);
        }
        public void RemoveSpell(Spell Spell)
        {
            SpellList.Remove(Spell);
        }
        public int damagetotal = 0;
        public int GetDamage()
        {
            foreach (Spell Spell in this.SpellList)
            {
                damagetotal = damagetotal + Spell.GetDamage();
            }
            return damagetotal;
        }
        public int armortotal = 0;
        public int GetArmor()
        {
            foreach (Spell Spell in this.SpellList)
            {
                armortotal = armortotal + Spell.GetArmor();
            }
            return armortotal;
        }
        public int healingPowertotal = 0;
        public int GetHealingPower()
        {
            foreach (Spell Spell in this.SpellList)
            {
                healingPowertotal = healingPowertotal + Spell.GetHealingPower();
            }
            return healingPowertotal;
        }
    }
}