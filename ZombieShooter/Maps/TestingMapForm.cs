using System;
using ZombieShooter.Properties;
using ZombieShooter.Guns;

namespace ZombieShooter.Maps
{
    public partial class TestingMapForm : Form
    {
        private Player1 player;
        private string playerName;
        private int player1HealthRegenMulti = 1;
        private double player1DamageMulti = 1;
        private double player1ReloadSpeedMulti = 1;
        private int player1HealthBoost = 0;
        private int player1FireRateMulti = 1;
        private int player1StaminaMulti = 1;

        // gun stats
        M1911 M1911gun = new M1911();
        M14 M14gun = new M14();

        private Gun primaryGun;
        private Gun secondaryGun;
        private Gun tertiaryGun;
        private Gun currentGun;

        private int secondaryGunAmmo;
        private int tertiaryGunAmmo;

        // misc
        Font font = new Font("Agency FB", 18, FontStyle.Regular, GraphicsUnit.Pixel);
        Point lastKilledZombieLocation;
        string facing = "up";
        bool moveUp, moveDown, moveLeft, moveRight, reloading;
        bool gameOver;
        int player1Health = 200;
        double zombieHealth = 100;
        public int player1Score = 0;
        int speedPlayer = 6, speedZombie = 1;
        int speedPlayerWalk = 6;
        int speedPlayerSprint = 10;
        bool isSprinting = false;
        private int playerStamina = 100;
        private Image currentGunImageUp = null;
        private Image currentGunImageRight = null;
        private Image currentGunImageDown = null;
        private Image currentGunImageLeft = null;
        private Image playerGun1ImageUp = Resources.playerM1911Up;
        private Image playerGun1ImageRight = Resources.playerM1911Right;
        private Image playerGun1ImageDown = Resources.playerM1911Down;
        private Image playerGun1ImageLeft = Resources.playerM1911Left;
        private Image playerGun2ImageUp = null;
        private Image playerGun2ImageRight = null;
        private Image playerGun2ImageDown = null;
        private Image playerGun2ImageLeft = null;
        private Image playerGun3ImageUp = null;
        private Image playerGun3ImageRight = null;
        private Image playerGun3ImageDown = null;
        private Image playerGun3ImageLeft = null;
        Random rnd = new Random();

        // zombies and rounds

        private int zombieSpawnCount = 0;
        private int zombieSpawnCountRound = 3;


        // shooting and gun shit
        bool shootingGun = false;

        String buyableString = "Press F to buy ";

        private System.Windows.Forms.Timer speedyBootsTimer;
        private System.Windows.Forms.Timer doublePointsTimer;
        private System.Windows.Forms.Timer instaKillTimer;
        private System.Windows.Forms.Timer zombieBloodTimer;
        private System.Windows.Forms.Timer infiniteAmmoTimer;
        private System.Windows.Forms.Timer stopTimeTimer;


        // perks
        bool muleKick = false;
        bool speedcola = false;


        // power ups

        public static bool instaKillActive = false;

        private Point nukePowerUpLocation;
        private System.Windows.Forms.Timer nukeFlickerTimer;
        private bool nukeFlickerPhase = false;
        private int nukeFlickerTime = 0;
        private PictureBox nukeExplosion;

        // score stuff
        int scoreWhenHit = 10;
        int scoreWhenKilled = 100;
        int nukeScore = 400;

        // current gun stats
        private bool canShoot = true;

        // regeneration
        int timeSinceLastRegen = 0;

        // lists
        List<PictureBox> zombieList = new List<PictureBox>();
        Dictionary<PictureBox, double> zombieHealthList = new Dictionary<PictureBox, double>();
        List<PictureBox> collidables = new List<PictureBox>();
        List<PictureBox> zombieCollidables = new List<PictureBox>();
        List<Panel> buyables = new List<Panel>();

        // Syncing between maps
        System.Windows.Forms.Timer GameTimer = new System.Windows.Forms.Timer
        {
            Interval = 20,
            Enabled = true
        };
        public PictureBox player1 = new PictureBox
        {
            Location = new Point(639, 294),
            Size = new Size(75, 75),
            SizeMode = PictureBoxSizeMode.StretchImage,
            Image = Resources.playerM1911Up,
            Visible = true,
            Enabled = true,
            Tag = "player1",
        };
        System.Windows.Forms.Timer ReloadTimer = new System.Windows.Forms.Timer
        {
            Enabled = false,
        };
        System.Windows.Forms.Timer RateOfFireTimer = new System.Windows.Forms.Timer
        {
            Enabled = false,
        };
        System.Windows.Forms.Timer NukeExplosionTimer = new System.Windows.Forms.Timer
        {
            Enabled = false,
            Interval = 3000,
        };
        System.Windows.Forms.Timer HealthRegenTimer = new System.Windows.Forms.Timer
        {
            Enabled = false,
            Interval = 4000,
        };
        System.Windows.Forms.Timer staminaConsumptionTimer = new System.Windows.Forms.Timer
        {
            Enabled = false,
            Interval = 100,
        };
        System.Windows.Forms.Timer staminaRegenerationTimer = new System.Windows.Forms.Timer
        {
            Enabled = false,
            Interval = 100,
        };



