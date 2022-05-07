using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class WizardTest
    {
        Wizard gandalf;

        [SetUp]
        public void Setup()
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            this.gandalf = new Wizard("Gandalf");
            this.gandalf.Staff = new Staff();
            this.gandalf.SpellsBook = book;
        }

        //Test que demuestra que es posible asignar un nombre distinto.
        [Test]
        public void ValidNameTest()
        {
            this.gandalf.Name = "Merlín";
            Assert.AreEqual(this.gandalf.Name, "Merlín");
        }

        //Test que demuestra que no es posible asignar una vida válida.
        [Test]
        public void InvalidHealthTest()
        {
            this.gandalf.Health = -30;
            Assert.AreEqual(this.gandalf.Health, 0);
        }

        //Test que demuestra que es posible asignar una vida válida.
        [Test]
        public void ValidHealthTest()
        {
            Assert.AreEqual(this.gandalf.Health, 100);
        }

        //Test para saber el ataque de un personaje.
        [Test]
        public void AttackValue()
        {
            int expectedAttack = 170;
            Assert.AreEqual(expectedAttack, this.gandalf.AttackValue);
        }

        //Test para saber la defensa de un personaje.
        [Test]
        public void DefenseValueTest()
        {
            int expectedDefense = 170;
            Assert.AreEqual(expectedDefense, this.gandalf.DefenseValue);
        }

        //Test para verificar que un personaje puede atacar a otro personaje.
        [Test]
        public void AttackCharacterTest()
        {
            Archer legolas = new Archer("Legolas");
            legolas.Bow = new Bow();
            legolas.Helmet = new Helmet();
            this.gandalf.AttackCharacter(legolas);
            int expectedHealth = 0;
            Assert.AreEqual(expectedHealth, legolas.Health);
        }

        //Test que demuestra que un personaje puede curarse correctamente.
        [Test]
        public void HealTest()
        {
            this.gandalf.Health = 0;
            this.gandalf.Cure();
            Assert.AreEqual(this.gandalf.Health, 100);
        }
    }
}