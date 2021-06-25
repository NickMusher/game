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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var gameField = new GameFieldForm();
            gameField.Show();
            Hide();
        }

        private void ToRightButton_Click(object sender, EventArgs e)
        {
        }

        private void ToLeftButton_Click(object sender, EventArgs e)
        {
        }
    }
}
