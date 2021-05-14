using NUnit.Framework;
using Library;

namespace Library.Test
{
    public class DwarfTests
    {
        //Crear los datos de prueba
        private Dwarf dwarf1;
        private Dwarf dwarf2;
        private Axe dwarfAxe;
        private Chestplate dwarfChestplate;

        [SetUp]
        public void Setup()
        {
        this.dwarfAxe = new Axe("Dorada", 10, 0);
        this.dwarfChestplate = new Chestplate("Malla Plata", 0, 10);
        this.dwarf1 = new Dwarf("Kili", 100, dwarfAxe, dwarfChestplate, 20, 15, 50);
        this.dwarf2 = new Dwarf("Thorin", 50, dwarfAxe, dwarfChestplate, 10, 20, 500);
        }

        [Test]
        //Probamos que el método Remove para armas funcione correctamente
        public void TestRemoveAxe()
        {
            dwarf1.RemoveAxe();
            Assert.IsNull(dwarf1.Weapon);
        }
        [Test]
        public void TestRemoveChestplate() //Probamos que el método Remove funcione correctamente para la armadura
        {
            dwarf1.RemoveChestplate();
            Assert.IsNull(dwarf1.Armor);
        }
        [Test]
        public void TestChangeAxe()//Probamos crear un Acha nueva para cambiarla por la anterior
        {
            Axe axe2 = new Axe("Acha de prueba", 20, 5);
            dwarf1.ChangeAxe(axe2);
            Assert.AreEqual("Acha de prueba", dwarf1.Weapon.GetName());
        }
        [Test]
        public void TestChangeChestplate()//Probamos crear una nueva armadura para luego cambiarla
        {
            Chestplate chestplate2 = new Chestplate("Armadura de prueba", 2, 50);
            dwarf1.ChangeChestplate(chestplate2);
            Assert.AreEqual("Armadura de prueba", dwarf1.Armor.GetName());
        }
        [Test]
        public void TestGetHP()//Probamos que el método para consulta los HP funcione correctamente
        {
            Assert.AreEqual(100, dwarf1.GetHP());
        }
        [Test]
        public void TestSetHP()//Probamos que el método para cambiar los HP funcione correctamente
        {
            dwarf1.SetHP(200);
            Assert.AreEqual(200, dwarf1.GetHP());
        }
        [Test]
        public void TestGetDefense()//Probamos que el método para consulta la defensa funcione correctamente
        {
            Assert.AreEqual(25, dwarf1.GetDefense());
        }
        [Test]
        public void TestAttackDwarf()//Probamos que el método para atacar a otro enano funcione correctamente
        {
            dwarf2.AttackDwarf(dwarf1);
            Assert.AreEqual(105, dwarf1.GetHP());
        }
        [Test]
        public void TestHealDwarf()//Probamos que el método para curar otro enano este ok
        {
            dwarf2.HealDwarf(dwarf1);
            Assert.AreEqual(600, dwarf1.GetHP());
        }

    }


}