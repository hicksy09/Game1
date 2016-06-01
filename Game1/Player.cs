using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Player
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int AttackDamage { get; set; }

        public Player(int cHealth, int cMana, int cAttackDamage)
        {
            Health = cHealth;
            Mana = cMana;
            AttackDamage = cAttackDamage;
        }

    }
}