        public TestingMapForm(Player1 player)
        {
            this.player = player;
            playerName = player.Name;

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            InitializeComponent();
            InitializeCollisions();
            InitializeBuyables();

            primaryGun = M1911gun;
            currentGun = primaryGun;
            currentGunImageUp = primaryGun.imageUp;
            currentGunImageDown = primaryGun.imageDown;
            currentGunImageLeft = primaryGun.imageLeft;
            currentGunImageRight = primaryGun.imageRight;
            gunNameLabel.Text = currentGun.Name;

            // syncing
            GameTimer.Start();
            GameTimer.Tick += MainTimerEvent;
            this.Controls.Add(player1);
            this.Controls.Add(player1AmmoLabel);
            ReloadTimer.Tick += ReloadTimer_Tick;
            NukeExplosionTimer.Tick += NukeExplosionTimer_Tick;
            HealthRegenTimer.Tick += HealthRegenTimer_Tick;
            this.KeyDown += KeyIsDown;
            this.KeyUp += KeyIsUp;
            player1AmmoLabel.BringToFront();
            player1HealthBar.BringToFront();
            player1ScoreLabel.BringToFront();
            //
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;

            RestartGame();
            HealthRegenTimer.Start();
            Sounds sounds = new Sounds();

            lastKilledZombieLocation = new Point(-1, -1);

            RateOfFireTimer.Interval = currentGun.FireRate;
            RateOfFireTimer.Tick += (sender, e) => canShoot = true;

            ReloadTimer.Interval = (int)currentGun.ReloadSpeed;

            doublePointsTimer = new System.Windows.Forms.Timer();
            doublePointsTimer.Interval = 30000;
            doublePointsTimer.Tick += DoublePointsTimer_Tick;

            instaKillTimer = new System.Windows.Forms.Timer();
            instaKillTimer.Interval = 30000;
            instaKillTimer.Tick += InstaKillTimer_Tick;

            nukeFlickerTimer = new System.Windows.Forms.Timer();
            nukeFlickerTimer.Interval = 100;
            nukeFlickerTimer.Tick += NukeFlickerTimer_Tick;
        }

        private void InitializeCollisions()
        {
            collidables.Add(woodCrate1);
        }

        private void InitializeBuyables()
        {
            buyables.Add(m14WallBuy);
            buyables.Add(brewPerk1Buy);
            buyables.Add(colaPerk2Buy);
            buyables.Add(fizzPerk3Buy);
            buyables.Add(popPerk4Buy);
            buyables.Add(elixirPerkBuy);
        }
        private void InstaKillTimer_Tick(object sender, EventArgs e)
        {
            instaKillActive = false;
            instaKillTimer.Stop();
        }

