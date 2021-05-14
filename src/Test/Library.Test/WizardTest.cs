using System.Collections;
using NUnit.Framework;
using Library;

namespace Library.Test
{
    public class WizardTest
    {
        private Wizard Gandalf;
        private Wizard Saruman;
        private Staff MagicStaff;
        private Staff MagicStaff2;
        private Robe MagicRobe;
        private Robe MagicRobe2;
        private SpellBook SpellBook;
        private ArrayList SpellList;
        private Spell MagicSpell;

        [SetUp]
        public void Setup()
        {
        this.MagicStaff = new Staff("Staff for Testing", 10, 0, 0);
        this.MagicStaff2 = new Staff("The other Staff for Testing", 11, 0, 0);
        this.MagicRobe = new Robe("Magic Robe of Testing", 0, 10, 0);
        this.MagicRobe2 = new Robe("The other Magic Robe of Testing", 0, 10, 0);
        this.MagicSpell = new Spell("Enchant Bruno to give us 100 points", 0, 0, 2);
        this.SpellList = new ArrayList();
        SpellList.Add(MagicSpell);
        this.SpellBook = new SpellBook("Spellbook of Testing", SpellList);
        this.Gandalf = new Wizard("Gandalf the Grey", 100, MagicStaff, MagicRobe, SpellBook, 20, 5, 0);
        this.Saruman = new Wizard("Saruman the White", 80, MagicStaff, MagicRobe, SpellBook, 20, 10, 0);
        }

        [Test]
        public void TestRemoveStaff()
        {
            Gandalf.RemoveStaff();
            Assert.IsNull(Gandalf.Weapon);
        }
        [Test]
        public void TestRemoveRobe()
        {
            Gandalf.RemoveRobe();
            Assert.IsNull(Gandalf.Armor);
        }
        [Test]
        public void TestChangeStaff()
        {
            Gandalf.ChangeStaff(MagicStaff2);
            Assert.AreEqual("The other Staff for Testing", Gandalf.Weapon.GetName());
        }
        [Test]
        public void TestChangeRobe()
        {
            Gandalf.ChangeRobe(MagicRobe2);
            Assert.AreEqual("The other Magic Robe of Testing", Gandalf.Armor.GetName());
        }
        [Test]
        public void TestGetHP()
        {
            Assert.AreEqual(100, Gandalf.GetHP());
        }
        [Test]
        public void TestSetHP()
        {
            Gandalf.SetHP(200);
            Assert.AreEqual(200, Gandalf.GetHP());
        }
        [Test]
        public void TestGetDefense()
        {
            Assert.AreEqual(15, Gandalf.GetDefense());
        }
        [Test]
        public void TestAttackWizard()
        {
            Saruman.AttackWizard(Gandalf);
            Assert.AreEqual(85, Gandalf.GetHP());
        }
        [Test]
        public void TestHealWizard()
        {
            Saruman.HealWizard(Gandalf);
            Assert.AreEqual(102, Gandalf.GetHP());
        }

    }


}