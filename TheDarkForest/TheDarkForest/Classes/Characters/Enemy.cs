namespace TheDarkForest.Classes.Characters
{
    using System;

    public class Enemy : Character
    {
        public Enemy(Guid id, int healthPoints, int attackPoints, int defencePoints, int currentLevel, Position position) 
            : base(id, healthPoints, attackPoints, defencePoints, currentLevel, position)
        {
        }
    }
}
