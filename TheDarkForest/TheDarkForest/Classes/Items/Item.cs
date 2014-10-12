using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Effects;

namespace TheDarkForest.Classes
{
    public abstract class Item : GameObject
    {

        public Item(Guid id, int effectOnChar) 
            : base(id)
        {
            this.EffectOnCharr = effectOnChar;
        }

        public int EffectOnCharr { get; set; }
    }
}
