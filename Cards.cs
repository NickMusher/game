﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Card
    {
        public string Name { get; private set; }
        public Card(string name)
        {
            Name = name;
        }

        public string Characteristics()
        {
            return "";
        }
    }

    public class EnemyCard : Card
    {
        public Health Health { get; private set; }
        public int Damage { get; private set; }
        public EnemyCard(string name, int health, int damage) : base(name)
        {
            Health = new Health(health);
            Damage = damage;
        }

        public bool IsDead()
        {
            return Health.IsDead();
        }

        public void Attak()
        {
            Hero.health.DownOn(Hero.Resisted(Damage));
        }

        public new string Characteristics()
        {
            return Health.ToString() + "    " + Damage.ToString();
        }
    }

    public class WeaponCard : Card
    {
        public Health Durability { get; set; }
        public int Damage { get; private set; }
        public WeaponCard(string name, int durability, int damage) : base(name)
        {
            Durability = new Health(durability);
            Damage = damage;
        }

        public bool IsBroken()
        {
            return Durability.IsDead();
        }

        public new string Characteristics()
        {
            return Durability.ToString() + "    " + Damage.ToString();
        }
    }

    public class ArmorCard : Card
    {
        public Health Durability { get; set; }
        public int Protection { get; private set; }
        public Slot Type { get; set; }
        public ArmorCard(string name, Slot type, int durability, int protection) : base(name)
        {
            Type = type;
            Durability = new Health(durability);
            Protection = protection;
        }

        public enum Slot
        {
            Helmet = 0,
            Breastplate = 1,
            Boots = 2
        }

        public bool IsBroken()
        {
            return Durability.IsDead();
        }

        public new string Characteristics()
        {
            return Durability.ToString() + "    " + Protection.ToString();
        }
    }

    public class HealCard : Card
    {
        public int Heal { get; private set; }
        public HealCard(string name, int heal) : base(name)
        {
            Heal = heal;
        }

        public new string Characteristics()
        {
            return Heal.ToString();
        }
    }
}
