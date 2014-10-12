﻿namespace TheDarkForest.Resources.Interfaces
{
    using TheDarkForest.Resources.Classes;

    public interface IGameObject
    {
        int HealthPoints { get; }

        int AttackPoints { get; }

        int DefencePoints { get; }

        int CurrentLevel { get; }

        Position Position { get; }
    }
}