        private void DoublePointsTimer_Tick(object sender, EventArgs e)
        {
            scoreWhenHit = 10;
            scoreWhenKilled = 100;
            nukeScore = 400;
            doublePointsTimer.Stop();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            CheckLevel();

            RateOfFireTimer.Interval = currentGun.FireRate / player1FireRateMulti;

            double newReloadSpeed = currentGun.ReloadSpeed / player1ReloadSpeedMulti;

            ReloadTimer.Interval = (int)newReloadSpeed;

            buyingLabel.BringToFront();

            staminaBar.Location = new Point(player1.Left + player1.Width / 2 - staminaBar.Width / 2, player1.Bottom + 5);
            player1AmmoLabel.Text = currentGun.Ammo.ToString();
            player1ScoreLabel.Text = player1Score.ToString();

            if (player1Health > 1)
            {
                player1HealthBar.Value = player1Health;
            }
            else
            {
                gameOver = true;
                GameTimer.Stop();
                ReloadTimer.Stop();
                HealthRegenTimer.Stop();
            }
            if (moveLeft == true && player1.Left > 0)
            {
                player1.Left -= speedPlayer;
            }
            if (moveRight == true && player1.Left + player1.Width < this.ClientSize.Width)
            {
                player1.Left += speedPlayer;
            }
            if (moveUp == true && player1.Top > 0)
            {
                player1.Top -= speedPlayer;
            }
            if (moveDown == true && player1.Top + player1.Height < this.ClientSize.Height)
            {
                player1.Top += speedPlayer;
            }
            if (shootingGun == true)
            {
                currentGun.Shoot(this, currentGun.Magazine, currentGun.Ammo, facing, player1.Left, player1.Top, player);
            }
            if (isSprinting)
            {
                if (playerStamina > 0)
                {
                    playerStamina -= 3;
                    UpdateStamina();
                    speedPlayer = speedPlayerSprint;
                }
                else
                {
                    isSprinting = false;
                    staminaConsumptionTimer.Stop();
                    speedPlayer = speedPlayerWalk;
                    playerStamina = 0;
                }
            }

            HandleZombies();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && ((string)x.Tag == "player1"))
                {
                    foreach (PictureBox collidablee in collidables)
                    {
                        if (x.Bounds.IntersectsWith(collidablee.Bounds))
                        {
                            int xOffset = 0;
                            int yOffset = 0;
                            if (x.Left < collidablee.Left)
                            {
                                xOffset = -8;
                                moveRight = false;
                            }
                            else if (x.Left > collidablee.Left)
                            {
                                xOffset = 8;
                                moveLeft = false;
                            }

                            if (x.Top < collidablee.Top)
                            {
                                yOffset = -8;
                                moveDown = false;
                            }
                            else if (x.Top > collidablee.Top)
                            {
                                yOffset = 8;
                                moveUp = false;
                            }

                            x.Left += xOffset;
                            x.Top += yOffset;
                        }
                    }
                    foreach (PictureBox zombieCollidable in collidables)
                    {
                        if (x.Bounds.IntersectsWith(zombieCollidable.Bounds))
                        {
                            int xOffset = 0;
                            int yOffset = 0;
                            if (x.Left < zombieCollidable.Left)
                            {
                                xOffset = -8;
                                player1Health -= 2;
                                moveRight = false;
                            }
                            else if (x.Left > zombieCollidable.Left)
                            {
                                xOffset = 8;
                                player1Health -= 2;
                                moveLeft = false;
                            }

                            if (x.Top < zombieCollidable.Top)
                            {
                                yOffset = -8;
                                player1Health -= 2;
                                moveDown = false;
                            }
                            else if (x.Top > zombieCollidable.Top)
                            {
                                yOffset = 8;
                                player1Health -= 2;
                                moveUp = false;
                            }

                            x.Left += xOffset;
                            x.Top += yOffset;
                        }
                    }
                }
                if (x is PictureBox && ((string)x.Tag == "ammo" || (string)x.Tag == "nuke" || (string)x.Tag == "doublepoints" || (string)x.Tag == "instakill"))
                {
                    if (player1.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();

                        Sounds.PlayPowerUpPickUpSound();

                        if ((string)x.Tag == "ammo")
                        {
                            Sounds.PlayMaxAmmoSound();
                            primaryGun.Ammo = primaryGun.TotalAmmo;
                            primaryGun.Magazine = primaryGun.MagazineSize;
                            if (secondaryGun != null)
                            {
                                secondaryGun.Ammo = secondaryGun.TotalAmmo;
                                secondaryGun.Magazine = secondaryGun.MagazineSize;
                            }
                            if (tertiaryGun != null)
                            {
                                tertiaryGun.Ammo = tertiaryGun.TotalAmmo;
                                tertiaryGun.Magazine = tertiaryGun.MagazineSize;
                            }
                        }
                        else if ((string)x.Tag == "nuke")
                        {
                            nukePowerUpLocation = x.Location;
                            Sounds.PlayNukeStartSound();
                            Sounds.PlayNukeSound();

                            this.Controls.Remove(nukeExplosion);
                            nukeExplosion = new PictureBox();
                            nukeExplosion.Image = Resources.nukeExplosion;
                            nukeExplosion.SizeMode = PictureBoxSizeMode.AutoSize;
                            nukeExplosion.Location = nukePowerUpLocation;
                            this.Controls.Add(nukeExplosion);

                            nukeExplosion.Visible = true;

                            nukeExplosion.BringToFront();
                            player1.BringToFront();
                            foreach (var zombies in zombieList)
                            {
                                zombies.BringToFront();
                            }

                            NukeExplosionTimer.Start();

                            List<PictureBox> zombiesToRemove = new List<PictureBox>();

                            foreach (var zombie in zombieList)
                            {
                                CreateBloodMark(zombie.Left, zombie.Top);
                                zombiesToRemove.Add(zombie);
                            }

                            System.Windows.Forms.Timer zombieRemovalTimer = new System.Windows.Forms.Timer();
                            zombieRemovalTimer.Interval = 500;
                            int remainingZombies = zombiesToRemove.Count;

                            zombieRemovalTimer.Tick += (sender, e) =>
                            {
                                if (zombiesToRemove.Count > 0)
                                {
                                    var zombie = zombiesToRemove[0];
                                    this.Controls.Remove(zombie);
                                    zombie.Dispose();
                                    zombieList.Remove(zombie);
                                    zombieCollidables.Remove(zombie);
                                    zombieHealthList.Remove(zombie);
                                    zombiesToRemove.RemoveAt(0);
                                    Sounds.PlayNukeDieSound();
                                    zombieSpawnCount--;
                                }
                                else
                                {
                                    zombieRemovalTimer.Stop();

                                    if (zombieList.Count == 0)
                                    {
                                        while (zombieSpawnCount < zombieSpawnCountRound)
                                        {
                                            SpawnZombies();
                                            zombieSpawnCount++;
                                        }
                                        player1Score += nukeScore;
                                    }
                                }
                            };

                            zombieRemovalTimer.Start();
                        }

                        else if ((string)x.Tag == "doublepoints")
                        {
                            Sounds.PlayDoublePointsSound();

                            scoreWhenHit = 20;
                            scoreWhenKilled = 200;
                            nukeScore = 800;

                            if (!doublePointsTimer.Enabled)
                            {
                                doublePointsTimer.Start();
                            }
                            else
                            {
                                doublePointsTimer.Stop();
                                doublePointsTimer.Start();
                            }
                        }
                        else if ((string)x.Tag == "instakill")
                        {
                            Sounds.PlayInstaKillSound();

                            while (instaKillActive == true)
                            {
                                Sounds.PlayInstaKillSoundLinger();

                                if (!instaKillTimer.Enabled)
                                {
                                    instaKillTimer.Start();
                                }
                                else
                                {
                                    instaKillTimer.Stop();
                                    instaKillTimer.Start();
                                }
                            }
                        }
                    }
                }

