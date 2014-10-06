namespace Game2D.Models
{
    using Game2D.Enumerations;
    using Game2D.Interfaces;
    using System;

    public class Player : IMovable, IAttackable, IPlayer
    {
        private const int DefaultHealthPoints = 100;
        private const int DefaultAttackPoints = 20;
        private const int DefaultDefencePoints = 10;
        private const int DefaultStartLevel = 1;

        private int healthPoints;
        private int attackPoints;
        private int defencePoints;
        private int currentLevel;
        private PlayerType playerType;

        public Player()
            : this(DefaultHealthPoints, DefaultAttackPoints, DefaultDefencePoints, DefaultStartLevel, PlayerType.Warrior)
        {
        }

        private Player(int healthPoints, int attackPoints, int defencePoints, int currentLevel, PlayerType playerType)
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

            private set
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

            private set
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

            private set
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

            private set
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
    }
}
