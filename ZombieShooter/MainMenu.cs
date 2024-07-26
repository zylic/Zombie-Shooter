using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZombieShooter.Maps;
using ZombieShooter.Properties;

namespace ZombieShooter
{
    public partial class MainMenu : Form
    {
        NewPlayer newPlayer;
        private string selectedMap = null;
        private CustomizeMenu customizeMenu;
        private Player1 playerOne;

        public MainMenu(Player1 player)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            playerOne = player; // Pass Player1 instance from Program.cs
            playerOne.NameChanged += () => player1NameLabel.Text = playerOne.Name;
            player1NameLabel.Text = playerOne.Name;
            customizeMenu = new CustomizeMenu(playerOne);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            playLabel.BackColor = Color.Transparent;
            mapLabel.BackColor = Color.Transparent;
            settingsLabel.BackColor = Color.Transparent;
            customizeLabel.BackColor = Color.Transparent;
            mainMenuLabel.BackColor = Color.Transparent;
            player1NameLabel.BackColor = Color.Transparent;
            infoLabel.BackColor = Color.Transparent;
            playLabel.Enabled = false;

            player1NameLabel.Text = playerOne.Name;

            Sounds.LobbyJoinSound();
            Sounds.PlayBackgroundMusic("Sounds\\mainMenuSongDamned.wav");

            customizeMenu.LoadSelectedPerks();

            newPlayer = new NewPlayer(playerOne);

            newPlayer.ShowDialog();
        }

        private void MainMenuEventTimer(object sender, EventArgs e)
        {
            player1NameLabel.Text = playerOne.Name;
        }


        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sounds.StopBackgroundMusic();
        }
        private void customLabel_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                label.ForeColor = Color.White;
            }
        }

        private void customLabel_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                label.ForeColor = Color.Orange;
                Sounds.NavigateMainMenuSound();
            }
        }

        private void mapLabel_Click(object sender, EventArgs e)
        {
            Sounds.NavigateMainMenuEnterSound();
            Sounds.ChangeScreenSound();
            MapSelection gameWindow = new MapSelection();
            gameWindow.MapSelected += (s, args) =>
            {
                selectedMap = args.SelectedMap;

                if (selectedMap == "testingMap")
                {
                    BackgroundImage = Resources.zombiesBackgroundImage;
                    mapBigPicture.Image = Resources.testingMapBigPicture;

                    if (!playLabel.Enabled)
                    {
                        playLabel.Enabled = true;
                    }
                }
                if (selectedMap == "originsMap")
                {
                    BackgroundImage = Resources.originsMapBackground;

                    if (!playLabel.Enabled)
                    {
                        playLabel.Enabled = true;
                    }
                }
            };

            if (gameWindow.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void playLabel_Click(object sender, EventArgs e)
        {
            Sounds.NavigateMainMenuEnterSound();
            Sounds.ChangeScreenSound();
            Sounds.StopBackgroundMusic();

            switch (selectedMap)
            {
                case "testingMap":

                    TestingMapForm testingMapForm = new TestingMapForm(playerOne);
                    testingMapForm.ShowDialog();
                    break;
                default:
                    break;

            }
        }

        private void infoLabel_Click(object sender, EventArgs e)
        {
            Sounds.NavigateMainMenuEnterSound();
            Sounds.ChangeScreenSound();
            HelpScreen helpScreen = new HelpScreen();
            helpScreen.ShowDialog();
        }

        private void customizeLabel_Click(object sender, EventArgs e)
        {
            Sounds.NavigateMainMenuEnterSound();
            Sounds.ChangeScreenSound();

            customizeMenu = new CustomizeMenu(playerOne);
            customizeMenu.mainMenu = this;

            customizeMenu.LoadSelectedPerks();

            customizeMenu.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerOne.SavePlayerData();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerOne.LoadPlayerData();
        }

        private void settingsLabel_Click(object sender, EventArgs e)
        {
            Sounds.NavigateMainMenuEnterSound();
            Sounds.ChangeScreenSound();
            SettingsMenu settingsMenu = new SettingsMenu(playerOne);
            settingsMenu.ShowDialog();
        }

        private void player1NameLabel_TextChanged(object sender, EventArgs e)
        {
            player1NameLabel.Text = playerOne.Name;
        }
    }
}
