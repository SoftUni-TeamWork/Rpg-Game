using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDarkForest.Classes
{
    public class Weapon : Item
    {
        public Weapon(Guid id, int effectOnChar) 
            : base(id, effectOnChar)
        {

        }
    }
}
