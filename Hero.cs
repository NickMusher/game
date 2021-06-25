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
        private static int Damage(int health)
        {
            int damage = 0;

            if (health > damage && RightHand is WeaponCard rightWeapon)
            {
                damage += rightWeapon.Damage;
                rightWeapon.Durability.DownOn(1);
                if (rightWeapon.IsBroken())
                    RightHand = null;
            }

            if (health > damage && LeftHand is WeaponCard leftWeapon)
            {
                damage += leftWeapon.Damage;
                leftWeapon.Durability.DownOn(1);
                if (leftWeapon.IsBroken())
                    LeftHand = null;
            }

            return damage;
        }

        public static Card RightHand { get; set; }
        public static Card LeftHand { get; set; }
        public static ArmorCard Helmet { get; set; }
        public static ArmorCard Breastplate { get; set; }
        public static ArmorCard Boots { get; set; }
        public static Card Backpack { get; set; }

        public void Attack(EnemyCard enemy)
        {
            enemy.Health.DownOn(Damage(enemy.Health.Actual));
        }

        public static int Resisted(int damage)
        {
            int resist = 0;

            if (damage > resist && Helmet != null)
            {
                resist += Helmet.Protection;
                Helmet.Durability.DownOn(1);
                if (Helmet.IsBroken())
                    Helmet = null;
            }

            if (damage > resist && Breastplate != null)
            {
                resist += Breastplate.Protection;
                Breastplate.Durability.DownOn(1);
                if (Breastplate.IsBroken())
                    Breastplate = null;
            }

            if (damage > resist && Boots != null)
            {
                resist += Boots.Protection;
                Boots.Durability.DownOn(1);
                if (Boots.IsBroken())
                    Boots = null;
            }

            if (damage - resist < 0)
                return 0;
            return damage - resist;
        }

        public bool TryTake(Card card)
        {
            if (card is WeaponCard weapon)
            #region
                if (RightHand == null)
                {
                    RightHand = weapon;
                    return true;
                }
                else if (RightHand is WeaponCard anotherWeaponR1)
                    if (weapon.Damage > anotherWeaponR1.Damage)
                        if (LeftHand == null)
                        {
                            LeftHand = anotherWeaponR1;
                            RightHand = weapon;
                            return true;
                        }
                        else if (LeftHand is WeaponCard anotherWeaponL1)
                            if (anotherWeaponR1.Damage > anotherWeaponL1.Damage)
                                if (Backpack == null)
                                {
                                    Backpack = anotherWeaponL1;
                                    LeftHand = anotherWeaponR1;
                                    return true;
                                }
                                else return false;
                            else if (Backpack == null)
                            {
                                Backpack = anotherWeaponR1;
                                return true;
                            }
                            else return false;
                        else if (Backpack == null)
                        {
                            Backpack = anotherWeaponR1;
                            RightHand = weapon;
                            return true;
                        }
                        else return false;
                    else if (LeftHand == null)
                    {
                        LeftHand = weapon;
                        return true;
                    }
                    else if (LeftHand is WeaponCard anotherWeaponL2)
                        if (weapon.Damage > anotherWeaponL2.Damage)
                            if (Backpack == null)
                            {
                                Backpack = anotherWeaponL2;
                                LeftHand = weapon;
                                return true;
                            }
                            else return false;
                        else if (Backpack == null)
                        {
                            Backpack = weapon;
                            return true;
                        }
                        else return false;
                    else if (Backpack == null)
                    {
                        Backpack = weapon;
                        return true;
                    }
                    else return false;
                else if (LeftHand == null)
                {
                    LeftHand = weapon;
                    return true;
                }
                else if (LeftHand is WeaponCard anotherWeaponL3)
                    if (weapon.Damage > anotherWeaponL3.Damage)
                        if (Backpack == null)
                        {
                            Backpack = anotherWeaponL3;
                            RightHand = weapon;
                            return true;
                        }
                        else return false;
                    else if (Backpack == null)
                    {
                        Backpack = weapon;
                        return true;
                    }
                    else return false;
                else if (Backpack == null)
                {
                    Backpack = weapon;
                    return true;
                }
                else return false;
            #endregion

            if (card is ArmorCard armor)
            {
                if (armor.Type == ArmorCard.Slot.Helmet)
                    if (Helmet == null)
                    {
                        Helmet = armor;
                        return true;
                    }
                    else if (Backpack == null)
                    {
                        Backpack = armor;
                        return true;
                    }
                    else return false; 

                if (armor.Type == ArmorCard.Slot.Breastplate)
                    if (Breastplate == null)
                    {
                        Breastplate = armor;
                        return true;
                    }
                    else if (Backpack == null)
                    {
                        Backpack = armor;
                        return true;
                    }
                    else return false;

                if (armor.Type == ArmorCard.Slot.Boots)
                    if (Boots == null)
                    {
                        Boots = armor;
                        return true;
                    }
                    else if (Backpack == null)
                    {
                        Backpack = armor;
                        return true;
                    }
                    else return false;
            }

            if (card is HealCard heal)
                if (Backpack == null)
                {
                    Backpack = heal;
                    return true;
                }
                else return false;
            return false;
        }
    }
}
