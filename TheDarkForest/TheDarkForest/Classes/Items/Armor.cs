namespace TheDarkForest.Classes
{
    using System;

    public class Armor : Item
    {
        private const int DefaultHealthPoints = 20;

        public Armor(Guid id) 
            : base(id, DefaultHealthPoints, 0, 0)
        {
        }
    }
}
