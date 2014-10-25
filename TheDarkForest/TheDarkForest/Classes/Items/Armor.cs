namespace TheDarkForest.Classes
{
    using System;

    public class Armor : Item
    {
        private const int DefaultAttackPoints = 0;
        private const int DefaultHealthPoints = 20;
        private const int DefaultDefencePoints = 0;

        public Armor(Guid id)
            : base(id, DefaultHealthPoints, DefaultAttackPoints, DefaultDefencePoints)
        {
        }
        public Armor(Guid id, int healthPoints)
            : base(id, healthPoints, DefaultAttackPoints, DefaultDefencePoints)
        {
        }
    }
}
