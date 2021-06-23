using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Card
    {
        public string Name { get; }
    }

    class EnemyCard : Card
    {
        public Health health;
        public int Damage { get; private set; }
    }

    class WeaponCard : Card
    {
        public Health durability;
        public int Damage { get; private set; }
    }

    class ArmorCard : Card
    {
        public Health durability;
    }

    class HealCard : Card
    {

    }
}
