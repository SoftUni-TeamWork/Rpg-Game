using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Effects;

namespace TheDarkForest.Classes
{
    public abstract class Item
    {

        public Item (string id, int effectOnChar) // owner is not required if element is not in character :)
        {
            this.ID = id;
            this.EffectOnCharr = effectOnChar;
        }

        public string ID { get; set; }
        public int EffectOnCharr { get; set; }
        public Character Owner { get; set; }
    }
}
