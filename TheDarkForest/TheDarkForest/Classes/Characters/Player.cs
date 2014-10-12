﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDarkForest.Classes.Characters
{
    public class Player : Character
    {
        internal int experience = 0;// players starts whit no experience
        internal int neededExperienceForLevelUp = 1000;
        public Player(Guid id, int healthPoints, int attackPoints, int defencePoints, int currentLevel, Position position) 
            : base(id, healthPoints, attackPoints, defencePoints, currentLevel, position)
        {
        }

        public int Experience
        {
            get
            {
                return this.experience;
            }

            set
            {
                // or should be triggerd LevelUp by event 
                if (value <= neededExperienceForLevelUp)
                {
                    LevelUp();
                }

                this.experience = value;
            }
        }

        
        private void LevelUp()
        {
            this.CurrentLevel += 1;
            this.neededExperienceForLevelUp *= 2;
            // Console.WriteLine("Congratulations!\nYou are reached level {0}.", this.CurrentLevel);
        }
    }
}
