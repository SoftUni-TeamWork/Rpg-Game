using TheDarkForest.Enumerations;

namespace TheDarkForest.Classes.Characters
{
    using System;

    public class Player : Character
    {
        private const int HealthGrowingOnLelvelUp = 100;
        private const int AttackGrowingOnLelvelUp = 10;
        private const int DefenceGrowingOnLelvelUp = 10;

        private int experience = 0;
        private int neededExperienceForLevelUp = 1000;
        private int maxHealth;

        public Player(Guid id, int healthPoints, int attackPoints, int defencePoints, Position position)
            : base(id, healthPoints, attackPoints, defencePoints, position)
        {
        }

        public int Experience
        {
            get
            {
                return this.experience;
            }

            private set
            {
                if (this.neededExperienceForLevelUp >= value)
                {
                    this.LevelUp();

                }
                
                this.experience = value;
            }
        }

        private void LevelUp()
        {
            this.CurrentLevel++;
            this.neededExperienceForLevelUp *= 2;
            this.maxHealth += HealthGrowingOnLelvelUp;
            this.HealthPoints += maxHealth;
            this.AttackPoints += AttackGrowingOnLelvelUp;
            this.DefencePoints += DefenceGrowingOnLelvelUp;
        }
    }
}
