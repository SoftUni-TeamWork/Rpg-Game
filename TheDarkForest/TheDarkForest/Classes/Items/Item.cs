namespace TheDarkForest.Classes
{
    using System;

    public abstract class Item : GameObject
    {
        private int effectOnChar;

        public Item(Guid id, int effectOnChar)
            : base(id)
        {
            this.EffectOnCharr = effectOnChar;
        }

        public int EffectOnCharr
        {
            get
            {
                return this.effectOnChar;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The effect on the character cannot be negative");
                }

                this.effectOnChar = value;
            }
        }
    }
}
