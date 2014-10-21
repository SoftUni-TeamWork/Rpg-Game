namespace TheDarkForest.Classes.Characters
{
    using System;

    public class Healer : Character
    {
        private const int HealingPotion = 15;
        private const int HealersRange = 2;

        internal bool isInOrderToHeal = true;

        public Healer(Guid id, int healthPoints, int attackPoints, int defencePoints, int currentLevel, Position position)
            : base(id, healthPoints, attackPoints, defencePoints, position, currentLevel)
        {
        }

        protected void Heal(Character player)
        {
            if (this.isInOrderToHeal)
            {
                // helers range is equal in X and in Y coordinate
                bool isPlayerInRange = player.Position.X - (this.Position.X + HealersRange) <= 0 &&
                                       player.Position.Y - (this.Position.Y + HealersRange) <= 0;
                
                if (isPlayerInRange)
                {
                    player.HealthPoints += HealingPotion * player.CurrentLevel; // healing depents of players leveal 
                    this.isInOrderToHeal = false;
                }
            }
        }
    }
}
