using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Hero
    {
        public Health health = new Health(20);
        private static int Damage()
        {
            int damage = 0;
            if (RightHand.Card is WeaponCard rightWeapon)
            {
                damage += rightWeapon.Damage;
                rightWeapon.Durability.DownOn(1);
            }
            if (LeftHand.Card is WeaponCard leftWeapon)
            {
                damage += leftWeapon.Damage;
                leftWeapon.Durability.DownOn(1);
            }
            return damage;
        }

        public static Slot RightHand { get; set; }
        public static Slot LeftHand { get; set; }
        public static Slot Helmet { get; set; }
        public static Slot Breastplate { get; set; }
        public static Slot Boots { get; set; }
        public static Slot Backpack { get; set; }

        public void Attack(EnemyCard enemy)
        {
            enemy.Health.DownOn(Damage());
        }

        public static int Resisted(int damage)
        {
            int resist = 0;
            if (Helmet != null && damage > resist && Helmet.Card is ArmorCard helmet && !helmet.Durability.IsDead())
            {
                resist += helmet.Protection;
                helmet.Durability.DownOn(1);
            }
            if (Breastplate != null && damage > resist && Breastplate.Card is ArmorCard breastplate && !breastplate.Durability.IsDead()) 
            {
                resist += breastplate.Protection;
                breastplate.Durability.DownOn(1);
            }
            if (Boots != null && damage > resist && Boots.Card is ArmorCard boots && !boots.Durability.IsDead())
            {
                resist += boots.Protection;
                boots.Durability.DownOn(1);
            }

            if (damage - resist < 0)
                return 0;
            return damage - resist;
        }
    }
}
