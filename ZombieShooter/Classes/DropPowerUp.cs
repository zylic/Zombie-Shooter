using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.Runtime.InteropServices;
using ZombieShooter.Properties;
using System.Drawing.Imaging;
using ZombieShooter.Maps;

namespace ZombieShooter
{
    public class DropPowerUp
    {
        public static void DropThePowerUp(Form form, string tag, int x, int y)
        {
            PictureBox powerUp = new PictureBox();
            powerUp.SizeMode = PictureBoxSizeMode.AutoSize;
            powerUp.Tag = tag;
            powerUp.Left = x;
            powerUp.Top = y;

            switch (tag)
            {
                case "ammo":
                    powerUp.Image = Resources.maxAmmoPowerUp;
                    break;
                case "nuke":
                    powerUp.Image = Resources.nukePowerUp;
                    break;
                case "zombieblood":
                    powerUp.Image = Resources.zombieBloodPowerUp;
                    break;
                case "speedyboots":
                    powerUp.Image = Resources.speedyBootsPowerUp;
                    break;
                case "bonuspoints":
                    powerUp.Image = Resources.bonusPointsPowerUp;
                    break;
                case "doublepoints":
                    powerUp.Image = Resources.doublePointsPowerUp;
                    break;
                case "infiniteammo":
                    powerUp.Image = Resources.infiniteAmmoPowerUp;
                    break;
                case "instakill":
                    powerUp.Image = Resources.instaKillPowerUp;
                    break;
                case "perkbottle":
                    powerUp.Image = Resources.perkBottlePowerUp;
                    break;
                case "stopwatch":
                    powerUp.Image = Resources.stopTimePowerUp;
                    break;
                default:
                    break;
            }

            form.Controls.Add(powerUp);
            powerUp.BringToFront();

            if (form is TestingMapForm testingMapForm)
            {
                testingMapForm.player1.BringToFront();
            }      
        }
        public static void DropAmmo(Form form, int x, int y)
        {
            DropThePowerUp(form, "ammo", x, y);
        }

        public static void DropNuke(Form form, int x, int y)
        {
            DropThePowerUp(form, "nuke", x, y);
        }

        public static void DropZombieBlood(Form form, int x, int y)
        {
            DropThePowerUp(form, "zombieblood", x, y);
        }

        public static void DropSpeedyBoots(Form form, int x, int y)
        {
            DropThePowerUp(form, "speedyboots", x, y);
        }

        public static void DropBonusPoints(Form form, int x, int y)
        {
            DropThePowerUp(form, "bonuspoints", x, y);
        }

        public static void DropDoublePoints(Form form, int x, int y)
        {
            DropThePowerUp(form, "doublepoints", x, y);
        }

        public static void DropInfiniteAmmo(Form form, int x, int y)
        {
            DropThePowerUp(form, "infiniteammo", x, y);
        }

        public static void DropInstaKill(Form form, int x, int y)
        {
            DropThePowerUp(form, "instakill", x, y);
        }

        public static void DropPerkBottle(Form form, int x, int y)
        {
            DropThePowerUp(form, "perkbottle", x, y);
        }

        public static void DropStopWatch(Form form, int x, int y)
        {
            DropThePowerUp(form, "stopwatch", x, y);
        }
    }
}
