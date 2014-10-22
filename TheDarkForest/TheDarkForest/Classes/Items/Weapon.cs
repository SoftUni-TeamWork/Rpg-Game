namespace TheDarkForest.Classes
{
    using System;

    public class Weapon : Item
    {
        private const int DefaultHealthPoints = 0;
        private const int DefaultDefencePoints = 0;
        private const int DefaultAttackPoints = 20;

        public Weapon(Guid id)
            : base(id, DefaultHealthPoints, DefaultAttackPoints, DefaultDefencePoints)
        {
        }

        public Weapon(Guid id, int attackPoints)
            : base(id, DefaultHealthPoints, attackPoints, DefaultDefencePoints)
        {
        }
    }
}
