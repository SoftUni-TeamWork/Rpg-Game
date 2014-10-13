namespace TheDarkForest.Classes.Items
{
    using System;

    public class Shield : Item
    {
        private const int DefaultDefencePoints = 20;

        public Shield(Guid id) 
            : base(id, 0, 0, DefaultDefencePoints)
        {
        }
    }
}
