namespace TheDarkForest.Classes.Characters
{
    using System;

    public class Enemy : Character
    {
        public Enemy(Guid id, int healthPoints, int attackPoints, int defencePoints, Position position, int currentLevel) 
            : base(id, healthPoints, attackPoints, defencePoints, position, currentLevel)
        {
        }
    }
}
