namespace TheDarkForest.Classes
{
    using System;

    public abstract class GameObject
    {
        private Guid id;

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
                if (value == null)
                {
                    throw new ArgumentException("The id cannot be null");
                }

                this.id = value;
            }
        }
    }
}
