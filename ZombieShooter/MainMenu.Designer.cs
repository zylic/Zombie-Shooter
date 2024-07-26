namespace ZombieShooter
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            playLabel = new Label();
            customizeLabel = new Label();
            settingsLabel = new Label();
            mapLabel = new Label();
            mainMenuLabel = new Label();
            player1NameLabel = new Label();
            mapBigPicture = new PictureBox();
            MainMenuTimer = new System.Windows.Forms.Timer(components);
            infoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)mapBigPicture).BeginInit();
            SuspendLayout();
            // 
            // playLabel
            // 
            playLabel.AutoSize = true;
            playLabel.Font = new Font("Agency FB", 24F, FontStyle.Underline, GraphicsUnit.Point);
            playLabel.ForeColor = Color.White;
            playLabel.Location = new Point(101, 186);
            playLabel.Name = "playLabel";
            playLabel.Size = new Size(135, 40);
            playLabel.TabIndex = 0;
            playLabel.Text = "Start Match";
            playLabel.Click += playLabel_Click;
            playLabel.MouseLeave += customLabel_MouseLeave;
            playLabel.MouseHover += customLabel_MouseHover;
            // 
            // customizeLabel
            // 
            customizeLabel.AutoSize = true;
            customizeLabel.Font = new Font("Agency FB", 24F, FontStyle.Underline, GraphicsUnit.Point);
            customizeLabel.ForeColor = Color.White;
            customizeLabel.Location = new Point(101, 317);
            customizeLabel.Name = "customizeLabel";
            customizeLabel.Size = new Size(120, 40);
            customizeLabel.TabIndex = 1;
            customizeLabel.Text = "Customize";
            customizeLabel.Click += customizeLabel_Click;
            customizeLabel.MouseLeave += customLabel_MouseLeave;
            customizeLabel.MouseHover += customLabel_MouseHover;
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.Font = new Font("Agency FB", 24F, FontStyle.Underline, GraphicsUnit.Point);
            settingsLabel.ForeColor = Color.White;
            settingsLabel.Location = new Point(101, 506);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(99, 40);
            settingsLabel.TabIndex = 2;
            settingsLabel.Text = "Settings";
            settingsLabel.Click += settingsLabel_Click;
            settingsLabel.MouseLeave += customLabel_MouseLeave;
            settingsLabel.MouseHover += customLabel_MouseHover;
            // 
            // mapLabel
            // 
            mapLabel.AutoSize = true;
            mapLabel.Font = new Font("Agency FB", 24F, FontStyle.Underline, GraphicsUnit.Point);
            mapLabel.ForeColor = Color.White;
            mapLabel.Location = new Point(101, 235);
            mapLabel.Name = "mapLabel";
            mapLabel.Size = new Size(58, 40);
            mapLabel.TabIndex = 3;
            mapLabel.Text = "Map";
            mapLabel.Click += mapLabel_Click;
            mapLabel.MouseLeave += customLabel_MouseLeave;
            mapLabel.MouseHover += customLabel_MouseHover;
            // 
            // mainMenuLabel
            // 
            mainMenuLabel.AutoSize = true;
            mainMenuLabel.Font = new Font("Agency FB", 48F, FontStyle.Regular, GraphicsUnit.Point);
            mainMenuLabel.ForeColor = Color.White;
            mainMenuLabel.Location = new Point(93, 60);
            mainMenuLabel.Name = "mainMenuLabel";
            mainMenuLabel.Size = new Size(237, 77);
            mainMenuLabel.TabIndex = 4;
            mainMenuLabel.Text = "Main Menu";
            // 
            // player1NameLabel
            // 
            player1NameLabel.AutoSize = true;
            player1NameLabel.Font = new Font("Agency FB", 24F, FontStyle.Regular, GraphicsUnit.Point);
            player1NameLabel.ForeColor = Color.Yellow;
            player1NameLabel.Location = new Point(1002, 68);
            player1NameLabel.Name = "player1NameLabel";
            player1NameLabel.Size = new Size(92, 40);
            player1NameLabel.TabIndex = 5;
            player1NameLabel.Text = "Player 1";
            player1NameLabel.TextChanged += player1NameLabel_TextChanged;
            // 
            // mapBigPicture
            // 
            mapBigPicture.Location = new Point(101, 617);
            mapBigPicture.Name = "mapBigPicture";
            mapBigPicture.Size = new Size(300, 200);
            mapBigPicture.TabIndex = 6;
            mapBigPicture.TabStop = false;
            // 
            // MainMenuTimer
            // 
            MainMenuTimer.Enabled = true;
            MainMenuTimer.Interval = 500;
            MainMenuTimer.Tick += MainMenuEventTimer;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Agency FB", 24F, FontStyle.Underline, GraphicsUnit.Point);
            infoLabel.ForeColor = Color.White;
            infoLabel.Location = new Point(1475, 777);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(53, 40);
            infoLabel.TabIndex = 7;
            infoLabel.Text = "Info";
            infoLabel.Click += infoLabel_Click;
            infoLabel.MouseLeave += customLabel_MouseLeave;
            infoLabel.MouseHover += customLabel_MouseHover;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.zombiesBackgroundImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1584, 861);
            Controls.Add(infoLabel);
            Controls.Add(mapBigPicture);
            Controls.Add(player1NameLabel);
            Controls.Add(mainMenuLabel);
            Controls.Add(mapLabel);
            Controls.Add(settingsLabel);
            Controls.Add(customizeLabel);
            Controls.Add(playLabel);
            Name = "MainMenu";
            Text = "MainMenu";
            FormClosing += MainMenu_FormClosing;
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)mapBigPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label playLabel;
        private Label customizeLabel;
        private Label settingsLabel;
        private Label mapLabel;
        private Label mainMenuLabel;
        private Label player1NameLabel;
        private PictureBox mapBigPicture;
        private System.Windows.Forms.Timer MainMenuTimer;
        private Label infoLabel;
    }
}