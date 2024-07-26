using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZombieShooter.Maps;
using ZombieShooter.Properties;

namespace ZombieShooter.Guns
{
    internal class Gun
    {
        public string Name { get; set; } // Name of the gun
        public double Damage { get; set; } // Bullet damage
        public int FireRate { get; set; } // Fire rate in milliseconds
        public int Magazine { get; set; } // Magazine ammo
        public int MagazineSize { get; set; } // Magazine size
        public int Ammo { get; set; } // Total ammo count
        public int TotalAmmo { get; set; } // Current ammo count
        public double ReloadSpeed { get; set; } // Reload speed
        public bool Automatic { get; set; } // Automatic
        public Image imageUp { get; set; }
        public Image imageDown { get; set; }
        public Image imageLeft { get; set; }
        public Image imageRight { get; set; }


        public virtual void Shoot(Form form, int playerMag, int playerAmmo, string direction, int playerLeft, int playerTop, Player1 player)
        {

        }
        public virtual void Reload(Form form, bool speedcola)
        {

        }
    }
    internal class M1911 : Gun
    {
        public M1911()
        {
            Name = "M1911";
            Damage = 25;
            FireRate = 100;
            MagazineSize = 8;
            MagazineSize = 8;
            Ammo = 80;
            TotalAmmo = 80;
            ReloadSpeed = 2000;
            Automatic = false;

            imageUp = Resources.playerM1911Up;
            imageDown = Resources.playerM1911Down;
            imageLeft = Resources.playerM1911Left;
            imageRight = Resources.playerM1911Right;
        }

        public override void Shoot(Form form, int playerMag, int playerAmmo, string direction, int playerLeft, int playerTop, Player1 player)
        {
            if (playerMag > 0 && playerAmmo > 0)
            {
                var bullet = new Bullet(Damage, direction, playerLeft + 35, playerTop + 35);
                bullet.MakeBullet(form, player);
                Sounds.PlayM1911ShootSound();
            }
        }

        public override void Reload(Form form, bool s)
        {
            if (s)
            {
                Sounds.PlayM1911SpeedReloadSound();
            }
            else
            {
                Sounds.PlayM1911ReloadSound();
            }
        }
    }
    internal class M14 : Gun
    {
        public M14()
        {
            Name = "M14";
            Damage = 40;
            FireRate = 200;
            MagazineSize = 8;
            MagazineSize = 8;
            Ammo = 96;
            TotalAmmo = 96;
            ReloadSpeed = 2500;
            Automatic = false;

            imageUp = Resources.playerM14Up;
            imageDown = Resources.playerM14Down;
            imageLeft = Resources.playerM14Left;
            imageRight = Resources.playerM14Right;
        }

        public override void Shoot(Form form, int playerMag, int playerAmmo, string direction, int playerLeft, int playerTop, Player1 player)
        {
            if (playerMag > 0 && playerAmmo > 0)
            {
                var bullet = new Bullet(Damage, direction, playerLeft + 35, playerTop + 35);
                bullet.MakeBullet(form, player);
                Sounds.PlayM14ShootSound();
            }
        }

        public override void Reload(Form form, bool s)
        {
            if (s)
            {
                Sounds.PlayM14SpeedReloadSound();
            }
            else
            {
                Sounds.PlayM14ReloadSound();
            }
        }

    }
}
