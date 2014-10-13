namespace TheDarkForest.Classes
{
    using System;

    public abstract class Item : GameObject
    {
        private int effectHealthPoints;
        private int effectAttackPoints;
        private int effectDefencePoints;

        public Item(Guid id, int effectHealthPoints, int effectAttackPoints, int effectDefencePoints)
            : base(id)
        {
            this.EffectHealthPoints = effectHealthPoints;
            this.EffectAttackPoints = effectAttackPoints;
            this.EffectDefencePoints = effectDefencePoints;
        }

        public int EffectHealthPoints
        {
            get
            {
                return this.effectHealthPoints;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The health points of the item cannot be negative");
                }

                this.effectHealthPoints = value;
            }
        }

        public int EffectAttackPoints
        {
            get
            {
                return this.effectAttackPoints;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The attack points of the item cannot be negative");
                }

                this.effectAttackPoints = value;
            }
        }

        public int EffectDefencePoints
        {
            get
            {
                return this.effectDefencePoints;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The defence points of the item cannot be negative");
                }

                this.effectDefencePoints = value;
            }
        }
    }
}
