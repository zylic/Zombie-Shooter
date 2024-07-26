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
    public partial class PerkSelection : Form
    {
        private CustomizeMenu customizeMenu;
        private MainMenu mainMenu;
        private Player1 player;

        public PerkSelection(CustomizeMenu customizeMenu, MainMenu mainMenu, Player1 player1)
        {
            InitializeComponent();
            this.customizeMenu = customizeMenu;
            this.mainMenu = mainMenu;
            this.player = player1;
        }

        private void buttonPerk_Click(object sender, EventArgs e)
        {
            if (customizeMenu != null)
            {
                int selectedSlot = int.Parse(customizeMenu.buttonClicked.Substring("perk".Length)) - 1;

                if (selectedSlot >= 0 && selectedSlot <= 3)
                {
                    Perks selectedPerk = null;

                    if (sender == buttonQuickRevive)
                    {
                        selectedPerk = customizeMenu.quickrevivePerk;
                    }
                    else if (sender == buttonJuggernog)
                    {
                        selectedPerk = customizeMenu.juggernogPerk;
                    }
                    else if (sender == buttonDoubleTap2)
                    {
                        selectedPerk = customizeMenu.doubletapPerk;
                    }
                    else if (sender == buttonSpeedCola)
                    {
                        selectedPerk = customizeMenu.speedcolaPerk;
                    }
                    else if (sender == buttonStaminUp)
                    {
                        if (player.Level >= 3)
                        {
                            selectedPerk = customizeMenu.staminupPerk;
                        }
                        else
                        {
                            Sounds.PlayWrongSound();
                        }
                    }
                    else if (sender == buttonWidowsWine)
                    {
                        if (player.Level >= 5)
                        {
                            selectedPerk = customizeMenu.widowsWinePerk;
                        }
                        else
                        {
                            Sounds.PlayWrongSound();
                        }
                    }

                    if (selectedPerk != null)
                    {
                        if (selectedSlot == 0)
                        {
                            player.perk1 = selectedPerk;
                            customizeMenu.SetPerk1Image(selectedPerk.perkIcon);
                            customizeMenu.SetPerk1ButtonText(selectedPerk.Name);
                        }
                        else if (selectedSlot == 1)
                        {
                            player.perk2 = selectedPerk;
                            customizeMenu.SetPerk2Image(selectedPerk.perkIcon);
                            customizeMenu.SetPerk2ButtonText(selectedPerk.Name);
                        }
                        else if (selectedSlot == 2)
                        {
                            player.perk3 = selectedPerk;
                            customizeMenu.SetPerk3Image(selectedPerk.perkIcon);
                            customizeMenu.SetPerk3ButtonText(selectedPerk.Name);
                        }
                        else if (selectedSlot == 3)
                        {
                            player.perk4 = selectedPerk;
                            customizeMenu.SetPerk4Image(selectedPerk.perkIcon);
                            customizeMenu.SetPerk4ButtonText(selectedPerk.Name);
                        }
                    }
                }
                this.Close();
                this.Dispose();
            }
        }

        private void buttonPerk_Hover(object sender, EventArgs e)
        {
            string perkName = "";
            Image perkIcon = null;
            string perkDescription = "";
            int requiredLevel = 0;

            if (sender == buttonQuickRevive)
            {
                perkName = "Quick Revive";
                perkIcon = Resources.quickRevivePerkIcon;
                perkDescription = "2x Faster Health Regeneration, Revive Faster, Revive After Death When Solo";
                requiredLevel = 0;
            }
            else if (sender == buttonJuggernog)
            {
                perkName = "Juggernog";
                perkIcon = Resources.juggernogPerkIcon;
                perkDescription = "+50 health";
                requiredLevel = 0;
            }
            else if (sender == buttonDoubleTap2)
            {
                perkName = "Double Tap 2.0";
                perkIcon = Resources.doubleTapPerkICon;
                perkDescription = "2x Damage";
                requiredLevel = 0;
            }
            else if (sender == buttonSpeedCola)
            {
                perkName = "Speed Cola";
                perkIcon = Resources.speedColaPerkIcon;
                perkDescription = "33% Faster Reload";
                requiredLevel = 0;
            }
            else if (sender == buttonStaminUp)
            {
                perkName = "Stamin-Up";
                perkIcon = Resources.staminUpPerkIcon;
                perkDescription = "3x Stamina";
                requiredLevel = 3;
            }
            else if (sender == buttonWidowsWine)
            {
                perkName = "Widow's Wine";
                perkIcon = Resources.widowsWinePerkIcon;
                perkDescription = "When hit. Web zombie for 3 seconds";
                requiredLevel = 5;
            }

            PerkInfoImage.BackgroundImage = perkIcon;
            PerkInfoName.Text = perkName;
            PerkInfoDescription.Text = $"{perkDescription}\nRequired Level: {requiredLevel}";
        }
    }
}
