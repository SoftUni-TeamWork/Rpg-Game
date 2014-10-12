using System;

namespace TheDarkForest.Classes
{
    public abstract class GameObject
    {
        public Guid id;

        public GameObject(Guid id)
        {
            this.Id = id;
        }

        public Guid Id
        {
            get
            {
                return this.id;
            }

            protected set
            {
                if (value != null)
                {
                   this.id = value;
                }
                else
                {
                    throw new ArgumentException("The Game object must have id!");
                }
            }
        }
    }
}