                if (x is PictureBox && (string)x.Tag == "player1")
                {
                    bool intersects = false;

                    foreach (Panel buyable in buyables)
                    {
                        if (x.Bounds.IntersectsWith(buyable.Bounds))
                        {
                            intersects = true;
                            DisplayPurchasePanel(buyable);
                        }
                    }

                    if (!intersects)
                    {
                        buyingLabel.Visible = false;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombieFrogs")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            player1Score += scoreWhenHit;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            double health;
                            if (zombieHealthList.TryGetValue((PictureBox)x, out health))
                            {
                                health -= currentGun.Damage * player1DamageMulti;
                                zombieHealthList[(PictureBox)x] = health;
                            }
                        }
                    }
                }
            }
        }

        private bool IsColliding(PictureBox box1, PictureBox box2)
        {
            return box1.Bounds.IntersectsWith(box2.Bounds);
        }
        private bool IsPlayerCollidingWithZombie(PictureBox player, PictureBox zombie)
        {
            return IsColliding(player, zombie);
        }
        private void RateOfFireTimerEvent(object sender, EventArgs e)
        {
            RateOfFireTimer.Stop();
        }
        private void RegenerateStamina()
        {
            staminaRegenerationTimer.Tick += (sender, e) =>
            {
                if (playerStamina < staminaBar.Maximum)
                {
                    playerStamina += 2;
                    UpdateStamina();
                }
                else if (playerStamina > staminaBar.Maximum)
                {
                    playerStamina = staminaBar.Maximum;
                }
            };
            staminaRegenerationTimer.Start();
        }
        private void Reload()
        {
            player1AmmoLabel.Visible = false;
            labelReloading.Visible = true;
            reloading = true;
            ReloadTimer.Start();
            if (currentGun.Ammo > 0 && currentGun.Magazine < currentGun.MagazineSize)
            {
                int bulletsToReload = currentGun.MagazineSize - currentGun.Magazine;
                if (bulletsToReload > currentGun.Ammo)
                {
                    bulletsToReload = currentGun.Ammo;
                }

                currentGun.Ammo -= bulletsToReload;
                currentGun.Magazine += bulletsToReload;
            }
        }
        private async void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }
            if (e.KeyCode == Keys.W)
            {
                facing = "up";
                moveUp = true;
                player1.Image = currentGunImageUp;
            }
            if (e.KeyCode == Keys.A)
            {
                facing = "left";
                moveLeft = true;
                player1.Image = currentGunImageLeft;
            }
            if (e.KeyCode == Keys.S)
            {
                facing = "down";
                moveDown = true;
                player1.Image = currentGunImageDown;
            }
            if (e.KeyCode == Keys.D)
            {
                facing = "right";
                moveRight = true;
                player1.Image = currentGunImageRight;
            }
            if (e.KeyCode == Keys.R && currentGun.Magazine < currentGun.MagazineSize && currentGun.Ammo > 0 && !reloading)
            {
                currentGun.Reload(this, speedcola);
                Reload();
            }
            if (e.KeyCode == Keys.ShiftKey)
            {
                isSprinting = true;
                staminaRegenerationTimer.Stop();
            }
            if (e.KeyCode == Keys.J)
            {
                CHEATMENU cheatmenu = new CHEATMENU(this, player);
                cheatmenu.Show();
            }
        }
        private async void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                moveUp = false;
            }
            if (e.KeyCode == Keys.A)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.S)
            {
                moveDown = false;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
            if (e.KeyCode == Keys.ShiftKey)
            {
                isSprinting = false;
                staminaConsumptionTimer.Stop();
                RegenerateStamina();
                speedPlayer = speedPlayerWalk;
            }
            if (e.KeyCode == Keys.E)
            {
                Sounds.PlayMeleeSound();
            }
            if (e.KeyCode == Keys.D2 && currentGun != secondaryGun && secondaryGun != null && !reloading)
            {
                SwitchToSecondaryGun();
            }
            if (e.KeyCode == Keys.D1 && currentGun != primaryGun && primaryGun != null && !reloading)
            {
                SwitchToPrimaryGun();
            }
            if (e.KeyCode == Keys.F)
            {
                BuyStuff();
            }
        }
        private void ApplyPerkBuffs(Perks perk)
        {
            if (perk is Juggernog)
            {
                player1HealthBar.Maximum = 250;
                player1Health += ((Juggernog)perk).HealthBonus;
            }
            else if (perk is QuickRevive)
            {
                player1HealthRegenMulti += ((QuickRevive)perk).HealthRegen;
            }
            else if (perk is SpeedCola)
            {
                speedcola = true;
                player1ReloadSpeedMulti += ((SpeedCola)perk).ReloadSpeedMultiplierBonus;
            }
            else if (perk is DoubleTap2)
            {
                player1DamageMulti += ((DoubleTap2)perk).DamageMultiplierBonus;
            }
            else if (perk is StaminUp)
            {
                player1StaminaMulti += ((StaminUp)perk).StaminaMultiplierBonus;
                playerStamina *= player1StaminaMulti;
                staminaBar.Maximum *= player1StaminaMulti;
            }
        }
        private void BuyStuff()
        {
            foreach (Panel buyable in buyables)
            {
                if (player1.Bounds.IntersectsWith(buyable.Bounds))
                {
                    switch (buyable.Name)
                    {
                        case "m14WallBuy":
                            int m14Cost = 500;
                            if (player1Score >= m14Cost)
                            {
                                player1Score -= m14Cost;
                                GiveWeaponToPlayer(M14gun);
                            }
                            break;
                        case "brewPerk1Buy":
                            if (player.perk1 != null && player1Score >= player.perk1.Cost)
                            {
                                player1Score -= player.perk1.Cost;
                                Perk1Image.BackgroundImage = player.perk1.perkIcon;
                                ApplyPerkBuffs(player.perk1);
                            }
                            break;
                        case "colaPerk2Buy":
                            if (player.perk2 != null && player1Score >= player.perk2.Cost)
                            {
                                player1Score -= player.perk2.Cost;
                                Perk2Image.BackgroundImage = player.perk2.perkIcon;
                                ApplyPerkBuffs(player.perk2);
                            }
                            break;
                        case "fizzPerk3Buy":
                            if (player.perk3 != null && player1Score >= player.perk3.Cost)
                            {
                                player1Score -= player.perk3.Cost;
                                Perk3Image.BackgroundImage = player.perk3.perkIcon;
                                ApplyPerkBuffs(player.perk3);
                            }
                            break;
                        case "popPerk4Buy":
                            if (player.perk4 != null && player1Score >= player.perk4.Cost)
                            {
                                player1Score -= player.perk4.Cost;
                                Perk4Image.BackgroundImage = player.perk4.perkIcon;
                                ApplyPerkBuffs(player.perk4);
                            }
                            break;
                        case "elixirPerkBuy":
                            if (player1Score >= 1500)
                            {
                                player1Score -= 1500;
                                // make swag elixir perk wunderfidzz
                            }
                            break;
                        default:
                            Sounds.PlayWrongSound();
                            break;
                    }
                }
            }
        }
        private void SpawnZombies()
        {
            int randomZombie = rnd.Next(0, 20);

            if (randomZombie == 1)
            {
                PictureBox zombie = new PictureBox();
                zombie.Tag = "zombieFrogs";
                zombie.Image = Resources.zUp_frogs;
                zombie.Size = new Size(100, 100);

                int randomSpawnPoint = rnd.Next(1, 6);

                switch (randomSpawnPoint)
                {
                    case 1:
                        zombie.Location = zSpawnLocation1.Location;
                        break;
                    case 2:
                        zombie.Location = zSpawnLocation2.Location;
                        break;
                    case 3:
                        zombie.Location = zSpawnLocation3.Location;
                        break;
                    case 4:
                        zombie.Location = zSpawnLocation4.Location;
                        break;
                    case 5:
                        zombie.Location = zSpawnLocation5.Location;
                        break;
                    default:
                        break;
                }
                zombie.SizeMode = PictureBoxSizeMode.StretchImage;
                zombieList.Add(zombie);
                zombieCollidables.Add(zombie);
                zombieHealthList.Add(zombie, zombieHealth * 5);
                this.Controls.Add(zombie);
                zombie.BringToFront();
                player1.BringToFront();
            }
            else
            {
                PictureBox zombie = new PictureBox();
                zombie.Tag = "zombie";
                zombie.Image = Resources.zUp;
                zombie.Size = new Size(60, 60);

                int randomSpawnPoint = rnd.Next(1, 6);

                switch (randomSpawnPoint)
                {
                    case 1:
                        zombie.Location = zSpawnLocation1.Location;
                        break;
                    case 2:
                        zombie.Location = zSpawnLocation2.Location;
                        break;
                    case 3:
                        zombie.Location = zSpawnLocation3.Location;
                        break;
                    case 4:
                        zombie.Location = zSpawnLocation4.Location;
                        break;
                    case 5:
                        zombie.Location = zSpawnLocation5.Location;
                        break;
                    default:
                        break;
                }
                zombie.SizeMode = PictureBoxSizeMode.StretchImage;
                zombieList.Add(zombie);
                zombieCollidables.Add(zombie);
                zombieHealthList.Add(zombie, zombieHealth);
                this.Controls.Add(zombie);
                zombie.BringToFront();
                player1.BringToFront();
            }
        }

        private void RestartGame()
        {
            player1.Image = Resources.playerM1911Up;

            foreach (PictureBox i in zombieList)
            {
                this.Controls.Remove(i);
            }

            zombieList.Clear();
            zombieHealthList.Clear();

            while (zombieSpawnCount < zombieSpawnCountRound)
            {
                SpawnZombies();
                zombieSpawnCount++;
            }

            moveUp = false;
            moveDown = false;
            moveLeft = false;
            moveRight = false;

            player1Health = 200;
            player1Score = 500;
            primaryGun.Magazine = primaryGun.MagazineSize;
            primaryGun.Ammo = primaryGun.TotalAmmo;

            GameTimer.Start();
        }

        private void player1AmmoLabel_TextChanged(object sender, EventArgs e)
        {
            player1AmmoLabel.Text = currentGun.Magazine + "/" + currentGun.Ammo;
        }

        private void player1ScoreLabel_TextChanged(object sender, EventArgs e)
        {
            player1ScoreLabel.Text = playerName + ": " + player1Score.ToString();
        }

        private void DisplayPurchasePanel(Panel buyablePanel)
        {
            switch (buyablePanel.Name)
            {
                case "m14WallBuy":
                    buyingLabel.Visible = true;
                    buyingLabel.Text = buyableString + "M14 [Cost: 500]";
                    break;
                case "brewPerk1Buy":
                    if (player.perk1 != null)
                    {
                        buyingLabel.Visible = true;
                        buyingLabel.Text = $"{buyableString}{player.perk1.Name} [Cost: {player.perk1.Cost}]";
                    }
                    else
                    {
                        buyingLabel.Visible = false;
                    }
                    break;
                case "colaPerk2Buy":
                    if (player.perk2 != null)
                    {
                        buyingLabel.Visible = true;
                        buyingLabel.Text = $"{buyableString}{player.perk2.Name} [Cost: {player.perk2.Cost}]";
                    }
                    else
                    {
                        buyingLabel.Visible = false;
                    }
                    break;
                case "fizzPerk3Buy":
                    if (player.perk3 != null)
                    {
                        buyingLabel.Visible = true;
                        buyingLabel.Text = $"{buyableString}{player.perk3.Name} [Cost: {player.perk3.Cost}]";
                    }
                    else
                    {
                        buyingLabel.Visible = false;
                    }
                    break;
                case "popPerk4Buy":
                    if (player.perk4 != null)
                    {
                        buyingLabel.Visible = true;
                        buyingLabel.Text = $"{buyableString}{player.perk4.Name} [Cost: {player.perk4.Cost}]";
                    }
                    else
                    {
                        buyingLabel.Visible = false;
                    }
                    break;
                case "elixirPerkBuy":
                    buyingLabel.Visible = true;
                    buyingLabel.Text = buyableString;
                    break;
                default:
                    break;
            }
        }

        private void SwitchToPrimaryGun()
        {
            currentGun = primaryGun;
            gunNameLabel.Text = primaryGun.Name;
            currentGunImageUp = primaryGun.imageUp;
            currentGunImageDown = primaryGun.imageDown;
            currentGunImageLeft = primaryGun.imageLeft;
            currentGunImageRight = primaryGun.imageRight;
            currentGun.Ammo = primaryGun.Ammo;
            currentGun.Magazine = primaryGun.Magazine;
        }

        private void SwitchToSecondaryGun()
        {
            currentGun = secondaryGun;
            gunNameLabel.Text = secondaryGun.Name;
            currentGunImageUp = secondaryGun.imageUp;
            currentGunImageDown = secondaryGun.imageDown;
            currentGunImageLeft = secondaryGun.imageLeft;
            currentGunImageRight = secondaryGun.imageRight;
            currentGun.Ammo = secondaryGun.Ammo;
            currentGun.Magazine = secondaryGun.Magazine;
        }

        private void SwitchToTertiaryGun()
        {
            // dxo mule kick stuff
        }

        private void UpdateStamina()
        {
            if (playerStamina < 0)
            {
                playerStamina = 0;
                staminaBar.Value = playerStamina;
            }
            else if (playerStamina >= staminaBar.Maximum)
            {
                playerStamina = staminaBar.Maximum;
                staminaBar.Value = playerStamina;
            }
            else
            {
                staminaBar.Value = playerStamina;
            }
        }

        private void ReloadTimer_Tick(object sender, EventArgs e)
        {
            ReloadTimer.Stop();

            reloading = false;
            speedPlayer = speedPlayerWalk;
            player1AmmoLabel.Text = currentGun.Magazine + "/" + currentGun.Ammo;
            player1AmmoLabel.Visible = true;
            labelReloading.Visible = false;
        }

        private void HealthRegenTimer_Tick(object sender, EventArgs e)
        {
            HealthRegenTimer.Interval = 5000;
            HealthRegenTimer.Interval = HealthRegenTimer.Interval / player1HealthRegenMulti;
            if (player1Health < 200)
            {
                timeSinceLastRegen += HealthRegenTimer.Interval;

                if (timeSinceLastRegen >= 2000)
                {
                    player1Health += 50;
                    if (player1Health > 200)
                    {
                        player1Health = 200;
                        player1HealthBar.Value = player1Health;
                        timeSinceLastRegen = 0;
                    }
                }
            }
        }

        private void NukeExplosionTimer_Tick(object sender, EventArgs e)
        {
            NukeExplosionTimer.Stop();
            nukeFlickerTimer.Start();
            nukeFlickerPhase = false;
            nukeFlickerTime = 0;
        }

        private void NukeFlickerTimer_Tick(object sender, EventArgs e)
        {
            if (nukeExplosion != null)
            {
                nukeExplosion.Visible = !nukeExplosion.Visible;

                nukeFlickerTime += nukeFlickerTimer.Interval;

                if (nukeFlickerTime >= 2000)
                {
                    nukeFlickerTimer.Stop();
                    nukeExplosion.Visible = false;
                    this.Controls.Remove(nukeExplosion);
                    nukeExplosion.Dispose();
                }
                else if (nukeFlickerTime >= 3000 && !nukeFlickerPhase)
                {
                    nukeFlickerPhase = true;
                    nukeFlickerTime = 0;
                }
            }
        }

        private void CreateBloodMark(int x, int y)
        {
            if (player.performanceMode == true)
            {
                return;
            }

            PictureBox bloodMark = new PictureBox
            {
                Image = Resources.zombieDeadBlood,
                SizeMode = PictureBoxSizeMode.AutoSize,
                Location = new Point(x, y),
                Tag = "bloodmark"
            };

            this.Controls.Add(bloodMark);
            bloodMark.BringToFront();
            foreach (var zombie in zombieList)
            {
                zombie.BringToFront();
            }
            player1.BringToFront();

            System.Windows.Forms.Timer bloodMarkTimer = new System.Windows.Forms.Timer();
            bloodMarkTimer.Interval = 5000;
            bloodMarkTimer.Tick += (sender, e) =>
            {
                this.Controls.Remove(bloodMark);
                bloodMark.Dispose();
                bloodMarkTimer.Stop();
            };
            bloodMarkTimer.Start();
        }

        private void gunNameLabel_TextChanged(object sender, EventArgs e)
        {
            gunNameLabel.Text = currentGun.Name;
        }

        private void FormMouseClicked(object sender, MouseEventArgs e)
        {
            if (currentGun != null && !currentGun.Automatic && e.Button == MouseButtons.Left && !gameOver && !reloading && currentGun.Magazine > 0)
            {
                if (canShoot == true)
                {
                    currentGun.Shoot(this, currentGun.Magazine, currentGun.Ammo, facing, player1.Left, player1.Top, player);
                    canShoot = false;
                    RateOfFireTimer.Start();
                    currentGun.Magazine--;
                }
                else
                {
                    return;
                }
            }
            if (currentGun != null && !currentGun.Automatic && e.Button == MouseButtons.Left && !gameOver && !reloading && currentGun.Magazine == 0)
            {
                Sounds.PlayNoAmmoSound();
            }
        }

        private void GiveWeaponToPlayer(Gun gun)
        {
            if (primaryGun != null && secondaryGun == null && muleKick == false)
            {
                secondaryGun = gun;
                secondaryGun.Ammo = secondaryGun.TotalAmmo;
                secondaryGun.Magazine = secondaryGun.MagazineSize;
                playerGun2ImageUp = gun.imageUp;
                playerGun2ImageDown = gun.imageDown;
                playerGun2ImageLeft = gun.imageLeft;
                playerGun2ImageRight = gun.imageRight;
            }
            else if (primaryGun == null && secondaryGun != null && muleKick == false)
            {
                primaryGun = gun;
                primaryGun.Ammo = primaryGun.TotalAmmo;
                primaryGun.Magazine = primaryGun.MagazineSize;
                playerGun1ImageUp = gun.imageUp;
                playerGun1ImageDown = gun.imageDown;
                playerGun1ImageLeft = gun.imageLeft;
                playerGun1ImageRight = gun.imageRight;
            }
            else if (primaryGun != null && secondaryGun != null && tertiaryGun != null)
            {
                currentGun = gun;
                currentGun.Ammo = currentGun.TotalAmmo;
                currentGun.Magazine = currentGun.MagazineSize;
                currentGunImageUp = gun.imageUp;
                currentGunImageDown = gun.imageDown;
                currentGunImageLeft = gun.imageLeft;
                currentGunImageRight = gun.imageRight;
            }
        }

        private void CheckLevel()
        {
            if (player.Level == 60)
            {
                return;
            }
            else if (player.Experience >= playerXpBar.Maximum)
            {
                player.Level += 1;
                player.Experience = 0;
                playerXpBar.Value = 0;
                playerXpBar.Maximum *= 2;
            }
            else
            {
                playerXpBar.Value = player.Experience;
            }
        }

        private void HandleZombies()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    foreach (PictureBox zombie in zombieList.ToList())
                    {
                        if (x == zombie)
                        {
                            continue;
                        }

                        if (IsColliding(player1, zombie))
                        {
                            player1Health -= 2;
                        }

                        if (IsColliding(zombie, player1))
                        {
                            int xOffset = 0;
                            int yOffset = 0;

                            if (zombie.Left < player1.Left)
                            {
                                xOffset = -1;
                                player1Health -= 2;
                            }
                            else if (zombie.Left > player1.Left)
                            {
                                xOffset = 1;
                                player1Health -= 2;
                            }

                            if (zombie.Top < player1.Top)
                            {
                                yOffset = -1;
                                player1Health -= 2;
                            }
                            else if (zombie.Top > player1.Top)
                            {
                                yOffset = 1;
                                player1Health -= 2;
                            }

                            zombie.Left += xOffset;
                            zombie.Top += yOffset;
                            player1.Left -= xOffset;
                            player1.Top -= yOffset;
                        }

                        if (IsColliding((PictureBox)x, zombie))
                        {
                            int xOffset = 0;
                            int yOffset = 0;

                            if (x.Left < zombie.Left)
                            {
                                xOffset = -1;
                            }
                            else if (x.Left > zombie.Left)
                            {
                                xOffset = 1;
                            }

                            if (x.Top < zombie.Top)
                            {
                                yOffset = -1;
                            }
                            else if (x.Top > zombie.Top)
                            {

                            }

                            x.Left += xOffset;
                            x.Top += yOffset;
                            zombie.Left -= xOffset;
                            zombie.Top -= yOffset;
                        }

                        foreach (PictureBox collidablee in collidables)
                        {
                            if (x.Bounds.IntersectsWith(collidablee.Bounds))
                            {
                                int xOffset = 0;
                                int yOffset = 0;

                                if (x.Left < collidablee.Left)
                                {
                                    xOffset = -1;
                                }
                                if (x.Left > collidablee.Left)
                                {
                                    xOffset = 1;
                                }

                                if (x.Top < collidablee.Top)
                                {
                                    yOffset = -1;
                                }
                                if (x.Top > collidablee.Top)
                                {
                                    yOffset = 1;
                                }

                                x.Left += xOffset;
                                x.Top += yOffset;
                            }
                        }

                        double health;
                        if (zombieHealthList.TryGetValue((PictureBox)x, out health))
                        {
                            if (health <= 0)
                            {
                                Sounds.PlayZombieDeathSound();
                                player.Experience += 10;
                                zombieSpawnCount--;
                                player1Score += scoreWhenKilled;
                                CreateBloodMark(x.Left, x.Top);
                                lastKilledZombieLocation = new Point(x.Left, x.Top);
                                if (rnd.Next(0, 200) <= 1)
                                {
                                    DropPowerUp.DropAmmo(this, lastKilledZombieLocation.X, lastKilledZombieLocation.Y);
                                }
                                else if (rnd.Next(0, 200) <= 1)
                                {
                                    DropPowerUp.DropNuke(this, lastKilledZombieLocation.X, lastKilledZombieLocation.Y);
                                }
                                else if (rnd.Next(0, 200) <= 1)
                                {
                                    DropPowerUp.DropDoublePoints(this, lastKilledZombieLocation.X, lastKilledZombieLocation.Y);
                                }
                                else if (rnd.Next(0, 200) <= 1)
                                {
                                    DropPowerUp.DropInstaKill(this, lastKilledZombieLocation.X, lastKilledZombieLocation.Y);
                                }
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                zombieList.Remove((PictureBox)x);
                                zombieCollidables.Remove((PictureBox)x);
                                zombieHealthList.Remove((PictureBox)x);

                                while (zombieSpawnCount < zombieSpawnCountRound)
                                {
                                    SpawnZombies();
                                    zombieSpawnCount++;
                                }
                            }
                        }
                        if (x.Left > player1.Left)
                        {
                            if (!IsPlayerCollidingWithZombie(player1, zombie) && x.Enabled == true)
                            {
                                x.Left -= speedZombie;
                                ((PictureBox)x).Image = Resources.zLeft;
                            }
                        }
                        if (x.Left < player1.Left)
                        {
                            if (!IsPlayerCollidingWithZombie(player1, zombie) && x.Enabled == true)
                            {
                                x.Left += speedZombie;
                                ((PictureBox)x).Image = Resources.zRight;
                            }
                        }
                        if (x.Top < player1.Top)
                        {
                            if (!IsPlayerCollidingWithZombie(player1, zombie) && x.Enabled == true)
                            {
                                x.Top += speedZombie;
                                ((PictureBox)x).Image = Resources.zDown;
                            }
                        }
                        if (x.Top > player1.Top)
                        {
                            if (!IsPlayerCollidingWithZombie(player1, zombie) && x.Enabled == true)
                            {
                                x.Top -= speedZombie;
                                ((PictureBox)x).Image = Resources.zUp;
                            }
                        }
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            player1Score += scoreWhenHit;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            double health;
                            if (zombieHealthList.TryGetValue((PictureBox)x, out health))
                            {
                                health -= currentGun.Damage * player1DamageMulti;
                                zombieHealthList[(PictureBox)x] = health;
                            }
                        }
                    }
                }

                if (x is PictureBox && (string)x.Tag == "zombieFrogs")
                {
                    foreach (PictureBox zombie in zombieList.ToList())
                    {
                        if (x == zombie)
                        {
                            continue;
                        }

                        if (IsColliding(player1, zombie))
                        {
                            player1Health -= 2;
                        }

                        if (IsColliding(zombie, player1))
                        {
                            int xOffset = 0;
                            int yOffset = 0;

                            if (zombie.Left < player1.Left)
                            {
                                xOffset = -1;
                                player1Health -= 2;
                            }
                            else if (zombie.Left > player1.Left)
                            {
                                xOffset = 1;
                                player1Health -= 2;
                            }

                            if (zombie.Top < player1.Top)
                            {
                                yOffset = -1;
                                player1Health -= 2;
                            }
                            else if (zombie.Top > player1.Top)
                            {
                                yOffset = 1;
                                player1Health -= 2;
                            }

                            zombie.Left += xOffset;
                            zombie.Top += yOffset;
                            player1.Left -= xOffset;
                            player1.Top -= yOffset;
                        }

                        if (IsColliding((PictureBox)x, zombie))
                        {
                            int xOffset = 0;
                            int yOffset = 0;

                            if (x.Left < zombie.Left)
                            {
                                xOffset = -1;
                            }
                            else if (x.Left > zombie.Left)
                            {
                                xOffset = 1;
                            }

                            if (x.Top < zombie.Top)
                            {
                                yOffset = -1;
                            }
                            else if (x.Top > zombie.Top)
                            {

                            }

                            x.Left += xOffset;
                            x.Top += yOffset;
                            zombie.Left -= xOffset;
                            zombie.Top -= yOffset;
                        }

                        foreach (PictureBox collidablee in collidables)
                        {
                            if (x.Bounds.IntersectsWith(collidablee.Bounds))
                            {
                                int xOffset = 0;
                                int yOffset = 0;

                                if (x.Left < collidablee.Left)
                                {
                                    xOffset = -1;
                                }
                                if (x.Left > collidablee.Left)
                                {
                                    xOffset = 1;
                                }

                                if (x.Top < collidablee.Top)
                                {
                                    yOffset = -1;
                                }
                                if (x.Top > collidablee.Top)
                                {
                                    yOffset = 1;
                                }

                                x.Left += xOffset;
                                x.Top += yOffset;
                            }
                        }

                        double health;
                        if (zombieHealthList.TryGetValue((PictureBox)x, out health))
                        {
                            if (health <= 0)
                            {
                                Sounds.PlayZombieDeathSound();
                                player.Experience += 100;
                                zombieSpawnCount--;
                                player1Score += scoreWhenKilled;
                                CreateBloodMark(x.Left, x.Top);
                                lastKilledZombieLocation = new Point(x.Left, x.Top);
                                DropPowerUp.DropAmmo(this, lastKilledZombieLocation.X, lastKilledZombieLocation.Y);
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                zombieList.Remove((PictureBox)x);
                                zombieCollidables.Remove((PictureBox)x);
                                zombieHealthList.Remove((PictureBox)x);

                                while (zombieSpawnCount < zombieSpawnCountRound)
                                {
                                    SpawnZombies();
                                    zombieSpawnCount++;
                                }
                            }
                        }
                        if (x.Left > player1.Left)
                        {
                            if (!IsPlayerCollidingWithZombie(player1, zombie) && x.Enabled == true)
                            {
                                x.Left -= speedZombie * 1;
                                ((PictureBox)x).Image = Resources.zLeft_frogs;
                            }
                        }
                        if (x.Left < player1.Left)
                        {
                            if (!IsPlayerCollidingWithZombie(player1, zombie) && x.Enabled == true)
                            {
                                x.Left += speedZombie * 1;
                                ((PictureBox)x).Image = Resources.zRight_frogs;
                            }
                        }
                        if (x.Top < player1.Top)
                        {
                            if (!IsPlayerCollidingWithZombie(player1, zombie) && x.Enabled == true)
                            {
                                x.Top += speedZombie * 1;
                                ((PictureBox)x).Image = Resources.zDown_frogs;
                            }
                        }
                        if (x.Top > player1.Top)
                        {
                            if (!IsPlayerCollidingWithZombie(player1, zombie) && x.Enabled == true)
                            {
                                x.Top -= speedZombie * 1;
                                ((PictureBox)x).Image = Resources.zUp_frogs;
                            }
                        }
                    }
                }
            }
        }
    }
}
