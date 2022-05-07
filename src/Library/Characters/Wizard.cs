namespace RoleplayGame
{
    public class Wizard : ICharacter
    {
        private int health = 100;

        public Wizard(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public SpellsBook SpellsBook { get; set; }

        public Staff Staff { get; set; }

        public int AttackValue
        {
            get
            {
                return SpellsBook.AttackValue + Staff.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return SpellsBook.DefenseValue + Staff.DefenseValue;
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