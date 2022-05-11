namespace RoleplayGame
{
    public interface ICharacter
    {
        public string Name { get; }
        
        public int Health { get; }

        public int AttackValue { get; }

        public int DefenseValue { get; } 

        public void ReceiveAttack(int power);

        public void Cure();
    }
}