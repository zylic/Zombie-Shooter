using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieShooter
{
    public partial class NewPlayer : Form
    {
        private Player1 player1;
        public NewPlayer(Player1 player)
        {
            InitializeComponent();
            button1.MouseHover += buttonHover;
            button2.MouseHover += buttonHover;
            button1.MouseLeave += buttonLeave;
            button2.MouseLeave += buttonLeave;

            player1 = player;
        }

        private void buttonHover(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.ForeColor = Color.Orange;
                Sounds.NavigateMainMenuSound();
            }
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.ForeColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerName = PromptForPlayerName();
            if (!string.IsNullOrWhiteSpace(playerName))
            {
                player1.ChangeName(playerName);
                player1.SavePlayerData();
                this.Close();
                this.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player1.LoadPlayerData();
            this.Close();
            this.Dispose();
        }

        private string PromptForPlayerName()
        {
            string playerName = "";

            playerName = Microsoft.VisualBasic.Interaction.InputBox("Enter your name:", "New Player", "");

            return playerName;
        }
    }
}
