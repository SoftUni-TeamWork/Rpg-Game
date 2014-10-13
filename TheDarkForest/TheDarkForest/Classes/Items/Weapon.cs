namespace TheDarkForest.Classes
{
    using System;

    public class Weapon : Item
    {
        private const int DefaultAttackPoints = 20;

        public Weapon(Guid id) 
            : base(id, 0, DefaultAttackPoints, 0)
        {
        }
    }
}
