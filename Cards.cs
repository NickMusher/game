using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Card
    {
        public string Name { get; }
    }

    class EnemyCard : Card
    {
        public Health Health { get; private set; }
        public int Damage { get; private set; }
        public EnemyCard(int health, int damage)
        {
            Health = new Health(health);
            Damage = damage;
        }

        public bool IsDead()
        {
            return Health.IsDead();
        }

        public void Attak(Hero hero)
        {
            hero.health.DownOn(Hero.Resisted(Damage));
        }
    }

    class WeaponCard : Card
    {
        public Health Durability { get; set; }
        public int Damage { get; private set; }
        public WeaponCard(int health, int damage)
        {
            Durability = new Health(health);
            Damage = damage;
        }
    }

    class ArmorCard : Card
    {
        public Health Durability { get; set; }
        public int Protection { get; private set; }
        public ArmorCard(int durability, int protection)
        {
            Durability = new Health(durability);
            Protection = protection;
        }
    }

    class HealCard : Card
    {

    }
}
