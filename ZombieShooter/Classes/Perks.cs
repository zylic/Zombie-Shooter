using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZombieShooter.Properties;

namespace ZombieShooter
{
    public class Perks
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public Image perkIcon { get; set; }
        public bool IsBought { get; set; }

        // Perk benefits
        public int HealthBonus { get; set; }
        public int HealthRegen { get; set; }
        public int ReviveSpeedBonus { get; set; }
        public bool SoloRevive { get; set; }
        public double ReloadSpeedMultiplierBonus { get; set; }
        public int StaminaMultiplierBonus { get; set; }
        public int DamageMultiplierBonus { get; set; }



        public Perks()
        {
            IsBought = false;
        }

        public virtual void PerkAction()
        {
            // Perk action
        }

    }

    public class Juggernog : Perks
    {
        public Juggernog()
        {
            // +50 Extra Health
            Name = "Juggernog";
            Cost = 2500;
            perkIcon = Resources.juggernogPerkIcon;

            HealthBonus = 50;
        }
    }
    public class QuickRevive : Perks
    {
        public QuickRevive()
        {
            // 2x Faster Health Regeneration, Revive Faster, Revive After Death When Solo

            Name = "Quick Revive";
            Cost = 500;
            perkIcon = Resources.quickRevivePerkIcon;

            HealthRegen = 1;
            ReviveSpeedBonus = 1;
            SoloRevive = true;
        }
    }
    public class SpeedCola : Perks
    {
        public SpeedCola()
        {
            // 2x Faster Reload
            Name = "Speed Cola";
            Cost = 3000;
            perkIcon = Resources.speedColaPerkIcon;

            ReloadSpeedMultiplierBonus = 1.33;
        }
    }
    public class StaminUp : Perks
    {
        public StaminUp()
        {
            // Triple Stamina
            Name = "Stamin-Up";
            Cost = 2000;
            perkIcon = Resources.staminUpPerkIcon;

            StaminaMultiplierBonus = 2;
        }
    }
    public class DoubleTap2 : Perks
    {
        public DoubleTap2()
        {
            // Double weapon damage
            Name = "Double Tap 2.0";
            Cost = 2000;
            perkIcon = Resources.doubleTapPerkICon;

            DamageMultiplierBonus = 1;
        }
    }

    public class WidowsWine : Perks
    {
        public WidowsWine()
        {
            // After getting damaged, Web all nearby zombies
            Name = "Widow's Wine";
            Cost = 4000;
            perkIcon = Resources.widowsWinePerkIcon;

            
        }

        public override void PerkAction()
        {
            // Widows wine perk action
        }

    }



}
