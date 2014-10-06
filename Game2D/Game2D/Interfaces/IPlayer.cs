namespace Game2D.Interfaces
{
    public interface IPlayer
    {
        int HealthPoints { get; }

        int AttackPoints { get; }

        int DefencePoints { get; }

        int CurrentLevel { get; }
    }
}
