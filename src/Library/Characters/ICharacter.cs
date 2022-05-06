namespace RoleplayGame
{
    public interface ICharacter
    {
        public int Health{get; set;}

        public int AttackValue{get;}

        public int DefenseValue{get;}

        public void AttackCharacter(ICharacter character);

        public void Cure();
    }
}