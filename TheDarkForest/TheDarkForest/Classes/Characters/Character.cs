namespace TheDarkForest.Classes
{
    using System;
    using TheDarkForest.Classes.Items;
    using TheDarkForest.Enumerations;
    using TheDarkForest.Interfaces;

    public abstract class Character : GameObject, ICharacter, IMove, IAttack
    {
        protected const int DefaultHealthPoints = 100;
        protected const int DefaultAttackPoints = 20;
        protected const int DefaultDefencePoints = 10;
        protected const int DefaultStartLevel = 1;
        protected const int MovingSpeed = 1;

        private static readonly Position DefaultPosition = new Position() { X = 0, Y = 0 };

        private int healthPoints;
        private int attackPoints;
        private int defencePoints;
        private int currentLevel;
        private Position position;
        private Inventory inventory;
        private bool isAlive = true;
        
        // public Character()
        //    : this(DefaultHealthPoints, DefaultAttackPoints, DefaultDefencePoints, DefaultStartLevel, DefaultPosition)
        // {
        // }

        public Character(Guid id, int healthPoints, int attackPoints, int defencePoints, int currentLevel, Position position) 
            : base(id)
        {
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefencePoints = defencePoints;
            this.CurrentLevel = currentLevel;
            this.Position = position;
            this.inventory = new Inventory();
            this.isAlive = true;
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
           
            internal set
            {
                if (value < 0)
                {
                    isAlive = false;
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

        public void AddItem(Item item)
        {
            this.inventory.AddItem(item);

            this.HealthPoints += item.EffectHealthPoints;
            this.AttackPoints += item.EffectAttackPoints;
            this.DefencePoints += item.EffectDefencePoints;
        }

        public void RemoveItem(Item item)
        {
            this.inventory.RemoveItem(item);

            this.HealthPoints -= item.EffectHealthPoints;
            this.AttackPoints -= item.EffectAttackPoints;
            this.DefencePoints -= item.EffectDefencePoints;
        }

        public virtual void Move(Direction direction)
        {
            //Pseudo logic moving speed must be changed in any time
            if (direction == Direction.Left)
            {
                this.position.X -= MovingSpeed;
            }
            else if (direction == Direction.Right)
            {
                this.position.X += MovingSpeed;
            }
            else if (direction == Direction.Up)
            {
                this.position.Y += MovingSpeed;
            }
            else
            {
                this.position.Y -= MovingSpeed;
            }
        }

        public virtual void Attack(Character target, AttackType attackType)
        {
            target.HealthPoints = target.HealthPoints - (this.AttackPoints - target.DefencePoints);
        }
    }
}
