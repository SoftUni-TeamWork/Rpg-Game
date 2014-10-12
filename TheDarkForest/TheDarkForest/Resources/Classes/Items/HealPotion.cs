using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDarkForest.Resources.Classes.Items
{
    class HealPotion : Item
    {
        public HealPotion(string id, int effectOnChar) 
            : base(id, effectOnChar)
        {
        }
    }
}
