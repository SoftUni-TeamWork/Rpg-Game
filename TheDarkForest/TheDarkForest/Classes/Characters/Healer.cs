using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDarkForest.Classes.Characters
{
    public class Healer : Character
    {
        private const int healingPotion = 15;
        private static bool isNotTired = false;

        public Healer(Guid id, int healthPoints, int attackPoints, int defencePoints, int currentLevel, Position position) 
            : base(id, healthPoints, attackPoints, defencePoints, currentLevel, position)
        {
        }

        protected void Heal(Character player)
        {
            if (isNotTired)
            {
                // if player is near the healer 
                if (player.Position.X - this.Position.X < 1 &&
                    player.Position.Y - this.Position.X < 1)
                {
                    player.HealthPoints += healingPotion * player.CurrentLevel; // healing depents of players leveal 
                    isNotTired = false;
                }
            }
        }
    }
}
