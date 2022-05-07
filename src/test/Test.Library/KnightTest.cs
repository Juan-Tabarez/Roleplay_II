using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class KnightTest
    {
        Knight arthur;

        [SetUp]
        public void Setup()
        {
            this.arthur = new Knight("arthur");
            this.arthur.Sword = new Sword();
            this.arthur.Shield = new Shield();
            this.arthur.Armor = new Armor();
        }

//Test que demuestra que es posible asignar un nombre distinto.
        [Test]
        public void ValidNameTest()
        {
            this.arthur.Name = "Benjamin";
            Assert.AreEqual(this.arthur.Name, "Benjamin");
        }

        //Test que demuestra que no es posible asignar una vida válida.
        [Test]
        public void InvalidHealthTest()
        {
            this.arthur.Health = -30;
            Assert.AreEqual(this.arthur.Health, 0);
        }

        //Test que demuestra que es posible asignar una vida válida.
        [Test]
        public void ValidHealthTest()
        {
            Assert.AreEqual(this.arthur.Health, 100);
        }

        //Test para saber el ataque de un personaje.
        [Test]
        public void AttackValue()
        {
            int expectedAttack = 20;
            Assert.AreEqual(expectedAttack, this.arthur.AttackValue);
        }

        //Test para saber la defensa de un personaje.
        [Test]
        public void DefenseValueTest()
        {
            int expectedDefense = 39;
            Assert.AreEqual(expectedDefense, this.arthur.DefenseValue);
        }

        //Test para verificar que un personaje puede atacar a otro personaje.
        [Test]
        public void AttackCharacterTest()
        {
            Knight fernando = new Knight("Fernando");
            fernando.Sword = new Sword();
            fernando.Shield = new Shield();
            fernando.Armor = new Armor();
            this.arthur.AttackCharacter(fernando);
            int expectedHealth = 100;
            Assert.AreEqual(expectedHealth, fernando.Health);
        }

        //Test que demuestra que un personaje puede curarse correctamente.
        [Test]
        public void HealTest()
        {
            this.arthur.Health = 0;
            this.arthur.Cure();
            Assert.AreEqual(this.arthur.Health, 100);
        }
    }
}