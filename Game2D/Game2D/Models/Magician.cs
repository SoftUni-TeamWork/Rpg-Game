namespace Game2D.Models
{
    using System;
    using Game2D.Enumerations;

    public class Magician : Player
    {
        private const int DefaultMagicPoints = 2;

        private int magicPoints;

        public Magician()
            : this(DefaultMagicPoints)
        {
        }

        public Magician(int magicPoints)
            : base(PlayerType.Magician)
        {
            this.MagicPoints = magicPoints;
            this.ApplyMagicPoints();
        }

        public int MagicPoints
        {
            get
            {
                return this.magicPoints;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The magic points should be positive");
                }

                this.magicPoints = value;
            }
        }

        private void ApplyMagicPoints()
        {
            this.HealthPoints *= this.MagicPoints;
            this.AttackPoints *= this.MagicPoints;
            this.DefencePoints *= this.MagicPoints;
        }
    }
}
