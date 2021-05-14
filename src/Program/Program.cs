using System;
using System.Collections;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Axe DurinAxe = new Axe("Durin's Axe", 120, 5);
            Chestplate CitadelPlate = new Chestplate ("Citadel Plate", 0, 80);
            Dwarf Thorin = new Dwarf("Thorin Oakenshield", 150, DurinAxe, CitadelPlate, 10, 60, 15);
            Bow RivendellBow = new Bow("Rivendell Bow", 140, 0);
            Shield RoundShield = new Shield("Round Shield", 5, 65);
            Elf Legolas = new Elf("Legolas", 80, RivendellBow, RoundShield, 60, 20, 30);
            Staff RadagastStaff = new Staff("Radagast's Staff", 30, 50, 40);
            Robe BrownRobe = new Robe("BrownRobe", 0, 20, 60);
            Spell ForceOfNature = new Spell("Force of Nature", 0, 0, 20);
            Spell WindShield = new Spell("Wind Shield", 0, 60, 0);
            Spell Firestorm = new Spell("Firestorm", 120, 0, 0);
            ArrayList SpellList = new ArrayList();
            SpellBook RadagastBook = new SpellBook ("Radagast's SpellBook", SpellList);
            Wizard Radagast = new Wizard("Radagast the Brown", 100, RadagastStaff, BrownRobe, RadagastBook, 10, 10, 30);
            Console.WriteLine("Radagast está aprendiendo Force Of Nature");
            Radagast.LearnSpell(ForceOfNature);
            Console.WriteLine("Radagast aprendió Force Of Nature");
            Console.WriteLine("Radagast está aprendiendo WindShield");
            Radagast.LearnSpell(WindShield);
            Console.WriteLine("Radagast aprendió WindShield");
            Console.WriteLine("Radagast está aprendiendo Firestorm");
            Radagast.LearnSpell(Firestorm);
            Console.WriteLine("Radagast aprendió Firestorm");
            Console.WriteLine($"La vida de Legolas es {Legolas.GetHP()}");
            Console.WriteLine($"La vida de Thorin es {Thorin.GetHP()}");
            Legolas.AttackDwarf(Thorin);
            Console.WriteLine($"Legolas ataca a Thorin, la vida de Thorin ahora es {Thorin.GetHP()}");
            Thorin.AttackElf(Legolas);
            Console.WriteLine($"Thorin le devuelve el golpe a Legolas, la vida de Legolas ahora es {Legolas.GetHP()}");
            Radagast.HealDwarf(Thorin);
            Radagast.HealElf(Legolas);
            Console.WriteLine($"Radagast cura a Thorin, la vida de Thorin es {Thorin.GetHP()}");
            Console.WriteLine($"Radagast cura a Legolas, la vida de Legolas es {Legolas.GetHP()}");
        }
    }
}
