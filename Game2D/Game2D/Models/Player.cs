namespace Game2D.Models
{
    using System;
    using Game2D.Enumerations;
    using Game2D.Interfaces;

    public abstract class Player : IMovable, IAttackable, IPlayer
    {
        protected const int DefaultHealthPoints = 100;
        protected const int DefaultAttackPoints = 20;
        protected const int DefaultDefencePoints = 10;
        protected const int DefaultStartLevel = 1;

        private const string PlayerFormatString = "Health points: {0}\nAttack points: {1}\nDefence points: {2}\nCurrent level: {3}\nPlayer type: {4}";

        private int healthPoints;
        private int attackPoints;
        private int defencePoints;
        private int currentLevel;
        private PlayerType playerType;

        public Player(PlayerType playerType)
            : this(DefaultHealthPoints, DefaultAttackPoints, DefaultDefencePoints, DefaultStartLevel, playerType)
        {
        }

        public Player(int healthPoints, int attackPoints, int defencePoints, int currentLevel, PlayerType playerType)
        {
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefencePoints = defencePoints;
            this.CurrentLevel = currentLevel;
            this.PlayerType = playerType;
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The health points cannot be negative");
                }

                this.healthPoints = value;
            }
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The attack points cannot be negative");
                }

                this.attackPoints = value;
            }
        }

        public int DefencePoints
        {
            get
            {
                return this.defencePoints;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The defence points cannot be negative");
                }

                this.defencePoints = value;
            }
        }

        public int CurrentLevel
        {
            get
            {
                return this.currentLevel;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The current level cannot be negative");
                }

                if (value - this.CurrentLevel != 1)
                {
                    throw new ArgumentException("You are cheating. You can't upgrade your level with more than 1");
                }

                this.CurrentLevel = value;
            }
        }

        public PlayerType PlayerType { get; private set; }

        public virtual void Move(Direction direction)
        {
            throw new NotImplementedException();
        }

        public virtual void Attack(Player player)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Format(PlayerFormatString, this.HealthPoints, this.AttackPoints, this.DefencePoints, this.CurrentLevel, this.PlayerType);
        }
    }
}
