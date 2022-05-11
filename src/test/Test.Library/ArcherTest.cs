using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ArcherTest
    {
        Archer legolas;

        [SetUp]
        public void Setup()
        {
            this.legolas = new Archer("Legolas");
            this.legolas.Bow = new Bow();
            this.legolas.Helmet = new Helmet();
        }

//Test que demuestra que es posible asignar un nombre distinto.
        [Test]
        public void ValidNameTest()
        {
            this.legolas.Name = "Sarion";
            Assert.AreEqual(this.legolas.Name, "Sarion");
        }

        //Test que demuestra que es posible asignar una vida válida.
        [Test]
        public void ValidHealthTest()
        {
            Assert.AreEqual(this.legolas.Health, 100);
        }

        //Test para saber el ataque de un personaje.
        [Test]
        public void AttackValue()
        {
            int expectedAttack = 15;
            Assert.AreEqual(expectedAttack, this.legolas.AttackValue);
        }

        //Test para saber la defensa de un personaje.
        [Test]
        public void DefenseValueTest()
        {
            int expectedDefense = 18;
            Assert.AreEqual(expectedDefense, this.legolas.DefenseValue);
        }

        //Test para verificar que un personaje puede atacar a otro personaje.
        [Test]
        public void AttackCharacterTest()
        {
            Archer frey = new Archer("Frey");
            frey.Bow = new Bow();
            frey.Helmet = new Helmet();
            frey.ReceiveAttack(this.legolas.AttackValue);
            int expectedHealth = 100;
            Assert.AreEqual(expectedHealth, frey.Health);
        }

        //Test que demuestra que un personaje puede curarse correctamente.
        [Test]
        public void HealTest()
        {
            this.legolas.ReceiveAttack(this.legolas.AttackValue * 3);
            this.legolas.Cure();
            Assert.AreEqual(this.legolas.Health, 100);
        }
    }
}