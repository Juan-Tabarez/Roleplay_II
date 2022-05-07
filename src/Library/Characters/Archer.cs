namespace RoleplayGame
{
    public class Archer : ICharacter
    {
        private int health = 100;

        public Archer(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        
        public Bow Bow { get; set; }

        public Helmet Helmet { get; set; }

        public int AttackValue
        {
            get
            {
                return Bow.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return Helmet.DefenseValue;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void AttackCharacter(ICharacter character)
        {
            if ((character.Health > 0) && (this.AttackValue > character.DefenseValue))
            {
                character.Health -= (this.AttackValue - character.DefenseValue);
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}