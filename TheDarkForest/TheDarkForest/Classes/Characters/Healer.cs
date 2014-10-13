using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDarkForest.Classes.Characters
{
    using System;

    public class Healer : Character
    {
        private const int HealingPotion = 15;

        private bool isTired = true;

        public Healer(Guid id, int healthPoints, int attackPoints, int defencePoints, int currentLevel, Position position) 
            : base(id, healthPoints, attackPoints, defencePoints, currentLevel, position)
        {
        }

        protected void Heal(Character player)
        {
            if (this.isTired)
            {
                if (player.Position.X - this.Position.X < 1 &&
                    player.Position.Y - this.Position.X < 1)
                {
                    player.HealthPoints += HealingPotion * player.CurrentLevel; // healing depents of players leveal 
                    isTired = false;
                }
            }
        }
    }
}
