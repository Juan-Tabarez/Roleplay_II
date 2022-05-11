using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class DwarfTest
    {
        Dwarf gimli;

        [SetUp]
        public void Setup()
        {
            this.gimli = new Dwarf("Gimli");
            this.gimli.Axe = new Axe();
            this.gimli.Helmet = new Helmet();
            this.gimli.Shield = new Shield();
        }

        //Test que demuestra que es posible asignar un nombre distinto.
        [Test]
        public void ValidNameTest()
        {
            this.gimli.Name = "Baldur";
            Assert.AreEqual(this.gimli.Name, "Baldur");
        }

        //Test que demuestra que es posible asignar una vida válida.
        [Test]
        public void ValidHealthTest()
        {
            Assert.AreEqual(this.gimli.Health, 100);
        }

        //Test para saber el ataque de un personaje.
        [Test]
        public void AttackValue()
        {
            int expectedAttack = 25;
            Assert.AreEqual(expectedAttack, this.gimli.AttackValue);
        }

        //Test para saber la defensa de un personaje.
        [Test]
        public void DefenseValueTest()
        {
            int expectedDefense = 32;
            Assert.AreEqual(expectedDefense, this.gimli.DefenseValue);
        }

        //Test para verificar que un personaje puede atacar a otro personaje.
        [Test]
        public void AttackCharacterTest()
        {
            Archer legolas = new Archer("Legolas");
            legolas.Bow = new Bow();
            legolas.Helmet = new Helmet();
            legolas.ReceiveAttack(this.gimli.AttackValue);
            int expectedHealth = 93;
            Assert.AreEqual(expectedHealth, legolas.Health);
        }

        //Test que demuestra que un personaje puede curarse correctamente.
        [Test]
        public void HealTest()
        {
            this.gimli.ReceiveAttack(this.gimli.AttackValue * 3);
            this.gimli.Cure();
            Assert.AreEqual(this.gimli.Health, 100);
        }
    }
}