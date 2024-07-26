using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZombieShooter.Properties;

namespace ZombieShooter
{
    public partial class CustomizeMenu : Form
    {
        public string buttonClicked;
        Player1 player1;

        public MainMenu mainMenu { get; set; }

        public Juggernog juggernogPerk = new Juggernog();
        public StaminUp staminupPerk = new StaminUp();
        public QuickRevive quickrevivePerk = new QuickRevive();
        public SpeedCola speedcolaPerk = new SpeedCola();
        public DoubleTap2 doubletapPerk = new DoubleTap2();
        public WidowsWine widowsWinePerk = new WidowsWine();

        public List<Perks> AvailablePerks = new List<Perks>();
        public CustomizeMenu(Player1 player)
        {
            InitializeComponent();

            AvailablePerks.Add(juggernogPerk);
            AvailablePerks.Add(doubletapPerk);
            AvailablePerks.Add(staminupPerk);
            AvailablePerks.Add(quickrevivePerk);
            AvailablePerks.Add(speedcolaPerk);
            AvailablePerks.Add(widowsWinePerk);
            player1 = player;
        }

        public void SetPerk1Image(Image image)
        {
            perk1BrewImage.BackgroundImage = image;
        }

        public void SetPerk2Image(Image image)
        {
            perk2ColaImage.BackgroundImage= image;
        }

        public void SetPerk3Image(Image image)
        {
            perk3FizzImage.BackgroundImage = image;
        }

        public void SetPerk4Image(Image image)
        {
            perk4PopImage.BackgroundImage = image;
        }

        public void SetPerk1ButtonText(string text)
        {
            perk1BrewButton.Text = text;
        }

        public void SetPerk2ButtonText(string text)
        {
            perk2ColaButton.Text = text;
        }

        public void SetPerk3ButtonText(string text)
        {
            perk3FizzButton.Text = text;
        }

        public void SetPerk4ButtonText(string text)
        {
            perk4PopButton.Text = text;
        }

        public void LoadSelectedPerks()
        {
            perk1BrewImage.BackgroundImage = player1.perk1?.perkIcon ?? Resources.HUDplayerperk;
            perk2ColaImage.BackgroundImage = player1.perk2?.perkIcon ?? Resources.HUDplayerperk;
            perk3FizzImage.BackgroundImage = player1.perk3?.perkIcon ?? Resources.HUDplayerperk;
            perk4PopImage.BackgroundImage = player1.perk4?.perkIcon ?? Resources.HUDplayerperk;

            perk1BrewButton.Text = player1.perk1?.Name ?? "None";
            perk2ColaButton.Text = player1.perk2?.Name ?? "None";
            perk3FizzButton.Text = player1.perk3?.Name ?? "None";
            perk4PopButton.Text = player1.perk4?.Name ?? "None";
        }

        private void customLabel_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.ForeColor = Color.White;
            }
        }

        private void customLabel_MouseHover(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.ForeColor = Color.Orange;
                Sounds.NavigateMainMenuSound();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Sounds.NavigateMainMenuBackoutSound();
            Sounds.ChangeScreenSound();
            MainMenu mainMenu = new MainMenu(player1);
            this.Close();
            this.Dispose();
        }

        private void perk1BrewButton_Click(object sender, EventArgs e)
        {
            buttonClicked = "perk1";
            PerkSelection perkSelection = new PerkSelection(this, mainMenu, player1);
            perkSelection.ShowDialog();
        }

        private void perk2ColaButton_Click(object sender, EventArgs e)
        {
            buttonClicked = "perk2";
            PerkSelection perkSelection = new PerkSelection(this, mainMenu, player1);
            perkSelection.ShowDialog();
        }

        private void perk3FizzButton_Click(object sender, EventArgs e)
        {
            buttonClicked = "perk3";
            PerkSelection perkSelection = new PerkSelection(this, mainMenu, player1);
            perkSelection.ShowDialog();
        } 

        private void perk4PopButton_Click(object sender, EventArgs e)
        {
            buttonClicked = "perk4";
            PerkSelection perkSelection = new PerkSelection(this, mainMenu, player1);
            perkSelection.ShowDialog();
        }
    }
}
