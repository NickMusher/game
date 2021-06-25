using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GameFieldForm : Form
    {
        public Hero ne = new Hero();
        public GameFieldForm()
        {
            InitializeComponent();
            Planet.Coloda();
            List<Card> cards = Planet.coloda;
            Zapol(cards);
            textBox1.Text = ne.health.Actual.ToString();
        }
        
        
        public void Zapol(List<Card> cards)
        {
            if (Table.Slot1 == null)
            {
                Table.Slot1 = cards[cards.Count - 1];
                cards.RemoveAt(cards.Count - 1);
                button1.Text = Table.Slot1.Name;
            }
            if (Table.Slot2 == null)
            {
                Table.Slot2 = cards[cards.Count - 1];
                cards.RemoveAt(cards.Count - 1);
                button2.Text = Table.Slot2.Name;
            }
            if (Table.Slot3 == null)
            {
                Table.Slot3 = cards[cards.Count - 1];
                cards.RemoveAt(cards.Count - 1);
                button3.Text = Table.Slot3.Name;
            }
            if (Table.Slot4 == null)
            {
                Table.Slot4 = cards[cards.Count - 1];
                cards.RemoveAt(cards.Count - 1);
                button4.Text = Table.Slot4.Name;
            }
            if (Table.Slot5 == null)
            {
                Table.Slot5 = cards[cards.Count - 1];
                cards.RemoveAt(cards.Count - 1);
                button5.Text = Table.Slot5.Name;
            }
            if (Table.Slot6 == null)
            {
                Table.Slot6 = cards[cards.Count - 1];
                cards.RemoveAt(cards.Count - 1);
                button6.Text = Table.Slot6.Name;
            }

        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm { Owner = this };
            settings.Show();
        }

        private void helmetButton_Click(object sender, EventArgs e)
        {
            Hero.Helmet = null;
        }

        private void breastplateButton_Click(object sender, EventArgs e)
        {
            Hero.Breastplate = null;
        }

        private void bootsButton_Click(object sender, EventArgs e)
        {
            Hero.Boots = null;

        }

        private void leftHandButton_Click(object sender, EventArgs e)
        {
            if (Hero.LeftHand is WeaponCard leftWeapon)
                Hero.LeftHand = null;
            else if (Hero.LeftHand is HealCard heal)
            {
                //heal
            }
        }

        private void rightHandButton_Click(object sender, EventArgs e)
        {
            if (Hero.RightHand is WeaponCard rightWeapon)
                Hero.RightHand = null;
            else if (Hero.RightHand is HealCard heal)
            {
                //heal
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TryTake1(Table.Slot1))
            {
                Table.Slot1 = null;
                button1.Text = "пусто";
            }
            if (Table.Slot1 is EnemyCard enemy)
            {
                enemy.Attak(ne);
                ne.Attack(enemy);
            }
            Rendering();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TryTake1(Table.Slot2))
            {
                Table.Slot2 = null;
                button2.Text = "пусто";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TryTake1(Table.Slot3))
            {
                Table.Slot3 = null;
                button3.Text = "пусто";
            }
            //if (Table.Slot3 is ArmorCard arm)
            //{
            //    if (arm.Type == ArmorCard.Slot.Helmet)
            //    {
            //        Hero.Helmet = arm;
            //        helmetButton.Text = arm.Name;
            //    }
            //    if (arm.Type == ArmorCard.Slot.Breastplate)
            //    {
            //        Hero.Breastplate = arm;
            //        breastplateButton.Text = arm.Name;
            //    }
            //    if (arm.Type == ArmorCard.Slot.Boots)
            //    {
            //        Hero.Boots = arm;
            //        bootsButton.Text = arm.Name;
            //    }
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TryTake1(Table.Slot4))
            {
                Table.Slot4 = null;
                button4.Text = "пусто";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TryTake1(Table.Slot5))
            {
                Table.Slot5 = null;
                button5.Text = "пусто";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TryTake1(Table.Slot6))
            {
                Table.Slot6 = null;
                button6.Text = "пусто";
            }
        }
        public void Rendering()
        {
            textBox1.Text = ne.health.Actual.ToString();
            if (Hero.Helmet!=null)
            {
                helmetButton.Text=Hero.Helmet.Name;
            }
            if (Hero.Backpack != null)
            {

            }
            if (Hero.RightHand != null)
            {

            }
            if (Hero.LeftHand != null)
            {

            }
            if (Hero.Breastplate != null)
            {

            }
            if (Hero.Boots!= null)
            {

            }
            if (Table.Slot1 != null)
            {

            }
            if (Table.Slot2 != null)
            {

            }
            if (Table.Slot3 != null)
            {

            }
            if (Table.Slot4 != null)
            {

            }
            if (Table.Slot5 != null)
            {

            }
            if (Table.Slot6 != null)
            {

            }

        }
        public bool TryTake1(Card card)
        {
            if (card is WeaponCard weapon)
                #region
                if (Hero.RightHand == null)
                {
                    Hero.RightHand = weapon;
                    rightHandButton.Text = ""+weapon.Name+ "\r\n"+weapon.Durability.Actual.ToString()+"   "+weapon.Damage.ToString()+"";
                    return true;
                }
                else if (Hero.RightHand is WeaponCard anotherWeaponR1)
                    if (weapon.Damage > anotherWeaponR1.Damage)
                        if (Hero.LeftHand == null)
                        {
                            Hero.LeftHand = anotherWeaponR1;
                            leftHandButton.Text = anotherWeaponR1.Name;
                            Hero.RightHand = weapon;
                            rightHandButton.Text = weapon.Name;
                            return true;
                        }
                        else if (Hero.LeftHand is WeaponCard anotherWeaponL1)
                            if (anotherWeaponR1.Damage > anotherWeaponL1.Damage)
                                if (Hero.Backpack == null)
                                {
                                    Hero.Backpack = anotherWeaponL1;
                                    Hero.LeftHand = anotherWeaponR1;
                                    return true;
                                }
                                else return false;
                            else if (Hero.Backpack == null)
                            {
                                Hero.Backpack = anotherWeaponR1;
                                return true;
                            }
                            else return false;
                        else if (Hero.Backpack == null)
                        {
                            Hero.Backpack = anotherWeaponR1;
                            Hero.RightHand = weapon;
                            return true;
                        }
                        else return false;
                    else if (Hero.LeftHand == null)
                    {
                        Hero.LeftHand = weapon;
                        return true;
                    }
                    else if (Hero.LeftHand is WeaponCard anotherWeaponL2)
                        if (weapon.Damage > anotherWeaponL2.Damage)
                            if (Hero.Backpack == null)
                            {
                                Hero.Backpack = anotherWeaponL2;
                                Hero.LeftHand = weapon;
                                return true;
                            }
                            else return false;
                        else if (Hero.Backpack == null)
                        {
                            Hero.Backpack = weapon;
                            return true;
                        }
                        else return false;
                    else if (Hero.Backpack == null)
                    {
                        Hero.Backpack = weapon;
                        return true;
                    }
                    else return false;
                else if (Hero.LeftHand == null)
                {
                    Hero.LeftHand = weapon;
                    return true;
                }
                else if (Hero.LeftHand is WeaponCard anotherWeaponL3)
                    if (weapon.Damage > anotherWeaponL3.Damage)
                        if (Hero.Backpack == null)
                        {
                            Hero.Backpack = anotherWeaponL3;
                            Hero.RightHand = weapon;
                            return true;
                        }
                        else return false;
                    else if (Hero.Backpack == null)
                    {
                        Hero.Backpack = weapon;
                        return true;
                    }
                    else return false;
                else if (Hero.Backpack == null)
                {
                    Hero.Backpack = weapon;
                    return true;
                }
                else return false;
            #endregion

            if (card is ArmorCard armor)
            {
                if (armor.Type == ArmorCard.Slot.Helmet)
                    if (Hero.Helmet == null)
                    {
                        Hero.Helmet = armor;
                        return true;
                    }
                    else if (Hero.Backpack == null)
                    {
                        Hero.Backpack = armor;
                        return true;
                    }
                    else return false;

                if (armor.Type == ArmorCard.Slot.Breastplate)
                    if (Hero.Breastplate == null)
                    {
                        Hero.Breastplate = armor;
                        return true;
                    }
                    else if (Hero.Backpack == null)
                    {
                        Hero.Backpack = armor;
                        return true;
                    }
                    else return false;

                if (armor.Type == ArmorCard.Slot.Boots)
                    if (Hero.Boots == null)
                    {
                        Hero.Boots = armor;
                        return true;
                    }
                    else if (Hero.Backpack == null)
                    {
                        Hero.Backpack = armor;
                        return true;
                    }
                    else return false;
            }

            if (card is HealCard heal)
                if (Hero.Backpack == null)
                {
                    Hero.Backpack = heal;
                    return true;
                }
                else return false;
            return false;
        }
    }
}
