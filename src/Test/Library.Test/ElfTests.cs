using NUnit.Framework;
using Library;

namespace Library.Test
{
    public class ElfTests
    {
        private Elf elf1;
        private Elf elf2;
        private Bow elfSbow;
        private Shield elfsShield;

        [SetUp]
        public void Setup()
        {
        this.elfSbow = new Bow("Arco de Bronce", 10, 0);
        this.elfsShield = new Shield("Escudo redondo", 0, 10);
        this.elf1 = new Elf("Legolas", 100, elfSbow, elfsShield, 20, 15, 50);
        this.elf2 = new Elf("Arwen", 50, elfSbow, elfsShield, 10, 20, 500);
        }

        [Test]
        public void TestRemoveBow()
        {
            elf1.RemoveBow();
            Assert.IsNull(elf1.Weapon);
        }
        [Test]
        public void TestRemoveShield() //Probamos que el método RemoveShield funcione correctamente
        {
            elf1.RemoveShield();
            Assert.IsNull(elf1.Armor);
        }
        [Test]
        public void TestChangeBow()
        {
            Bow bow2 = new Bow("Arco de prueba", 20, 5);
            elf1.ChangeBow(bow2);
            Assert.AreEqual("Arco de prueba", elf1.Weapon.GetName());
        }
        [Test]
        public void TestChangeShield()
        {
            Shield shield2 = new Shield("Escudo de prueba", 2, 50);
            elf1.ChangeShield(shield2);
            Assert.AreEqual("Escudo de prueba", elf1.Armor.GetName());
        }
        [Test]
        public void TestGetHP()
        {
            Assert.AreEqual(100, elf1.GetHP());
        }
        [Test]
        public void TestSetHP()
        {
            elf1.SetHP(200);
            Assert.AreEqual(200, elf1.GetHP());
        }
        [Test]
        public void TestGetDefense()
        {
            Assert.AreEqual(25, elf1.GetDefense());
        }
        [Test]
        public void TestAttackElf()
        {
            elf2.AttackElf(elf1);
            Assert.AreEqual(105, elf1.GetHP());
        }
        [Test]
        public void TestHealElf()
        {
            elf2.HealElf(elf1);
            Assert.AreEqual(600, elf1.GetHP());
        }

    }


}