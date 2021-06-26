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
        public static List<Card> deck = Planet.GetDeck();

        public GameFieldForm()
        {
            InitializeComponent();
            Table.Distribution(ref deck);
            health.Text = Hero.health.Actual.ToString();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm { Owner = this };
            settings.Show();
        }

        private void HelmetButton_Click(object sender, EventArgs e)
        {
            Hero.Helmet = null;
        }

        private void BreastplateButton_Click(object sender, EventArgs e)
        {
            Hero.Breastplate = null;
        }

        private void BootsButton_Click(object sender, EventArgs e)
        {
            Hero.Boots = null;

        }

        private void LeftHandButton_Click(object sender, EventArgs e)
        {
            if (Hero.LeftHand is WeaponCard)
                Hero.LeftHand = null;
            else if (Hero.LeftHand is HealCard heal)
            {
                Hero.health.UpOn(heal.Heal);
                Hero.LeftHand = null;
            }
        }

        private void RightHandButton_Click(object sender, EventArgs e)
        {
            if (Hero.RightHand is WeaponCard)
                Hero.RightHand = null;
            else if (Hero.RightHand is HealCard heal)
            {
                Hero.health.UpOn(heal.Heal);
                Hero.RightHand = null;
            }
        }

        private void BbackpackButton_Click(object sender, EventArgs e)
        {
            if (Hero.Backpack is ArmorCard armor)
                switch ((int)armor.Type)
                { 
                    case 0: if (Hero.Helmet == null) Hero.Helmet = armor; break;
                    case 1: if (Hero.Breastplate == null) Hero.Breastplate = armor; break;
                    case 2: if (Hero.Boots == null) Hero.Boots = armor; break;
                }

            if (Hero.Backpack is WeaponCard weapon)
                Hero.TryTake(weapon);

            if (Hero.Backpack is HealCard heal)
                if (Hero.RightHand == null) Hero.RightHand = heal;
                else if (Hero.LeftHand == null) Hero.LeftHand = heal;
        }

        public void FightWith(EnemyCard enemy)
        {
            enemy.Attak();
            Hero.Attack(enemy);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Table.Slot1 is EnemyCard enemy)
            {
                FightWith(enemy);
            }
            else if(Hero.TryTake(Table.Slot1))
            {
                Table.RemoveSlot1();
            }
            Rendering();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Table.Slot2 is EnemyCard enemy)
            {
                FightWith(enemy);
            }
            else if (Hero.TryTake(Table.Slot2))
            {
                Table.RemoveSlot2();
            }
            Rendering();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (Table.Slot3 is EnemyCard enemy)
            {
                FightWith(enemy);
            }
            else if (Hero.TryTake(Table.Slot3))
            {
                Table.RemoveSlot3();
            }
            Rendering();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Table.Slot4 is EnemyCard enemy)
            {
                FightWith(enemy);
            }
            else if (Hero.TryTake(Table.Slot4))
            {
                Table.RemoveSlot4();
            }
            Rendering();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (Table.Slot5 is EnemyCard enemy)
            {
                FightWith(enemy);
            }
            else if (Hero.TryTake(Table.Slot5))
            {
                Table.RemoveSlot5();
            }
            Rendering();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (Table.Slot6 is EnemyCard enemy)
            {
                FightWith(enemy);
            }
            else if (Hero.TryTake(Table.Slot6))
            {
                Table.RemoveSlot6();
            }
            Rendering();
        }

        public void Rendering()
        {
            health.Text = Hero.health.Actual.ToString();

            if (Hero.Helmet == null)
            {
                helmetButton.Text = null;
            }
            else
            {
                helmetButton.Text = Hero.Helmet.Characteristics();
            }

            if (Hero.Breastplate == null)
            {
                breastplateButton.Text = null;
            }
            else
            {
                breastplateButton.Text = Hero.Breastplate.Characteristics();
            }

            if (Hero.Boots == null)
            {
                bootsButton.Text = null;
            }
            else
            {
                bootsButton.Text = Hero.Boots.Characteristics();
            }

            if (Hero.Backpack == null)
            {
                backpackButton.Text = null;
            }
            else
            {
                backpackButton.Text = Hero.Backpack.Characteristics();
            }

            if (Hero.RightHand == null)
            {
                rightHandButton.Text = null;
            }
            else
            {
                rightHandButton.Text = Hero.RightHand.Characteristics();
            }

            if (Hero.LeftHand != null)
            {
                leftHandButton.Text = null;
            }
            else
            {
                leftHandButton.Text = Hero.LeftHand.Characteristics();
            }

            if (Table.Slot1 == null)
            {
                button1.Text = null;
            }
            else
            {
                button1.Text = Table.Slot1.Characteristics();
            }

            if (Table.Slot2 == null)
            {
                button2.Text = null;
            }
            else
            {
                button2.Text = Table.Slot2.Characteristics();
            }

            if (Table.Slot3 == null)
            {
                button3.Text = null;
            }
            else
            {
                button3.Text = Table.Slot3.Characteristics();
            }

            if (Table.Slot4 == null)
            {
                button4.Text = null;
            }
            else
            {
                button4.Text = Table.Slot4.Characteristics();
            }

            if (Table.Slot5 == null)
            {
                button5.Text = null;
            }
            else
            {
                button5.Text = Table.Slot5.Characteristics();
            }

            if (Table.Slot6 == null)
            {
                button6.Text = null;
            }
            else
            {
                button6.Text = Table.Slot6.Characteristics();
            }
        }
    }
}
