namespace TheDarkForest.Classes.Items
{
    using System;
    using System.Collections.Generic;

    public class Inventory
    {
        private ISet<Item> items;

        public Inventory()
        {
            this.items = new HashSet<Item>();
        }

        public void AddItem(Item item)
        {
            if (item == null)
            {
                throw new ArgumentException("The item cannot be null");
            }

            this.items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            if (!this.items.Contains(item))
            {
                throw new ArgumentException("The items doesn't contain the currentItem");
            }

            this.items.Remove(item);
        }
    }
}
