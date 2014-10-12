namespace TheDarkForest.Interfaces
{
    using TheDarkForest.Classes;

    public interface ICharacter
    {
        int HealthPoints { get; }

        int AttackPoints { get; }

        int DefencePoints { get; }

        int CurrentLevel { get; }

        Position Position { get; }
    }
}
