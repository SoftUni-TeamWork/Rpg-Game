namespace TheDarkForest.Classes.Items
{
    using System;

    public class Shield : Item
    {
        private const int DefaultHealthPoints = 0;
        private const int DefaultAttackPoints = 0;
        private const int DefaultDefencePoints = 20;

        public Shield(Guid id)
            : base(id, DefaultHealthPoints, DefaultAttackPoints, DefaultDefencePoints)
        {
        }

        public Shield(Guid id, int defencePoints)
            : base(id, DefaultHealthPoints, DefaultAttackPoints, defencePoints)
        {
        }
    }
}
