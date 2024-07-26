using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieShooter
{
    public partial class SettingsMenu : Form
    {
        private Player1 player1;
        public SettingsMenu(Player1 player)
        {
            InitializeComponent();
            player1 = player;
            nameTextBox.PlaceholderText = player1.Name;

            if (player1.performanceMode == true)
            {
                checkBox_PerformanceMode.Checked = true;
            }
            else
            {
                checkBox_PerformanceMode.Checked = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Sounds.NavigateMainMenuBackoutSound();
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player1.ChangeName(nameTextBox.Text);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.SavePlayerData();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.LoadPlayerData();
        }

        private void checkBox_PerformanceMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_PerformanceMode.Checked == true) 
            {
                player1.performanceMode = true;
            }
            else
            {
                player1.performanceMode = false;
            }
        }
    }
}
