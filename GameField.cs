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
        public static List<Card> deck;

        public GameFieldForm()
        {
            InitializeComponent();
            deck = Planet.GetDeck();
            Table.Distribution(ref deck);
            health.Text = Hero.health.Actual.ToString();
            Rendering();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm { Owner = this };
            settings.Show();
        }

        private void HelmetButton_Click(object sender, EventArgs e)
        {
            Hero.Helmet = null;
            Rendering();
        }

        private void BreastplateButton_Click(object sender, EventArgs e)
        {
            Hero.Breastplate = null;
            Rendering();
        }

        private void BootsButton_Click(object sender, EventArgs e)
        {
            Hero.Boots = null;
            Rendering();

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
            Rendering();
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
            Rendering();
        }

        private void BbackpackButton_Click(object sender, EventArgs e)
        {
            if (Hero.Backpack is ArmorCard armor)
            {
                switch ((int)armor.Type)
                {
                    case 0: if (Hero.Helmet == null) Hero.Helmet = armor; break;
                    case 1: if (Hero.Breastplate == null) Hero.Breastplate = armor; break;
                    case 2: if (Hero.Boots == null) Hero.Boots = armor; break;
                }
                Hero.Backpack = null;
            }

            if (Hero.Backpack is WeaponCard weapon)
            {
                Hero.TryTake(weapon);
                Hero.Backpack = null;
            }

            if (Hero.Backpack is HealCard heal)
            {
                if (Hero.RightHand == null)
                {
                    Hero.RightHand = heal;
                    Hero.Backpack = null;
                }
                else if (Hero.LeftHand == null)
                {
                    Hero.LeftHand = heal;
                    Hero.Backpack = null;

                }
            }
            Rendering();
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
                if (enemy.Health.Actual <= 0)
                    Table.RemoveSlot1();
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
                if (enemy.Health.Actual <= 0)
                    Table.RemoveSlot2();
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
                if (enemy.Health.Actual <= 0)
                    Table.RemoveSlot3();
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
                if (enemy.Health.Actual <= 0)
                    Table.RemoveSlot4();
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
                if (enemy.Health.Actual <= 0)
                    Table.RemoveSlot5();
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
                if (enemy.Health.Actual <= 0)
                    Table.RemoveSlot6();
            }
            else if (Hero.TryTake(Table.Slot6))
            {
                Table.RemoveSlot6();
            }
            Rendering();
        }

        public void Rendering()
        {
            if (deck.Count == 0 && Table.cardValue == 0)
            {
                MessageBox.Show("Зачистка завершена!");
                var mainMenu = new MainMenuForm();
                mainMenu.Show();
                Close();
            }
            if (Hero.health.Actual == 0)
            {
                MessageBox.Show("Вы мертвы");
                var mainMenu = new MainMenuForm();
                mainMenu.Show();
                Close();
            }
            else
                health.Text = Hero.health.Actual.ToString();
            if (Table.cardValue <= 2)
                Table.Distribution(ref deck);
            if (Hero.Helmet == null)
            {
                helmetButton.Text = null;
                helmetButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.HelmetEmpty;
            }
            else
            {
                helmetButton.Text = Hero.Helmet.Characteristics;
                helmetButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.HelmetActive;
            }

            if (Hero.Breastplate == null)
            {
                breastplateButton.Text = null;
                breastplateButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.BreastplateEmty;
            }
            else
            {
                breastplateButton.Text = Hero.Breastplate.Characteristics;
                breastplateButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.BreastplateActive;
            }

            if (Hero.Boots == null)
            {
                bootsButton.Text = null;
                bootsButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.BootsEmpty;
            }
            else
            {
                bootsButton.Text = Hero.Boots.Characteristics;
                bootsButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.BootsActive;
            }

            if (Hero.Backpack == null)
            {
                backpackButton.Text = null;
                backpackButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.Backpack;
            }
            else
            {
                backpackButton.Text = Hero.Backpack.Characteristics;
                if (Hero.Backpack is ArmorCard armor)
                    switch ((int)armor.Type)
                    {
                        case 0:
                            backpackButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.HelmetBase;
                            break;
                        case 1:
                            backpackButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.BreastplateBase;
                            break;
                        case 2:
                            backpackButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.BootsBase;
                            break;
                    }
                if (Hero.Backpack is WeaponCard)
                    backpackButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.WeaponBase;
                if (Hero.Backpack is HealCard)
                    backpackButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.HealBase;


            }

            if (Hero.RightHand == null)
            {
                rightHandButton.Text = null;
                rightHandButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.RightHand;
            }
            else
            {
                rightHandButton.Text = Hero.RightHand.Characteristics;
                if (Hero.RightHand is WeaponCard)
                    rightHandButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.WeaponActive;
                if (Hero.RightHand is HealCard)
                    rightHandButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.HealActive;
            }

            if (Hero.LeftHand == null)
            {
                leftHandButton.Text = null;
                leftHandButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.LeftHand;
            }
            else
            {
                leftHandButton.Text = Hero.LeftHand.Characteristics;
                if (Hero.LeftHand is WeaponCard)
                    leftHandButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.WeaponActive;
                if (Hero.LeftHand is HealCard)
                    leftHandButton.BackgroundImage = WindowsFormsApp1.Properties.Resources.HealActive;
            }

            if (Table.Slot1 == null)
            {
                button1.Text = null;
                button1.BackgroundImage = WindowsFormsApp1.Properties.Resources.Emty;
            }
            else
            {
                button1.Text = Table.Slot1.Characteristics;
                if (Table.Slot1 is EnemyCard)
                {
                    button1.BackgroundImage = WindowsFormsApp1.Properties.Resources.Enemy;
                }
                if (Table.Slot1 is WeaponCard)
                    button1.BackgroundImage = WindowsFormsApp1.Properties.Resources.WeaponBase;
                if (Table.Slot1 is ArmorCard armor)
                    switch ((int)armor.Type)
                    {
                        case 0:
                            button1.BackgroundImage = WindowsFormsApp1.Properties.Resources.HelmetBase;
                            break;
                        case 1:
                            button1.BackgroundImage = WindowsFormsApp1.Properties.Resources.BreastplateBase;
                            break;
                        case 2:
                            button1.BackgroundImage = WindowsFormsApp1.Properties.Resources.BootsBase;
                            break;
                    }
                if (Table.Slot1 is HealCard)
                    button1.BackgroundImage = WindowsFormsApp1.Properties.Resources.HealBase;

            }

            if (Table.Slot2 == null)
            {
                button2.Text = null;
                button2.BackgroundImage = WindowsFormsApp1.Properties.Resources.Emty;
            }
            else
            {
                button2.Text = Table.Slot2.Characteristics;
                if (Table.Slot2 is EnemyCard)
                    button2.BackgroundImage = WindowsFormsApp1.Properties.Resources.Enemy;
                if (Table.Slot2 is WeaponCard)
                    button2.BackgroundImage = WindowsFormsApp1.Properties.Resources.WeaponBase;
                if (Table.Slot2 is ArmorCard armor)
                    switch ((int)armor.Type)
                    {
                        case 0:
                            button2.BackgroundImage = WindowsFormsApp1.Properties.Resources.HelmetBase;
                            break;
                        case 1:
                            button2.BackgroundImage = WindowsFormsApp1.Properties.Resources.BreastplateBase;
                            break;
                        case 2:
                            button2.BackgroundImage = WindowsFormsApp1.Properties.Resources.BootsBase;
                            break;
                    }
                if (Table.Slot2 is HealCard)
                    button2.BackgroundImage = WindowsFormsApp1.Properties.Resources.HealBase;
            }

            if (Table.Slot3 == null)
            {
                button3.Text = null;
                button3.BackgroundImage = WindowsFormsApp1.Properties.Resources.Emty;
            }
            else
            {
                button3.Text = Table.Slot3.Characteristics;
                if (Table.Slot3 is EnemyCard)
                {
                    button3.BackgroundImage = WindowsFormsApp1.Properties.Resources.Enemy;
                }
                if (Table.Slot3 is WeaponCard)
                    button3.BackgroundImage = WindowsFormsApp1.Properties.Resources.WeaponBase;
                if (Table.Slot3 is ArmorCard armor)
                    switch ((int)armor.Type)
                    {
                        case 0:
                            button3.BackgroundImage = WindowsFormsApp1.Properties.Resources.HelmetBase;
                            break;
                        case 1:
                            button3.BackgroundImage = WindowsFormsApp1.Properties.Resources.BreastplateBase;
                            break;
                        case 2:
                            button3.BackgroundImage = WindowsFormsApp1.Properties.Resources.BootsBase;
                            break;
                    }
                if (Table.Slot3 is HealCard)
                    button3.BackgroundImage = WindowsFormsApp1.Properties.Resources.HealBase;
            }

            if (Table.Slot4 == null)
            {
                button4.Text = null;
                button4.BackgroundImage = WindowsFormsApp1.Properties.Resources.Emty;
            }
            else
            {
                button4.Text = Table.Slot4.Characteristics;
                if (Table.Slot4 is EnemyCard)
                {
                    button4.BackgroundImage = WindowsFormsApp1.Properties.Resources.Enemy;
                }
                if (Table.Slot4 is WeaponCard)
                    button4.BackgroundImage = WindowsFormsApp1.Properties.Resources.WeaponBase;
                if (Table.Slot4 is ArmorCard armor)
                    switch ((int)armor.Type)
                    {
                        case 0:
                            button4.BackgroundImage = WindowsFormsApp1.Properties.Resources.HelmetBase;
                            break;
                        case 1:
                            button4.BackgroundImage = WindowsFormsApp1.Properties.Resources.BreastplateBase;
                            break;
                        case 2:
                            button4.BackgroundImage = WindowsFormsApp1.Properties.Resources.BootsBase;
                            break;
                    }
                if (Table.Slot4 is HealCard)
                    button4.BackgroundImage = WindowsFormsApp1.Properties.Resources.HealBase;
            }

            if (Table.Slot5 == null)
            {
                button5.Text = null;
                button5.BackgroundImage = WindowsFormsApp1.Properties.Resources.Emty;
            }
            else
            {
                button5.Text = Table.Slot5.Characteristics;
                if (Table.Slot5 is EnemyCard)
                {
                    button5.BackgroundImage = WindowsFormsApp1.Properties.Resources.Enemy;
                }
                if (Table.Slot5 is WeaponCard)
                    button5.BackgroundImage = WindowsFormsApp1.Properties.Resources.WeaponBase;
                if (Table.Slot5 is ArmorCard armor)
                    switch ((int)armor.Type)
                    {
                        case 0:
                            button5.BackgroundImage = WindowsFormsApp1.Properties.Resources.HelmetBase;
                            break;
                        case 1:
                            button5.BackgroundImage = WindowsFormsApp1.Properties.Resources.BreastplateBase;
                            break;
                        case 2:
                            button5.BackgroundImage = WindowsFormsApp1.Properties.Resources.BootsBase;
                            break;
                    }
                if (Table.Slot5 is HealCard)
                    button5.BackgroundImage = WindowsFormsApp1.Properties.Resources.HealBase;
            }

            if (Table.Slot6 == null)
            {
                button6.Text = null;
                button6.BackgroundImage = WindowsFormsApp1.Properties.Resources.Emty;
            }
            else
            {
                button6.Text = Table.Slot6.Characteristics;
                if (Table.Slot6 is EnemyCard)
                {
                    button6.BackgroundImage = WindowsFormsApp1.Properties.Resources.Enemy;
                }
                if (Table.Slot6 is WeaponCard)
                    button6.BackgroundImage = WindowsFormsApp1.Properties.Resources.WeaponBase;
                if (Table.Slot6 is ArmorCard armor)
                    switch ((int)armor.Type)
                    {
                        case 0:
                            button6.BackgroundImage = WindowsFormsApp1.Properties.Resources.HelmetBase;
                            break;
                        case 1:
                            button6.BackgroundImage = WindowsFormsApp1.Properties.Resources.BreastplateBase;
                            break;
                        case 2:
                            button6.BackgroundImage = WindowsFormsApp1.Properties.Resources.BootsBase;
                            break;
                    }
                if (Table.Slot6 is HealCard)
                    button6.BackgroundImage = WindowsFormsApp1.Properties.Resources.HealBase;
            }
        }
    }
}
