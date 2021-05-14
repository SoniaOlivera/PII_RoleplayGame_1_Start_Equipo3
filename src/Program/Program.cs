using System;
using System.Collections;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Axe DurinAxe = new Axe("Durin's Axe", 60, 5);
            Chestplate CitadelPlate = new Chestplate ("Citadel Plate", 0, 50);
            Dwarf Thorin = new Dwarf("Thorin Oakenshield", 150, DurinAxe, CitadelPlate, 10, 60, 15);
            Bow RivendellBow = new Bow("Rivendell Bow", 50, 0);
            Shield RoundShield = new Shield("Round Shield", 5, 50);
            Elf Legolas = new Elf("Legolas", 80, RivendellBow, RoundShield, 30, 20, 30);
            Staff RadagastStaff = new Staff("Radagast's Staff", 30, 50, 80);
            Robe BrownRobe = new Robe("BrownRobe", 5, 20, 30);
            Spell ForceOfNature = new Spell("Force of Nature", 0, 20, 60);
            Spell WindShield = new Spell("Wind Shield", 0, 60, 0);
            Spell Firestorm = new Spell("Firestorm", 120, 0, 0);
            ArrayList SpellList = new ArrayList();
            SpellBook RadagastBook = new SpellBook ("Radagast's SpellBook", SpellList);
            Wizard Radagast = new Wizard("Radagast the Brown", 100, RadagastStaff, BrownRobe, RadagastBook, 10, 10, 60);
        }
    }
}
