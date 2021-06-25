using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Planet
    {
        private static readonly int max = 3;
        private static int type;
        public static int Type
        {
            get { return type; }
            set
            {
                if (value < 0) type = max - 1;
                if (value > max) type = 0;
                type = value;
            }
        }
        public static List<Card> coloda = new List<Card>();
        public static void Coloda()
        {

            coloda.Add(new EnemyCard("vrag", 4, 4));
            coloda.Add(new WeaponCard("pushka", 4, 4));
            coloda.Add(new ArmorCard("helm", ArmorCard.Slot.Helmet, 3, 3));
            coloda.Add(new EnemyCard("vrag1", 1, 1));
            coloda.Add(new WeaponCard("pushka1", 2, 2));
            coloda.Add(new ArmorCard("bronya", ArmorCard.Slot.Breastplate, 5, 5));
        }

    }
}
