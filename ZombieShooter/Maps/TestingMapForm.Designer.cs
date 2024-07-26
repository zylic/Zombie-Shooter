namespace ZombieShooter.Maps
{
    partial class TestingMapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hudBox = new PictureBox();
            player1HealthBar = new ProgressBar();
            player1AmmoLabel = new Label();
            player1ScoreLabel = new Label();
            perk1Brew = new PictureBox();
            perk2Cola = new PictureBox();
            perk4Pop = new PictureBox();
            perk3Fizz = new PictureBox();
            perk5Elixir = new PictureBox();
            woodCrate1 = new PictureBox();
            m14Icon = new PictureBox();
            zSpawnLocation1 = new Panel();
            zSpawnLocation2 = new Panel();
            zSpawnLocation3 = new Panel();
            zSpawnLocation5 = new Panel();
            zSpawnLocation4 = new Panel();
            staminaBar = new ProgressBar();
            playerXpBar = new ProgressBar();
            gunNameLabel = new Label();
            m14WallBuy = new Panel();
            buyingLabel = new Label();
            brewPerk1Buy = new Panel();
            colaPerk2Buy = new Panel();
            fizzPerk3Buy = new Panel();
            popPerk4Buy = new Panel();
            elixirPerkBuy = new Panel();
            Perk1Image = new Panel();
            Perk2Image = new Panel();
            Perk3Image = new Panel();
            Perk4Image = new Panel();
            labelReloading = new Label();
            ((System.ComponentModel.ISupportInitialize)hudBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)perk1Brew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)perk2Cola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)perk4Pop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)perk3Fizz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)perk5Elixir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)woodCrate1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)m14Icon).BeginInit();
            m14WallBuy.SuspendLayout();
            brewPerk1Buy.SuspendLayout();
            colaPerk2Buy.SuspendLayout();
            fizzPerk3Buy.SuspendLayout();
            popPerk4Buy.SuspendLayout();
            elixirPerkBuy.SuspendLayout();
            SuspendLayout();
            // 
            // hudBox
            // 
            hudBox.BackColor = Color.Transparent;
            hudBox.BackgroundImage = Properties.Resources.HUD;
            hudBox.Location = new Point(-14, -38);
            hudBox.Name = "hudBox";
            hudBox.Size = new Size(1600, 900);
            hudBox.SizeMode = PictureBoxSizeMode.StretchImage;
            hudBox.TabIndex = 0;
            hudBox.TabStop = false;
            hudBox.MouseDown += FormMouseClicked;
            // 
            // player1HealthBar
            // 
            player1HealthBar.BackColor = Color.White;
            player1HealthBar.ForeColor = Color.FromArgb(192, 0, 0);
            player1HealthBar.Location = new Point(12, 814);
            player1HealthBar.Maximum = 200;
            player1HealthBar.Name = "player1HealthBar";
            player1HealthBar.Size = new Size(223, 22);
            player1HealthBar.TabIndex = 1;
            player1HealthBar.Value = 200;
            // 
            // player1AmmoLabel
            // 
            player1AmmoLabel.AutoSize = true;
            player1AmmoLabel.Font = new Font("Agency FB", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            player1AmmoLabel.ForeColor = Color.White;
            player1AmmoLabel.Location = new Point(1318, 762);
            player1AmmoLabel.Name = "player1AmmoLabel";
            player1AmmoLabel.RightToLeft = RightToLeft.Yes;
            player1AmmoLabel.Size = new Size(31, 40);
            player1AmmoLabel.TabIndex = 3;
            player1AmmoLabel.Text = "0";
            player1AmmoLabel.TextChanged += player1AmmoLabel_TextChanged;
            // 
            // player1ScoreLabel
            // 
            player1ScoreLabel.AutoSize = true;
            player1ScoreLabel.Font = new Font("Agency FB", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            player1ScoreLabel.ForeColor = Color.White;
            player1ScoreLabel.Location = new Point(13, 777);
            player1ScoreLabel.Name = "player1ScoreLabel";
            player1ScoreLabel.Size = new Size(156, 34);
            player1ScoreLabel.TabIndex = 4;
            player1ScoreLabel.Text = "playername: 500";
            player1ScoreLabel.TextChanged += player1ScoreLabel_TextChanged;
            // 
            // perk1Brew
            // 
            perk1Brew.Image = Properties.Resources.perk1brew;
            perk1Brew.Location = new Point(1, 0);
            perk1Brew.Name = "perk1Brew";
            perk1Brew.Size = new Size(144, 100);
            perk1Brew.SizeMode = PictureBoxSizeMode.AutoSize;
            perk1Brew.TabIndex = 5;
            perk1Brew.TabStop = false;
            // 
            // perk2Cola
            // 
            perk2Cola.Image = Properties.Resources.perk2cola;
            perk2Cola.Location = new Point(0, 0);
            perk2Cola.Name = "perk2Cola";
            perk2Cola.Size = new Size(144, 100);
            perk2Cola.SizeMode = PictureBoxSizeMode.AutoSize;
            perk2Cola.TabIndex = 6;
            perk2Cola.TabStop = false;
            // 
            // perk4Pop
            // 
            perk4Pop.Image = Properties.Resources.perk4pop;
            perk4Pop.Location = new Point(0, 0);
            perk4Pop.Name = "perk4Pop";
            perk4Pop.Size = new Size(144, 100);
            perk4Pop.SizeMode = PictureBoxSizeMode.AutoSize;
            perk4Pop.TabIndex = 7;
            perk4Pop.TabStop = false;
            // 
            // perk3Fizz
            // 
            perk3Fizz.Image = Properties.Resources.perk3fizz;
            perk3Fizz.Location = new Point(3, 0);
            perk3Fizz.Name = "perk3Fizz";
            perk3Fizz.Size = new Size(144, 100);
            perk3Fizz.SizeMode = PictureBoxSizeMode.AutoSize;
            perk3Fizz.TabIndex = 8;
            perk3Fizz.TabStop = false;
            // 
            // perk5Elixir
            // 
            perk5Elixir.Image = Properties.Resources.perk5elixir;
            perk5Elixir.Location = new Point(0, 0);
            perk5Elixir.Name = "perk5Elixir";
            perk5Elixir.Size = new Size(144, 100);
            perk5Elixir.SizeMode = PictureBoxSizeMode.AutoSize;
            perk5Elixir.TabIndex = 9;
            perk5Elixir.TabStop = false;
            // 
            // woodCrate1
            // 
            woodCrate1.BackgroundImage = Properties.Resources.woodCrate1;
            woodCrate1.BackgroundImageLayout = ImageLayout.Center;
            woodCrate1.Image = Properties.Resources.woodCrate1;
            woodCrate1.Location = new Point(638, 419);
            woodCrate1.Name = "woodCrate1";
            woodCrate1.Size = new Size(71, 71);
            woodCrate1.SizeMode = PictureBoxSizeMode.StretchImage;
            woodCrate1.TabIndex = 11;
            woodCrate1.TabStop = false;
            // 
            // m14Icon
            // 
            m14Icon.Image = Properties.Resources.m14Chalk;
            m14Icon.Location = new Point(13, 14);
            m14Icon.Name = "m14Icon";
            m14Icon.Size = new Size(148, 46);
            m14Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            m14Icon.TabIndex = 12;
            m14Icon.TabStop = false;
            // 
            // zSpawnLocation1
            // 
            zSpawnLocation1.BackgroundImage = Properties.Resources.zombieGroundSpawnPoint;
            zSpawnLocation1.BackgroundImageLayout = ImageLayout.Stretch;
            zSpawnLocation1.Location = new Point(1480, 219);
            zSpawnLocation1.Name = "zSpawnLocation1";
            zSpawnLocation1.Size = new Size(50, 50);
            zSpawnLocation1.TabIndex = 13;
            // 
            // zSpawnLocation2
            // 
            zSpawnLocation2.BackgroundImage = Properties.Resources.zombieGroundSpawnPoint;
            zSpawnLocation2.BackgroundImageLayout = ImageLayout.Stretch;
            zSpawnLocation2.Location = new Point(1389, 274);
            zSpawnLocation2.Name = "zSpawnLocation2";
            zSpawnLocation2.Size = new Size(50, 50);
            zSpawnLocation2.TabIndex = 14;
            // 
            // zSpawnLocation3
            // 
            zSpawnLocation3.BackgroundImage = Properties.Resources.zombieGroundSpawnPoint;
            zSpawnLocation3.BackgroundImageLayout = ImageLayout.Stretch;
            zSpawnLocation3.Location = new Point(1480, 370);
            zSpawnLocation3.Name = "zSpawnLocation3";
            zSpawnLocation3.Size = new Size(50, 50);
            zSpawnLocation3.TabIndex = 15;
            // 
            // zSpawnLocation5
            // 
            zSpawnLocation5.BackgroundImage = Properties.Resources.zombieGroundSpawnPoint;
            zSpawnLocation5.BackgroundImageLayout = ImageLayout.Stretch;
            zSpawnLocation5.Location = new Point(1469, 495);
            zSpawnLocation5.Name = "zSpawnLocation5";
            zSpawnLocation5.Size = new Size(50, 50);
            zSpawnLocation5.TabIndex = 17;
            // 
            // zSpawnLocation4
            // 
            zSpawnLocation4.BackgroundImage = Properties.Resources.zombieGroundSpawnPoint;
            zSpawnLocation4.BackgroundImageLayout = ImageLayout.Stretch;
            zSpawnLocation4.Location = new Point(1389, 415);
            zSpawnLocation4.Name = "zSpawnLocation4";
            zSpawnLocation4.Size = new Size(50, 50);
            zSpawnLocation4.TabIndex = 16;
            // 
            // staminaBar
            // 
            staminaBar.Location = new Point(12, 762);
            staminaBar.Name = "staminaBar";
            staminaBar.Size = new Size(49, 10);
            staminaBar.TabIndex = 18;
            staminaBar.Value = 100;
            // 
            // playerXpBar
            // 
            playerXpBar.Location = new Point(0, 854);
            playerXpBar.Name = "playerXpBar";
            playerXpBar.Size = new Size(1586, 20);
            playerXpBar.TabIndex = 19;
            // 
            // gunNameLabel
            // 
            gunNameLabel.AutoSize = true;
            gunNameLabel.Font = new Font("Agency FB", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            gunNameLabel.ForeColor = Color.White;
            gunNameLabel.Location = new Point(1318, 730);
            gunNameLabel.Name = "gunNameLabel";
            gunNameLabel.RightToLeft = RightToLeft.Yes;
            gunNameLabel.Size = new Size(63, 32);
            gunNameLabel.TabIndex = 20;
            gunNameLabel.Text = "label2";
            gunNameLabel.TextChanged += gunNameLabel_TextChanged;
            // 
            // m14WallBuy
            // 
            m14WallBuy.BackColor = Color.Transparent;
            m14WallBuy.Controls.Add(m14Icon);
            m14WallBuy.Location = new Point(12, 415);
            m14WallBuy.Name = "m14WallBuy";
            m14WallBuy.Size = new Size(177, 75);
            m14WallBuy.TabIndex = 21;
            // 
            // buyingLabel
            // 
            buyingLabel.Anchor = AnchorStyles.None;
            buyingLabel.Font = new Font("Agency FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buyingLabel.ForeColor = Color.White;
            buyingLabel.Location = new Point(610, 702);
            buyingLabel.Name = "buyingLabel";
            buyingLabel.Size = new Size(350, 70);
            buyingLabel.TabIndex = 22;
            buyingLabel.Text = "wassgood";
            buyingLabel.TextAlign = ContentAlignment.MiddleCenter;
            buyingLabel.Visible = false;
            // 
            // brewPerk1Buy
            // 
            brewPerk1Buy.BackColor = Color.Transparent;
            brewPerk1Buy.Controls.Add(perk1Brew);
            brewPerk1Buy.Location = new Point(70, 47);
            brewPerk1Buy.Name = "brewPerk1Buy";
            brewPerk1Buy.Size = new Size(145, 144);
            brewPerk1Buy.TabIndex = 23;
            // 
            // colaPerk2Buy
            // 
            colaPerk2Buy.BackColor = Color.Transparent;
            colaPerk2Buy.Controls.Add(perk2Cola);
            colaPerk2Buy.Location = new Point(281, 47);
            colaPerk2Buy.Name = "colaPerk2Buy";
            colaPerk2Buy.Size = new Size(147, 144);
            colaPerk2Buy.TabIndex = 24;
            // 
            // fizzPerk3Buy
            // 
            fizzPerk3Buy.BackColor = Color.Transparent;
            fizzPerk3Buy.Controls.Add(perk3Fizz);
            fizzPerk3Buy.Location = new Point(521, 47);
            fizzPerk3Buy.Name = "fizzPerk3Buy";
            fizzPerk3Buy.Size = new Size(149, 144);
            fizzPerk3Buy.TabIndex = 25;
            // 
            // popPerk4Buy
            // 
            popPerk4Buy.BackColor = Color.Transparent;
            popPerk4Buy.Controls.Add(perk4Pop);
            popPerk4Buy.Location = new Point(752, 47);
            popPerk4Buy.Name = "popPerk4Buy";
            popPerk4Buy.Size = new Size(146, 144);
            popPerk4Buy.TabIndex = 26;
            // 
            // elixirPerkBuy
            // 
            elixirPerkBuy.BackColor = Color.Transparent;
            elixirPerkBuy.Controls.Add(perk5Elixir);
            elixirPerkBuy.Location = new Point(992, 47);
            elixirPerkBuy.Name = "elixirPerkBuy";
            elixirPerkBuy.Size = new Size(147, 144);
            elixirPerkBuy.TabIndex = 27;
            // 
            // Perk1Image
            // 
            Perk1Image.BackColor = Color.Transparent;
            Perk1Image.BackgroundImage = Properties.Resources.HUDplayerperk;
            Perk1Image.BackgroundImageLayout = ImageLayout.Stretch;
            Perk1Image.Location = new Point(646, 776);
            Perk1Image.Name = "Perk1Image";
            Perk1Image.Size = new Size(64, 64);
            Perk1Image.TabIndex = 28;
            // 
            // Perk2Image
            // 
            Perk2Image.BackColor = Color.Transparent;
            Perk2Image.BackgroundImage = Properties.Resources.HUDplayerperk;
            Perk2Image.BackgroundImageLayout = ImageLayout.Stretch;
            Perk2Image.Location = new Point(718, 777);
            Perk2Image.Name = "Perk2Image";
            Perk2Image.Size = new Size(64, 64);
            Perk2Image.TabIndex = 29;
            // 
            // Perk3Image
            // 
            Perk3Image.BackColor = Color.Transparent;
            Perk3Image.BackgroundImage = Properties.Resources.HUDplayerperk;
            Perk3Image.BackgroundImageLayout = ImageLayout.Stretch;
            Perk3Image.Location = new Point(790, 776);
            Perk3Image.Name = "Perk3Image";
            Perk3Image.Size = new Size(64, 64);
            Perk3Image.TabIndex = 30;
            // 
            // Perk4Image
            // 
            Perk4Image.BackColor = Color.Transparent;
            Perk4Image.BackgroundImage = Properties.Resources.HUDplayerperk;
            Perk4Image.BackgroundImageLayout = ImageLayout.Stretch;
            Perk4Image.Location = new Point(862, 776);
            Perk4Image.Name = "Perk4Image";
            Perk4Image.Size = new Size(64, 64);
            Perk4Image.TabIndex = 31;
            // 
            // labelReloading
            // 
            labelReloading.AutoSize = true;
            labelReloading.BackColor = Color.Transparent;
            labelReloading.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelReloading.ForeColor = SystemColors.Control;
            labelReloading.Location = new Point(1297, 772);
            labelReloading.Name = "labelReloading";
            labelReloading.Size = new Size(96, 28);
            labelReloading.TabIndex = 32;
            labelReloading.Text = "Reloading...";
            labelReloading.Visible = false;
            // 
            // TestingMapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(1584, 861);
            Controls.Add(labelReloading);
            Controls.Add(Perk4Image);
            Controls.Add(Perk3Image);
            Controls.Add(Perk2Image);
            Controls.Add(Perk1Image);
            Controls.Add(elixirPerkBuy);
            Controls.Add(popPerk4Buy);
            Controls.Add(fizzPerk3Buy);
            Controls.Add(colaPerk2Buy);
            Controls.Add(brewPerk1Buy);
            Controls.Add(buyingLabel);
            Controls.Add(m14WallBuy);
            Controls.Add(gunNameLabel);
            Controls.Add(playerXpBar);
            Controls.Add(staminaBar);
            Controls.Add(zSpawnLocation5);
            Controls.Add(zSpawnLocation4);
            Controls.Add(zSpawnLocation3);
            Controls.Add(zSpawnLocation2);
            Controls.Add(zSpawnLocation1);
            Controls.Add(woodCrate1);
            Controls.Add(player1ScoreLabel);
            Controls.Add(player1AmmoLabel);
            Controls.Add(player1HealthBar);
            Controls.Add(hudBox);
            Name = "TestingMapForm";
            Text = "Testing";
            ((System.ComponentModel.ISupportInitialize)hudBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)perk1Brew).EndInit();
            ((System.ComponentModel.ISupportInitialize)perk2Cola).EndInit();
            ((System.ComponentModel.ISupportInitialize)perk4Pop).EndInit();
            ((System.ComponentModel.ISupportInitialize)perk3Fizz).EndInit();
            ((System.ComponentModel.ISupportInitialize)perk5Elixir).EndInit();
            ((System.ComponentModel.ISupportInitialize)woodCrate1).EndInit();
            ((System.ComponentModel.ISupportInitialize)m14Icon).EndInit();
            m14WallBuy.ResumeLayout(false);
            brewPerk1Buy.ResumeLayout(false);
            brewPerk1Buy.PerformLayout();
            colaPerk2Buy.ResumeLayout(false);
            colaPerk2Buy.PerformLayout();
            fizzPerk3Buy.ResumeLayout(false);
            fizzPerk3Buy.PerformLayout();
            popPerk4Buy.ResumeLayout(false);
            popPerk4Buy.PerformLayout();
            elixirPerkBuy.ResumeLayout(false);
            elixirPerkBuy.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox hudBox;
        private ProgressBar player1HealthBar;
        private Label player1AmmoLabel;
        private Label player1ScoreLabel;
        private PictureBox perk1Brew;
        private PictureBox perk2Cola;
        private PictureBox perk4Pop;
        private PictureBox perk3Fizz;
        private PictureBox perk5Elixir;
        private PictureBox woodCrate1;
        private PictureBox m14Icon;
        private Panel zSpawnLocation1;
        private Panel zSpawnLocation2;
        private Panel zSpawnLocation3;
        private Panel zSpawnLocation5;
        private Panel zSpawnLocation4;
        private ProgressBar staminaBar;
        private ProgressBar playerXpBar;
        private Label gunNameLabel;
        private Panel m14WallBuy;
        private Label buyingLabel;
        private Panel brewPerk1Buy;
        private Panel colaPerk2Buy;
        private Panel fizzPerk3Buy;
        private Panel popPerk4Buy;
        private Panel elixirPerkBuy;
        private Panel Perk1Image;
        private Panel Perk2Image;
        private Panel Perk3Image;
        private Panel Perk4Image;
        private Label labelReloading;
    }
}