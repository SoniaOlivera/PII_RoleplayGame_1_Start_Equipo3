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
        this.elf2 = new Elf("Arwen", 50, elfSbow, elfsShield, 20, 20, 500);
        }

        [Test]
        public void TestRemoveBow() //Probamos que el método RemoveBow funcione correctamente
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
        public void TestChangeBow() //Probamos que el método ChangeBow funcione correctamente
        {
            Bow bow2 = new Bow("Arco de prueba", 20, 5);
            elf1.ChangeBow(bow2);
            Assert.AreEqual("Arco de prueba", elf1.Weapon.GetName());
        }
        [Test]
        public void TestChangeShield() //Probamos que el método ChangeShield funcione correctamente
        {
            Shield shield2 = new Shield("Escudo de prueba", 2, 50);
            elf1.ChangeShield(shield2);
            Assert.AreEqual("Escudo de prueba", elf1.Armor.GetName());
        }
        [Test]
        public void TestGetHP() //Probamos que el método GetHP funcione correctamente
        {
            Assert.AreEqual(100, elf1.GetHP());
        }
        [Test]
        public void TestSetHP() //Probamos que el método SetHP funcione correctamente
        {
            elf1.SetHP(200);
            Assert.AreEqual(200, elf1.GetHP());
        }
        [Test]
        public void TestGetDefense() //Probamos que el método GetDefense funcione correctamente
        {
            Assert.AreEqual(25, elf1.GetDefense());
        }
        [Test]
        public void TestAttackElf() //Probamos que el método Attack funcione correctamente
        {
            elf2.AttackElf(elf1);
            Assert.AreEqual(95, elf1.GetHP());
        }

        [Test]
        /*En el caso de que el atacado tenga mayor defensa que el atacante tiene ataque
        Attack-Defense es negativo y un ataque podria aumentar el HP
        Implementamos logica en codigo para prevenirlo y Probamos que no sucede en este test
        */
        public void TestDontHealWhenDefenseIsHigherThanAttack()
        {
            elf1.ChangeShield(new Shield("Super Escudo", 0, 1000));
            elf2.AttackElf(elf1);
            Assert.AreEqual(100, elf1.GetHP());
        }

        [Test]
        public void TestHealElf() //Probamos que el método Heal funcione correctamente
        {
            elf2.HealElf(elf1);
            Assert.AreEqual(600, elf1.GetHP());
        }

    }


}