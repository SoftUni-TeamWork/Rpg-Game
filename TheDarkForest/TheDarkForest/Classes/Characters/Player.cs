namespace TheDarkForest.Classes.Characters
{
    using System;

    public class Player : Character
    {
        private const int HealthGrowingOnLelvelUp = 100;

        private int experience = 0;
        private int neededExperienceForLevelUp = 1000;
        private int maxHealth;

        public Player(Guid id, int healthPoints, int attackPoints, int defencePoints, int currentLevel, Position position) 
            : base(id, healthPoints, attackPoints, defencePoints, currentLevel, position)
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
            this.CurrentLevel += 1;
            this.neededExperienceForLevelUp *= 2;
            this.maxHealth += HealthGrowingOnLelvelUp;
            this.HealthPoints += maxHealth;
        }
    }
}
