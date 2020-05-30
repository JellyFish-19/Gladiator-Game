using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator_Game
{
    class Warrior
    {
        public string Name { get; set; } = "Warrior";
        public double HP { get; set; } = 0;
        public double attackMax { get; set; } = 0;
        public double defenceMax { get; set; } = 0;

        Random random = new Random();

        public Warrior (string Name = "Warrior", double HP = 0, double attackMax = 0, double defenceMax = 0)
        {
            this.Name = Name;
            this.HP = HP;
            this.attackMax = attackMax;
            this.defenceMax = defenceMax;
        }

        public int Attack ()
        {
            return random.Next(1, (int)attackMax);
        }

        public int Block ()
        {
            return random.Next(1, (int)defenceMax);
        }
    }
}
