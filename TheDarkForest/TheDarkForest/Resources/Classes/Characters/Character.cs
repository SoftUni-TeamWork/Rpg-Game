namespace TheDarkForest.Resources.Classes
{
    using System;
    using TheDarkForest.Resources.Enumerations;
    using TheDarkForest.Resources.Interfaces;

    public abstract class Character : GameObject, ICharacter, IMove, IAttack
    {
        protected const int DefaultHealthPoints = 100;
        protected const int DefaultAttackPoints = 20;
        protected const int DefaultDefencePoints = 10;
        protected const int DefaultStartLevel = 1;

        private static readonly Position DefaultPosition = new Position() { X = 0, Y = 0 };

        private int healthPoints;
        private int attackPoints;
        private int defencePoints;
        private int currentLevel;
        private Position position;
        private string id;

        //public Character()
        //    : this(DefaultHealthPoints, DefaultAttackPoints, DefaultDefencePoints, DefaultStartLevel, DefaultPosition)
        //{
        //}
        
        public Character(string id, int healthPoints, int attackPoints, int defencePoints, int currentLevel, Position position)
        {
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefencePoints = defencePoints;
            this.CurrentLevel = currentLevel;
            this.Position = position;
        }

        public string Id
        {
            get
            {
                return this.id;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.id = value;
                }
                else
                {
                    throw new ArgumentException("No id character can not be created!");
                }

            }
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

        public Position Position
        {
            get
            {
                return this.position;
            }

            protected set
            {
                this.position = value;
            }
        }

        public virtual void Move(Direction direction)
        {
            throw new NotImplementedException();
        }

        public virtual void Attack(Character gameObject, AttackType attackType)
        {
            throw new NotImplementedException();
        }
    }
}
